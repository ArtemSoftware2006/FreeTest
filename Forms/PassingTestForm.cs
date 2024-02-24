using FreeTest.Controls;
using FreeTestManager.Entities;
using System.Drawing;
using System.Windows.Forms;

namespace FreeTest.Forms
{
    public partial class PassingTestForm : Form
    {
        public Test Test { get; set; }
        public PassingTestForm(Test test)
        {
            Test = test;

            InitializeComponent();

            TestTitleValueLabel.Text = Test.Title;
            TestAuthorValueLabel.Text = Test.Author;
        }

        private void StartTestButton_Click(object sender, System.EventArgs e)
        {
            hideGreetingControls();

            AnswerChooseControl answerChooseControl = new AnswerChooseControl(Test);
            answerChooseControl.Location = new Point(0, 0);
            this.Controls.Add(answerChooseControl);
            this.Size = new Size(this.Size.Width, this.Size.Height + 120);
        }

        private void hideGreetingControls()
        {
            TestAuthorLabel.Visible = false;
            TestAuthorValueLabel.Visible = false;
            TestTitleLabel.Visible = false;
            TestTitleValueLabel.Visible = false;
            StartTestButton.Visible = false;

            GreetingLabel.Visible = false;

        }
    }
}
