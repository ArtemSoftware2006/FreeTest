using FreeTest.Forms;
using FreeTestManager.Core.Builders.TestBuilder.Implementations;
using FreeTestManager.Core.ManagerInterfaces;
using FreeTestManager.Core.Providers.Implementations;
using FreeTestManager.Entities;
using FreeTestManager.TestBuilder;
using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace FreeTest
{
    public partial class MainForm : Form
    {
        public Test Test
        {
            get { return testBuilder.GetResult(); }
            set { testBuilder.Test = value; }
        }

        private int currentQuestion;
        private readonly ITestProvider testProvider;
        private readonly ITestBuilder testBuilder;
        public MainForm()
        {
            InitializeComponent();
            currentQuestion = 0;
            testBuilder = new FreeTestBuilder();
            testProvider = new FileTestProvider();

            ToPreviusButton.Enabled = false;
            ToNextButton.Enabled = false;
        }

        private void ReferenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fileName = tryOpenTestFile();

            Test = loadTest(fileName);

            TestNameTextBox.Text = Test.Title;
            TestAuthorTextBox.Text = Test.Author;
            createQuestionPanel.Question = Test.Questions.Last();
            currentQuestion = Test.Questions.Count;

            tryEnabledToPreviousButton();
            tryEnabledToNextButton();
        }

        private Test loadTest(string fileName)
        {
            currentQuestion = 0;
            return testProvider.Load(fileName.Split('.')[0]);
        }

        private string tryOpenTestFile()
        {
            string fileName = showFileDialogForOpenTask();

            if (fileName == null)
            {
                MessageBox.Show(
                    "Не удалось открыть файл",
                    "Ошибка",
                    MessageBoxButtons.OK
                );
            }

            return fileName;
        }

        private string showFileDialogForOpenTask()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Json File|*.json";
            openFileDialog.InitialDirectory = testProvider.BaseDirectoryPath;

            openFileDialog.ShowDialog();

            return openFileDialog.SafeFileName;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveTest();
        }
        private void createQuestionPanel2_QuesionCreated(Question question)
        {
            if (currentQuestion == Test.Questions.Count)
            {
                currentQuestion++;
                ToPreviusButton.Enabled = true;
                testBuilder.AddQuestion(question);
            }
            else
            {
                Test.Questions[currentQuestion] = question;
            }
        }

        private void TestNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TestNameTextBox.Text))
            {
                testBuilder.AddTitle(TestNameTextBox.Text);
            }
        }

        private void TestAuthorTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TestAuthorTextBox.Text))
            {
                testBuilder.AddAuthor(TestAuthorTextBox.Text);
            }
        }

        private void SaveTestButton_Click(object sender, EventArgs e)
        {
            saveTest();
        }

        private void saveTest()
        {
            testBuilder.GetResult();
            if (string.IsNullOrWhiteSpace(Test.Title))
            {
                MessageBox.Show("Название теста не должно быть пустым", "Ошибка");
                return;
            }
            else if (string.IsNullOrWhiteSpace(Test.Author))
            {
                MessageBox.Show("Автор теста должен быть указан", "Ошибка");
                return;
            }
            else if (Test.Questions.Count == 0)
            {
                MessageBox.Show("В тесте должен быть хоть один вопрос.", "Ошибка");
                return;
            }

            bool secusessSaved = testProvider.Save(Test);

            if (!secusessSaved)
            {
                MessageBox.Show("Имя теста пустое. Заполните имяю", "Ошибка");
            }
            else
            {
                MessageBox.Show("Тест успешно сохранён.", "Успешно");
                resetTestUI();
            }
        }

        private void resetTestUI()
        {
            TestNameTextBox.Text = "";
            TestAuthorTextBox.Text = "";
            createQuestionPanel.ResetCreateQuestionPanel();
            currentQuestion = 0;
        }

        private void StartPassingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            testBuilder.GetResult();
            PassingTestForm passingTestForm = new PassingTestForm(Test);
            passingTestForm.ShowDialog();
        }

        private void openAndPassingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fileName = tryOpenTestFile();
            PassingTestForm passingTestForm = new PassingTestForm(loadTest(fileName));
            passingTestForm.ShowDialog();
        }

        private void ToNextButton_Click(object sender, EventArgs e)
        {
            tryEnabledToNextButton();
        }

        private void ToPreviusButton_Click(object sender, EventArgs e)
        {
            tryEnabledToPreviousButton();
        }

        private void tryEnabledToNextButton()
        {
            if (currentQuestion < testBuilder.GetResult().Questions.Count)
            {
                currentQuestion += 1;
                ToPreviusButton.Enabled = true;
                if (currentQuestion != Test.Questions.Count)
                {
                    createQuestionPanel.Question = Test.Questions[currentQuestion];
                }
                else
                {
                    createQuestionPanel.ResetCreateQuestionPanel();
                }
            }

            if (currentQuestion == testBuilder.GetResult().Questions.Count)
            {
                ToNextButton.Enabled = false;
            }
        }

        private void tryEnabledToPreviousButton()
        {
            if (currentQuestion >= 1)
            {
                currentQuestion -= 1;
                ToNextButton.Enabled = true;
                createQuestionPanel.Question = Test.Questions[currentQuestion];
            }

            if (currentQuestion == 0)
            {
                ToPreviusButton.Enabled = false;
            }
        }
    }
}
