using FreeTestManager.Core.Builders.QuestionBuilder;
using FreeTestManager.Core.Builders.QuestionBuilder.Implementations;
using FreeTestManager.Entities;
using System;
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
            answerCreatePanel.AnswerDeleted += answerCreatePanel_AnswerDeleted;
            questionBuilder.AddAnswer(answerCreatePanel.Answer);

            int answersCount = questionBuilder.Question.Answers.Count;
            answerCreatePanel.Top = (answersCount - 1) * answerCreatePanel.Size.Height;

            this.AnswersPanel.Controls.Add(answerCreatePanel);

            TryAllowSaveQuestion(answersCount);
            TryDisabledAddQuestion(answersCount);
        }

        private void TryAllowSaveQuestion(int answersCount)
        {
            if (answersCount >= 2)
            {
                this.SaveButton.Enabled = true;
            }
        }
        private void TryDisabledAddQuestion(int answersCount)
        {
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

                QuesionCreated?.Invoke(question);
                resetCreateQuestionPanel();

                incrementNumberQuestion();
            }
        }

        private void resetCreateQuestionPanel()
        {
            AnswersPanel.Controls.Clear();
            questionBuilder.Clear();
            textBox.Text = "";
            SaveButton.Enabled = false;
        }

        private void incrementNumberQuestion()
        {
            string text = this.CountQuestionLabel.Text;
            int countPlusOne = int.Parse(text[text.Length - 1].ToString()) + 1;
            this.CountQuestionLabel.Text = text.Substring(0, text.Length - 1) + countPlusOne;
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

        public void answerCreatePanel_AnswerDeleted(Answer answer)
        {
            questionBuilder.DeleteAnswer(answer);
            foreach (Control control in AnswersPanel.Controls)
            {
                if (control is AnswerCreatePanel)
                {
                    if ((control as AnswerCreatePanel).Answer == answer)
                    {
                        AnswersPanel.Controls.Remove(control);
                        control.Dispose();
                        moveAnswers();
                        tryAllowAddQuestion(AnswersPanel.Controls.Count);
                        tryDisabledSaveQuestion(AnswersPanel.Controls.Count);
                    }
                }
            }
        }

        private void tryAllowAddQuestion(int answersCount)
        {
            if (answersCount < 5)
            {
                this.AddQuestionButton.Enabled = true;
            }
        }
        private void tryDisabledSaveQuestion(int answersCount)
        {
            if (answersCount < 2)
            {
                this.SaveButton.Enabled = false;
            }
        }
        private void moveAnswers()
        {
            for (int i = 0; i < AnswersPanel.Controls.Count; i++)
            {
                Control control = AnswersPanel.Controls[i];
                control.Top = i * control.Size.Height;
            }
        }
    }
}
