using FreeTest.Services;
using FreeTestManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FreeTest.Controls
{
    public partial class AnswerChooseControl : UserControl
    {
        public delegate void TakeAnswersHandler(List<Answer> answers);
        public event TakeAnswersHandler TakeAnswers;
        public List<Answer> Answers { get; set; }
        public AnswerChooseControl(List<Answer> answers)
        {
            InitializeComponent();
            Answers = answers;
            showAnswers(Answers);
        }

        private void TakeAnswerButton_Click(object sender, EventArgs e)
        {

        }

        private void showAnswers(List<Answer> answers)
        {
            for (int i = 0; i < answers.Count; i++)
            {
                var answerCheckbox = new AnswerCheckbox(i + 1, answers[i].Text);
                answerCheckbox.Top = i * answerCheckbox.Size.Height;
                AnswersPanel.Controls.Add(answerCheckbox);
            }
        }
    }
}
