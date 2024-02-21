namespace FreeTest.Forms
{
    partial class PassingTestForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GreetingLabel = new System.Windows.Forms.Label();
            this.StartTestButton = new System.Windows.Forms.Button();
            this.TestAuthorLabel = new System.Windows.Forms.Label();
            this.TestTitleLabel = new System.Windows.Forms.Label();
            this.TestTitleValueLabel = new System.Windows.Forms.Label();
            this.TestAuthorValueLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GreetingLabel
            // 
            this.GreetingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.GreetingLabel.AutoSize = true;
            this.GreetingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GreetingLabel.Location = new System.Drawing.Point(140, 67);
            this.GreetingLabel.Name = "GreetingLabel";
            this.GreetingLabel.Size = new System.Drawing.Size(428, 25);
            this.GreetingLabel.TabIndex = 0;
            this.GreetingLabel.Text = "В этой форме можно пройти тестирование";
            // 
            // StartTestButton
            // 
            this.StartTestButton.Location = new System.Drawing.Point(194, 318);
            this.StartTestButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StartTestButton.Name = "StartTestButton";
            this.StartTestButton.Size = new System.Drawing.Size(322, 51);
            this.StartTestButton.TabIndex = 1;
            this.StartTestButton.Text = "Начать тестирование";
            this.StartTestButton.UseVisualStyleBackColor = true;
            this.StartTestButton.Click += new System.EventHandler(this.StartTestButton_Click);
            // 
            // TestAuthorLabel
            // 
            this.TestAuthorLabel.AutoSize = true;
            this.TestAuthorLabel.Location = new System.Drawing.Point(190, 182);
            this.TestAuthorLabel.Name = "TestAuthorLabel";
            this.TestAuthorLabel.Size = new System.Drawing.Size(61, 20);
            this.TestAuthorLabel.TabIndex = 2;
            this.TestAuthorLabel.Text = "Автор";
            // 
            // TestTitleLabel
            // 
            this.TestTitleLabel.AutoSize = true;
            this.TestTitleLabel.Location = new System.Drawing.Point(190, 145);
            this.TestTitleLabel.Name = "TestTitleLabel";
            this.TestTitleLabel.Size = new System.Drawing.Size(145, 20);
            this.TestTitleLabel.TabIndex = 3;
            this.TestTitleLabel.Text = "Название теста";
            // 
            // TestTitleValueLabel
            // 
            this.TestTitleValueLabel.AutoSize = true;
            this.TestTitleValueLabel.Location = new System.Drawing.Point(371, 145);
            this.TestTitleValueLabel.Name = "TestTitleValueLabel";
            this.TestTitleValueLabel.Size = new System.Drawing.Size(0, 20);
            this.TestTitleValueLabel.TabIndex = 4;
            // 
            // TestAuthorValueLabel
            // 
            this.TestAuthorValueLabel.AutoSize = true;
            this.TestAuthorValueLabel.Location = new System.Drawing.Point(371, 182);
            this.TestAuthorValueLabel.Name = "TestAuthorValueLabel";
            this.TestAuthorValueLabel.Size = new System.Drawing.Size(0, 20);
            this.TestAuthorValueLabel.TabIndex = 5;
            // 
            // PassingTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(715, 438);
            this.Controls.Add(this.TestAuthorValueLabel);
            this.Controls.Add(this.TestTitleValueLabel);
            this.Controls.Add(this.TestTitleLabel);
            this.Controls.Add(this.TestAuthorLabel);
            this.Controls.Add(this.StartTestButton);
            this.Controls.Add(this.GreetingLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PassingTest";
            this.Text = "PassingTest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GreetingLabel;
        private System.Windows.Forms.Button StartTestButton;
        private System.Windows.Forms.Label TestAuthorLabel;
        private System.Windows.Forms.Label TestTitleLabel;
        private System.Windows.Forms.Label TestTitleValueLabel;
        private System.Windows.Forms.Label TestAuthorValueLabel;
    }
}