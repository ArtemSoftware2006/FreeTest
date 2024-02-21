using System.Windows.Forms;

namespace FreeTest.Controls
{
    public partial class AnswerCheckbox : UserControl
    {
        public int NumberAnswer { get; set; }
        public string Text { get; set; }
        public delegate void AnswerChooseHandler(bool isChecked);
        public event AnswerChooseHandler AnswerChoose;
        public AnswerCheckbox(int numberAnswer, string text)
        {
            InitializeComponent();
            Text = text;
            NumberAnswer = numberAnswer;

            NumberAnswerLabel.Text = NumberAnswer.ToString();
            checkBox.Text = Text;
        }

        private void checkBox_CheckedChanged(object sender, System.EventArgs e)
        {
            AnswerChoose?.Invoke(checkBox.Checked);
        }
    }
}
