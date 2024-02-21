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
            this.открытьИПройтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReferenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createQuestionPanel2 = new FreeTest.Controls.CreateQuestionPanel();
            this.TestNameTextBox = new System.Windows.Forms.TextBox();
            this.SaveTestButton = new System.Windows.Forms.Button();
            this.HeaderTestFormLabel = new System.Windows.Forms.Label();
            this.TestNameLabel = new System.Windows.Forms.Label();
            this.TestAuthorLabel = new System.Windows.Forms.Label();
            this.TestAuthorTextBox = new System.Windows.Forms.TextBox();
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
            this.MainMenuStrip.Size = new System.Drawing.Size(1115, 28);
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
            this.StartPassingToolStripMenuItem,
            this.открытьИПройтиToolStripMenuItem});
            this.PassingToolStripMenuItem.Name = "PassingToolStripMenuItem";
            this.PassingToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.PassingToolStripMenuItem.Text = "Прохождение";
            // 
            // StartPassingToolStripMenuItem
            // 
            this.StartPassingToolStripMenuItem.Name = "StartPassingToolStripMenuItem";
            this.StartPassingToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.StartPassingToolStripMenuItem.Text = "Начать прохождение";
            this.StartPassingToolStripMenuItem.Click += new System.EventHandler(this.StartPassingToolStripMenuItem_Click);
            // 
            // открытьИПройтиToolStripMenuItem
            // 
            this.открытьИПройтиToolStripMenuItem.Name = "открытьИПройтиToolStripMenuItem";
            this.открытьИПройтиToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.открытьИПройтиToolStripMenuItem.Text = "Открыть и пройти";
            this.открытьИПройтиToolStripMenuItem.Click += new System.EventHandler(this.открытьИПройтиToolStripMenuItem_Click);
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
            this.createQuestionPanel2.Location = new System.Drawing.Point(359, 31);
            this.createQuestionPanel2.Name = "createQuestionPanel2";
            this.createQuestionPanel2.Size = new System.Drawing.Size(756, 531);
            this.createQuestionPanel2.TabIndex = 4;
            this.createQuestionPanel2.QuesionCreated += new FreeTest.Controls.CreateQuestionPanel.QuestionCreatedHandler(this.createQuestionPanel2_QuesionCreated);
            // 
            // TestNameTextBox
            // 
            this.TestNameTextBox.Location = new System.Drawing.Point(17, 181);
            this.TestNameTextBox.Name = "TestNameTextBox";
            this.TestNameTextBox.Size = new System.Drawing.Size(327, 22);
            this.TestNameTextBox.TabIndex = 5;
            this.TestNameTextBox.TextChanged += new System.EventHandler(this.TestNameTextBox_TextChanged);
            // 
            // SaveTestButton
            // 
            this.SaveTestButton.Location = new System.Drawing.Point(17, 280);
            this.SaveTestButton.Name = "SaveTestButton";
            this.SaveTestButton.Size = new System.Drawing.Size(157, 24);
            this.SaveTestButton.TabIndex = 6;
            this.SaveTestButton.Text = "Сохранить тест";
            this.SaveTestButton.UseVisualStyleBackColor = true;
            this.SaveTestButton.Click += new System.EventHandler(this.SaveTestButton_Click);
            // 
            // HeaderTestFormLabel
            // 
            this.HeaderTestFormLabel.AutoSize = true;
            this.HeaderTestFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HeaderTestFormLabel.Location = new System.Drawing.Point(12, 46);
            this.HeaderTestFormLabel.Name = "HeaderTestFormLabel";
            this.HeaderTestFormLabel.Size = new System.Drawing.Size(162, 25);
            this.HeaderTestFormLabel.TabIndex = 7;
            this.HeaderTestFormLabel.Text = "Создание теста";
            // 
            // TestNameLabel
            // 
            this.TestNameLabel.AutoSize = true;
            this.TestNameLabel.Location = new System.Drawing.Point(14, 162);
            this.TestNameLabel.Name = "TestNameLabel";
            this.TestNameLabel.Size = new System.Drawing.Size(113, 16);
            this.TestNameLabel.TabIndex = 8;
            this.TestNameLabel.Text = "Название теста";
            // 
            // TestAuthorLabel
            // 
            this.TestAuthorLabel.AutoSize = true;
            this.TestAuthorLabel.Location = new System.Drawing.Point(14, 217);
            this.TestAuthorLabel.Name = "TestAuthorLabel";
            this.TestAuthorLabel.Size = new System.Drawing.Size(87, 16);
            this.TestAuthorLabel.TabIndex = 10;
            this.TestAuthorLabel.Text = "Автор теста";
            // 
            // TestAuthorTextBox
            // 
            this.TestAuthorTextBox.Location = new System.Drawing.Point(17, 236);
            this.TestAuthorTextBox.Name = "TestAuthorTextBox";
            this.TestAuthorTextBox.Size = new System.Drawing.Size(327, 22);
            this.TestAuthorTextBox.TabIndex = 9;
            this.TestAuthorTextBox.TextChanged += new System.EventHandler(this.TestAuthorTextBox_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1115, 561);
            this.Controls.Add(this.TestAuthorLabel);
            this.Controls.Add(this.TestAuthorTextBox);
            this.Controls.Add(this.TestNameLabel);
            this.Controls.Add(this.HeaderTestFormLabel);
            this.Controls.Add(this.SaveTestButton);
            this.Controls.Add(this.TestNameTextBox);
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
        private System.Windows.Forms.TextBox TestNameTextBox;
        private System.Windows.Forms.Button SaveTestButton;
        private System.Windows.Forms.Label HeaderTestFormLabel;
        private System.Windows.Forms.Label TestNameLabel;
        private System.Windows.Forms.Label TestAuthorLabel;
        private System.Windows.Forms.TextBox TestAuthorTextBox;
        private System.Windows.Forms.ToolStripMenuItem открытьИПройтиToolStripMenuItem;
    }
}

