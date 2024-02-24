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
        public Question Question
        {
            get { return question; }
            set
            {
                questionBuilder.Question = value;
                question = value;
                showQuestion();
            }
        }

        public delegate void QuestionCreatedHandler(Question question);
        [Browsable(true)]
        public event QuestionCreatedHandler QuesionCreated;

        private readonly IQuestionBuilder questionBuilder;
        private Question question;

        public CreateQuestionPanel()
        {
            questionBuilder = new FreeQuestionBuilder();
            question = new Question();
            InitializeComponent();
        }

        private void AddQuestionButton_Click(object sender, EventArgs e)
        {
            AnswersPanel.Controls.Clear();
            var answer = new Answer();
            questionBuilder.AddAnswer(answer);
            showAnswers(questionBuilder.Question.Answers);
        }

        private void showQuestion()
        {
            QuestionTextTextBox.Text = question.Text;
            showAnswers(questionBuilder.Question.Answers);
        }

        private void showAnswers(List<Answer> answers)
        {
            for(int i = 0; i < answers.Count; i++) 
            { 
                AnswerCreatePanel answerCreatePanel = new AnswerCreatePanel(answers[i]);
                answerCreatePanel.AnswerDeleted += answerCreatePanel_AnswerDeleted;

                answerCreatePanel.Top = i * answerCreatePanel.Size.Height;

                this.AnswersPanel.Controls.Add(answerCreatePanel);

                TryAllowSaveQuestion(answers.Count);
                TryDisabledAddQuestion(answers.Count);
            }
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
            if (!string.IsNullOrWhiteSpace(QuestionTextTextBox.Text))
            {
                questionBuilder.AddText(QuestionTextTextBox.Text);
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
                ResetCreateQuestionPanel();

                incrementNumberQuestion();
            }
        }
        public void ResetCreateQuestionPanel()
        {
            AnswersPanel.Controls.Clear();
            questionBuilder.Clear();
            QuestionTextTextBox.Text = "";
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
            foreach (AnswerCreatePanel control in AnswersPanel.Controls)
            {   
                if (control.Answer == answer)
                {
                    AnswersPanel.Controls.Remove(control);
                    control.Dispose();
                    moveAnswers();
                    tryAllowAddQuestion(AnswersPanel.Controls.Count);
                    tryDisabledSaveQuestion(AnswersPanel.Controls.Count);
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
