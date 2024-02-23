using FreeTest.Services;
using FreeTestManager.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace FreeTest.Controls
{
    public partial class AnswerChooseControl : UserControl
    {
        public Test Test { get; }

        public delegate void TakeAnswersHandler(List<Answer> answers);
        public event TakeAnswersHandler TakeAnswers;
        private int currentQuestion;
        private int countTrueAnswers;
        private PassingTestManager passingTestManager;
        private Dictionary<Guid, bool> checkedAnswers;
        public AnswerChooseControl(Test test)
        {
            InitializeComponent();
            currentQuestion = 0;
            countTrueAnswers = 0;
            Test = test;
            checkedAnswers = new Dictionary<Guid, bool>();

            passingTestManager = new PassingTestManager(Test);

            showQuestion();
        }

        private void TakeAnswerButton_Click(object sender, EventArgs e)
        {
            var resultAnswers = passingTestManager.CheckEverMultiAnswers(
                   Test.Questions[currentQuestion].Id,
                   checkedAnswers
                        .Where(x => x.Value == true)
                        .Select(x => x.Key)
                        .ToList()
            );

            reportUserAnswers(resultAnswers);

            if (!tryShowNextQuestion())
            {
                TakeAnswerButton.Enabled = false;
                MessageBox.Show($"Тест окончен!\n Вы набрали {countTrueAnswers} из {Test.Questions.Count}");
            }
        }

        private void reportUserAnswers(List<KeyValuePair<Guid, bool>> resultAnswers)
        {
            var reportAnswers = passingTestManager
                .ReportAnswers(Test.Questions[currentQuestion].Id, resultAnswers);

            markAnswersCheckboxes(reportAnswers);

            if (reportAnswers.All(x => x.Value == true) 
                && reportAnswers.Count == resultAnswers.Count)
            {
                countTrueAnswers++;
            }
        }

        private void markAnswersCheckboxes(List<KeyValuePair<Guid, bool>> reportAnswers)
        {
            reportAnswers.ForEach(answer =>
            {
                foreach (AnswerCheckbox answerCheckbox in AnswersPanel.Controls)
                {
                    answerCheckbox.Enabled = false;
                    if (answer.Key == answerCheckbox.AnswerId)
                    {
                        answerCheckbox.BackColor = answer.Value == true ? Color.Green : Color.Red;
                    }
                }
            });
        }

        private bool tryShowNextQuestion()
        {
            currentQuestion++;

            if (currentQuestion >= Test.Questions.Count)
            {
                return false;
            }
            showQuestion();

            return true;
        }

        private void showQuestion()
        {
            showAnswers(Test.Questions[currentQuestion].Answers);
            QuestionTextLabel.Text = Test.Questions[currentQuestion].Text;
            NumberQuestionLabel.Text = $"Вопрос {currentQuestion + 1} из {Test.Questions.Count}";
        }

        private void showAnswers(List<Answer> answers)
        {
            for (int i = 0; i < answers.Count; i++)
            {
                var answerCheckbox = new AnswerCheckbox(i + 1, answers[i].Id, answers[i].Text);
                answerCheckbox.AnswerChoose += answerCheckbox_AnswerChoose;
                answerCheckbox.Top = i * answerCheckbox.Size.Height;
                AnswersPanel.Controls.Add(answerCheckbox);
            }
        }

        private void answerCheckbox_AnswerChoose(KeyValuePair<Guid, bool> answerCheck)
        {
            if (checkedAnswers.ContainsKey(answerCheck.Key))
            {
                checkedAnswers[answerCheck.Key] = answerCheck.Value;
            }
            else
            {
                checkedAnswers.Add(answerCheck.Key, answerCheck.Value);
            }
        }
    }
}
