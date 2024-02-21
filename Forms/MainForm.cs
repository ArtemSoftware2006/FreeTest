using FreeTest.Forms;
using FreeTestManager.Core.Builders.TestBuilder.Implementations;
using FreeTestManager.Core.ManagerInterfaces;
using FreeTestManager.Core.Providers.Implementations;
using FreeTestManager.Entities;
using FreeTestManager.TestBuilder;
using System;
using System.Windows.Forms;

namespace FreeTest
{
    public partial class MainForm : Form
    {
        public Test Test { get; set; }
        private readonly ITestProvider testProvider;
        private readonly ITestBuilder testBuilder;
        public MainForm()
        {
            InitializeComponent();
            Test = new Test();
            testBuilder = new FreeTestBuilder();
            testProvider = new FileTestProvider();
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
        }

        private Test loadTest(string fileName)
        {
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
            testBuilder.AddQuestion(question);
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
            Test = testBuilder.GetResult();
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
                MessageBox.Show($"Название теста пустое или тест с таким именем уже существует\nИмя теста = {Test.Title}");
            }
            else
            {
                MessageBox.Show("Тест успешно сохранён.", "Успешно");
            }
        }

        private void StartPassingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Test = testBuilder.GetResult();
            PassingTestForm passingTestForm = new PassingTestForm(Test);
            passingTestForm.ShowDialog();
        }

        private void открытьИПройтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fileName = tryOpenTestFile();
            PassingTestForm passingTestForm = new PassingTestForm(loadTest(fileName));
            passingTestForm.ShowDialog();
        }
    }
}
