using System.ComponentModel;
using System;
using System.Windows.Forms;
using FreeTestManager.Entities;
using System.Drawing;

namespace FreeTest.Controls
{
    [DefaultEvent(nameof(AnswerChanged))]
    public partial class AnswerCreatePanel : UserControl
    {
        private const int WIDTH = 600;
        private const int HEIGTH = 45;
        public Answer Answer { get; set; }
        public delegate void AnswerCreateHandler(Answer answer);
        [Browsable(true)]
        public event AnswerCreateHandler AnswerChanged;
        public delegate void AnswerDeleteHandler(Answer answer);
        [Browsable(true)]
        public event AnswerCreateHandler AnswerDeleted;
        public AnswerCreatePanel()
        {
            Size = new Size(WIDTH, HEIGTH);
            Answer = new Answer();
            InitializeComponent();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            Answer.Text = textBox.Text;
            AnswerChanged?.Invoke(Answer);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Answer.Value = (int)numericUpDown1.Value;
            AnswerChanged?.Invoke(Answer);
        }

        private void IsTrueCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Answer.IsTrue = IsTrueCheckBox.Checked;

            if (Answer.IsTrue)
            {
                numericUpDown1.Enabled = true;
            }
            else
            {
                numericUpDown1.Enabled = false;
            }

            AnswerChanged?.Invoke(Answer);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            AnswerDeleted?.Invoke(Answer);
        }
    }
}
