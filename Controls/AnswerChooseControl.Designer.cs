namespace FreeTest.Controls
{
    partial class AnswerChooseControl
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
            this.QuestionTextLabel = new System.Windows.Forms.Label();
            this.NumberQuestionLabel = new System.Windows.Forms.Label();
            this.AnswersPanel = new System.Windows.Forms.Panel();
            this.TakeAnswerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // QuestionTextLabel
            // 
            this.QuestionTextLabel.AutoSize = true;
            this.QuestionTextLabel.Location = new System.Drawing.Point(50, 77);
            this.QuestionTextLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.QuestionTextLabel.Name = "QuestionTextLabel";
            this.QuestionTextLabel.Size = new System.Drawing.Size(149, 20);
            this.QuestionTextLabel.TabIndex = 0;
            this.QuestionTextLabel.Text = "QuestionTextLabel";
            // 
            // NumberQuestionLabel
            // 
            this.NumberQuestionLabel.AutoSize = true;
            this.NumberQuestionLabel.Location = new System.Drawing.Point(50, 38);
            this.NumberQuestionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NumberQuestionLabel.Name = "NumberQuestionLabel";
            this.NumberQuestionLabel.Size = new System.Drawing.Size(176, 20);
            this.NumberQuestionLabel.TabIndex = 1;
            this.NumberQuestionLabel.Text = "NumberQuestionLabel";
            // 
            // AnswersPanel
            // 
            this.AnswersPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AnswersPanel.Location = new System.Drawing.Point(54, 119);
            this.AnswersPanel.Name = "AnswersPanel";
            this.AnswersPanel.Size = new System.Drawing.Size(586, 357);
            this.AnswersPanel.TabIndex = 2;
            // 
            // TakeAnswerButton
            // 
            this.TakeAnswerButton.Location = new System.Drawing.Point(54, 500);
            this.TakeAnswerButton.Name = "TakeAnswerButton";
            this.TakeAnswerButton.Size = new System.Drawing.Size(103, 39);
            this.TakeAnswerButton.TabIndex = 3;
            this.TakeAnswerButton.Text = "Ответить";
            this.TakeAnswerButton.UseVisualStyleBackColor = true;
            this.TakeAnswerButton.Click += new System.EventHandler(this.TakeAnswerButton_Click);
            // 
            // AnswerChooseControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TakeAnswerButton);
            this.Controls.Add(this.AnswersPanel);
            this.Controls.Add(this.NumberQuestionLabel);
            this.Controls.Add(this.QuestionTextLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AnswerChooseControl";
            this.Size = new System.Drawing.Size(698, 583);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label QuestionTextLabel;
        private System.Windows.Forms.Label NumberQuestionLabel;
        private System.Windows.Forms.Panel AnswersPanel;
        private System.Windows.Forms.Button TakeAnswerButton;
    }
}
