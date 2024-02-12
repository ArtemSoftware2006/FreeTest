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
            this.ReferenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PassingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.MainMenuStrip.Size = new System.Drawing.Size(689, 28);
            this.MainMenuStrip.TabIndex = 0;
            this.MainMenuStrip.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.FileToolStripMenuItem.Text = "Файл";
            // 
            // ReferenceToolStripMenuItem
            // 
            this.ReferenceToolStripMenuItem.Name = "ReferenceToolStripMenuItem";
            this.ReferenceToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.ReferenceToolStripMenuItem.Text = "Справка";
            this.ReferenceToolStripMenuItem.Click += new System.EventHandler(this.ReferenceToolStripMenuItem_Click);
            // 
            // EditingToolStripMenuItem
            // 
            this.EditingToolStripMenuItem.Name = "EditingToolStripMenuItem";
            this.EditingToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.EditingToolStripMenuItem.Text = "Редактирование";
            // 
            // PassingToolStripMenuItem
            // 
            this.PassingToolStripMenuItem.Name = "PassingToolStripMenuItem";
            this.PassingToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.PassingToolStripMenuItem.Text = "Прохождение";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(689, 415);
            this.Controls.Add(this.MainMenuStrip);
            this.MainMenuStrip = this.MainMenuStrip;
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
    }
}

