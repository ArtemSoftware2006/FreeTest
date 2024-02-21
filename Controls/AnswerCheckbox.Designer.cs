namespace FreeTest.Controls
{
    partial class AnswerCheckbox
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
            this.NumberAnswerLabel = new System.Windows.Forms.Label();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // NumberAnswerLabel
            // 
            this.NumberAnswerLabel.AutoSize = true;
            this.NumberAnswerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberAnswerLabel.Location = new System.Drawing.Point(4, 8);
            this.NumberAnswerLabel.Name = "NumberAnswerLabel";
            this.NumberAnswerLabel.Size = new System.Drawing.Size(22, 20);
            this.NumberAnswerLabel.TabIndex = 0;
            this.NumberAnswerLabel.Text = "1.";
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Location = new System.Drawing.Point(32, 8);
            this.checkBox.MaximumSize = new System.Drawing.Size(500, 0);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(125, 20);
            this.checkBox.TabIndex = 2;
            this.checkBox.Text = "Текст вопроса";
            this.checkBox.UseVisualStyleBackColor = true;
            this.checkBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // AnswerCheckbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.NumberAnswerLabel);
            this.Name = "AnswerCheckbox";
            this.Size = new System.Drawing.Size(566, 79);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NumberAnswerLabel;
        private System.Windows.Forms.CheckBox checkBox;
    }
}
