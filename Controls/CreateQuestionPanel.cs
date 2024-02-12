using FreeTest.Services.Extensions;
using FreeTestManager.Core.Builders.QuestionBuilder;
using FreeTestManager.Core.Builders.QuestionBuilder.Implementations;
using FreeTestManager.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace FreeTest.Controls
{
    [DefaultEvent(nameof(QuesionCreated))]
    public partial class CreateQuestionPanel : UserControl
    {
        private readonly IQuestionBuilder questionBuilder;
        public delegate void QuestionCreatedHandler(Question question);
        [Browsable(true)]
        public event QuestionCreatedHandler QuesionCreated;
        public CreateQuestionPanel()
        {
            questionBuilder = new FreeQuestionBuilder();
            InitializeComponent();
        }

        private void AddQuestionButton_Click(object sender, EventArgs e)
        {
            AnswerCreatePanel answerCreatePanel = new AnswerCreatePanel();
            questionBuilder.AddAnswer(answerCreatePanel.Answer);

            int answersCount = questionBuilder.Question.Answers.Count;
            answerCreatePanel.Top = (answersCount - 1) * answerCreatePanel.Size.Height;

            this.AnswersPanel.Controls.Add(answerCreatePanel);

            if (answersCount >= 2)
            {
                this.SaveButton.Enabled = true;
            }
            if (answersCount >= 5)
            {
                this.AddQuestionButton.Enabled = false;
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox.Text))
            {
                questionBuilder.AddText(textBox.Text);
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(questionBuilder.GetQuestion().Text))
            {
                MessageBox.Show("Заполните текст вопроса", "Ошибка");
            }
            else if(isAnswersEmpty())
            {
                MessageBox.Show("Заполните текст всех ответов", "Ошибка");
            }
            else if (!isOneAnswerIsTrue())
            {
                MessageBox.Show("Хотя бы один ответ должен быть верным", "Ошибка");
            }
            else
            {
                Question question = questionBuilder.GetQuestion().Clone();

                AnswersPanel.Controls.Clear();

                QuesionCreated?.Invoke(question);

                clearPanel();
            }
        }

        private void clearPanel()
        {
            questionBuilder.Clear();
            textBox.Text = "";
        }

        private bool isAnswersEmpty()
        {
            return questionBuilder
                    .GetQuestion()
                    .Answers
                    .Any(x => string.IsNullOrWhiteSpace(x.Text));
        }
        private bool isOneAnswerIsTrue()
        {
            return questionBuilder
                    .GetQuestion()
                    .Answers
                    .Any(x => x.IsTrue);
        }
    }
}
