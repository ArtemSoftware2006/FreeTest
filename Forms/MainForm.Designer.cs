namespace FreeTest
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StartEditingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PassingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StartPassingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReferenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createQuestionPanel2 = new FreeTest.Controls.CreateQuestionPanel();
            this.MainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.MainMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.EditingToolStripMenuItem,
            this.PassingToolStripMenuItem,
            this.ReferenceToolStripMenuItem});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Size = new System.Drawing.Size(765, 28);
            this.MainMenuStrip.TabIndex = 0;
            this.MainMenuStrip.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.FileToolStripMenuItem.Text = "Файл";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.openToolStripMenuItem.Text = "Открыть";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.saveToolStripMenuItem.Text = "Сохранить";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // EditingToolStripMenuItem
            // 
            this.EditingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StartEditingToolStripMenuItem});
            this.EditingToolStripMenuItem.Name = "EditingToolStripMenuItem";
            this.EditingToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.EditingToolStripMenuItem.Text = "Редактирование";
            // 
            // StartEditingToolStripMenuItem
            // 
            this.StartEditingToolStripMenuItem.Name = "StartEditingToolStripMenuItem";
            this.StartEditingToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.StartEditingToolStripMenuItem.Text = "Начать редактирование";
            // 
            // PassingToolStripMenuItem
            // 
            this.PassingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StartPassingToolStripMenuItem});
            this.PassingToolStripMenuItem.Name = "PassingToolStripMenuItem";
            this.PassingToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.PassingToolStripMenuItem.Text = "Прохождение";
            // 
            // StartPassingToolStripMenuItem
            // 
            this.StartPassingToolStripMenuItem.Name = "StartPassingToolStripMenuItem";
            this.StartPassingToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.StartPassingToolStripMenuItem.Text = "Начать прохождение";
            // 
            // ReferenceToolStripMenuItem
            // 
            this.ReferenceToolStripMenuItem.Name = "ReferenceToolStripMenuItem";
            this.ReferenceToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.ReferenceToolStripMenuItem.Text = "Справка";
            this.ReferenceToolStripMenuItem.Click += new System.EventHandler(this.ReferenceToolStripMenuItem_Click);
            // 
            // createQuestionPanel2
            // 
            this.createQuestionPanel2.Location = new System.Drawing.Point(2, 31);
            this.createQuestionPanel2.Name = "createQuestionPanel2";
            this.createQuestionPanel2.Size = new System.Drawing.Size(763, 531);
            this.createQuestionPanel2.TabIndex = 4;
            this.createQuestionPanel2.QuesionCreated += new FreeTest.Controls.CreateQuestionPanel.QuestionCreatedHandler(this.createQuestionPanel2_QuesionCreated);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(765, 561);
            this.Controls.Add(this.createQuestionPanel2);
            this.Controls.Add(this.MainMenuStrip);
            this.Name = "MainForm";
            this.Text = "FreeTest";
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReferenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PassingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StartEditingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StartPassingToolStripMenuItem;
        private Controls.CreateQuestionPanel createQuestionPanel2;
    }
}

