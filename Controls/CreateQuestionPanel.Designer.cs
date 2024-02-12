namespace FreeTest.Controls
{
    partial class CreateQuestionPanel
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.TitleLabel = new System.Windows.Forms.Label();
            this.QuestionTextLabel = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.AddQuestionButton = new System.Windows.Forms.Button();
            this.AnswersPanel = new System.Windows.Forms.Panel();
            this.AnswersLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TitleLabel.Location = new System.Drawing.Point(12, 11);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(181, 25);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Создание вопроса";
            // 
            // QuestionTextLabel
            // 
            this.QuestionTextLabel.AutoSize = true;
            this.QuestionTextLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.QuestionTextLabel.Location = new System.Drawing.Point(14, 56);
            this.QuestionTextLabel.Name = "QuestionTextLabel";
            this.QuestionTextLabel.Size = new System.Drawing.Size(103, 16);
            this.QuestionTextLabel.TabIndex = 1;
            this.QuestionTextLabel.Text = "Текст вопроса";
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(17, 75);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(340, 22);
            this.textBox.TabIndex = 2;
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // AddQuestionButton
            // 
            this.AddQuestionButton.Location = new System.Drawing.Point(363, 75);
            this.AddQuestionButton.Name = "AddQuestionButton";
            this.AddQuestionButton.Size = new System.Drawing.Size(187, 27);
            this.AddQuestionButton.TabIndex = 3;
            this.AddQuestionButton.Text = "Добавить ответ";
            this.AddQuestionButton.UseVisualStyleBackColor = true;
            this.AddQuestionButton.Click += new System.EventHandler(this.AddQuestionButton_Click);
            // 
            // AnswersPanel
            // 
            this.AnswersPanel.AutoScroll = true;
            this.AnswersPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AnswersPanel.Location = new System.Drawing.Point(17, 131);
            this.AnswersPanel.Name = "AnswersPanel";
            this.AnswersPanel.Size = new System.Drawing.Size(726, 381);
            this.AnswersPanel.TabIndex = 4;
            // 
            // AnswersLabel
            // 
            this.AnswersLabel.AutoSize = true;
            this.AnswersLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AnswersLabel.Location = new System.Drawing.Point(14, 112);
            this.AnswersLabel.Name = "AnswersLabel";
            this.AnswersLabel.Size = new System.Drawing.Size(56, 16);
            this.AnswersLabel.TabIndex = 5;
            this.AnswersLabel.Text = "Ответы";
            // 
            // SaveButton
            // 
            this.SaveButton.Enabled = false;
            this.SaveButton.Location = new System.Drawing.Point(556, 75);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(187, 27);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Text = "Сохранить вопрос";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CreateQuestionPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.AnswersLabel);
            this.Controls.Add(this.AnswersPanel);
            this.Controls.Add(this.AddQuestionButton);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.QuestionTextLabel);
            this.Controls.Add(this.TitleLabel);
            this.Name = "CreateQuestionPanel";
            this.Size = new System.Drawing.Size(762, 609);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label QuestionTextLabel;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button AddQuestionButton;
        private System.Windows.Forms.Panel AnswersPanel;
        private System.Windows.Forms.Label AnswersLabel;
        private System.Windows.Forms.Button SaveButton;
    }
}
