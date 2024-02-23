using FreeTestManager.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FreeTest.Controls
{
    public partial class AnswerCheckbox : UserControl
    {
        public int NumberAnswer { get; set; }
        public string Text { get; set; }
        public Guid AnswerId { get; set; }
        public delegate void AnswerChooseHandler(KeyValuePair<Guid, bool> answerCheck);
        public event AnswerChooseHandler AnswerChoose;

        public AnswerCheckbox() { }
        public AnswerCheckbox(int numberAnswer, Guid answerId, string text)
        {
            InitializeComponent();
            Text = text;
            NumberAnswer = numberAnswer;
            AnswerId = answerId;

            NumberAnswerLabel.Text = NumberAnswer.ToString();
            checkBox.Text = Text;
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            AnswerChoose?.Invoke(new KeyValuePair<Guid, bool>(AnswerId, checkBox.Checked));
        }
    }
}
