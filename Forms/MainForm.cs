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
            string fileName = showFileDialogForOpenTask();

            if (fileName != null) 
            {
                MessageBox.Show(
                    "Не удалось открыть файл", 
                    "Ошибка",
                    MessageBoxButtons.OK
                );
            }

            Test = testProvider.Load(fileName.Split('.')[0]);
        }

        private string showFileDialogForOpenTask()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Json File|*.json";
            openFileDialog.InitialDirectory = testProvider.BaseDirectoryPath;

            openFileDialog.ShowDialog();

            return openFileDialog.FileName;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Test is null && string.IsNullOrWhiteSpace(Test.Title))
            {
                MessageBox.Show(
                    "Не удалось сохранить тест. Пустое название теста.",
                    "Ошибка",
                    MessageBoxButtons.OK
                );
            }

            bool result = testProvider.Save(Test);

            if (result)
            {
                MessageBox.Show(
                    "Тест сохранён успешно.",
                    "Успешно",
                    MessageBoxButtons.OK
                );
            }
            else
            {
                MessageBox.Show(
                    "Тест не сохранён успешно.",
                    "Ошибка",
                    MessageBoxButtons.OK
                );
            }
        }

        private void createQuestionPanel2_QuesionCreated(Question question)
        {
            testBuilder.AddQuestion(question);
            MessageBox.Show(testBuilder.GetResult().Questions.Count.ToString());
        }
    }
}
