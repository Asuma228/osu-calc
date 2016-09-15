namespace osu_calc
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabpgScores = new System.Windows.Forms.TabPage();
            this.btnPaste = new System.Windows.Forms.Button();
            this.nudScoresCurrentScores = new System.Windows.Forms.NumericUpDown();
            this.lblScoresNeededPercent = new System.Windows.Forms.Label();
            this.lblScoresNeededScores = new System.Windows.Forms.Label();
            this.lblScoresCurrentLevel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabpgLevel = new System.Windows.Forms.TabPage();
            this.lblLevelPercentNeeded = new System.Windows.Forms.Label();
            this.lblLevelScoresNeeded = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtboxLevelCurrentLevel = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabpgScores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudScoresCurrentScores)).BeginInit();
            this.tabpgLevel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabpgScores);
            this.tabControl.Controls.Add(this.tabpgLevel);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl.ItemSize = new System.Drawing.Size(45, 21);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.Padding = new System.Drawing.Point(129, 3);
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(754, 203);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl.TabIndex = 0;
            // 
            // tabpgScores
            // 
            this.tabpgScores.Controls.Add(this.btnPaste);
            this.tabpgScores.Controls.Add(this.nudScoresCurrentScores);
            this.tabpgScores.Controls.Add(this.lblScoresNeededPercent);
            this.tabpgScores.Controls.Add(this.lblScoresNeededScores);
            this.tabpgScores.Controls.Add(this.lblScoresCurrentLevel);
            this.tabpgScores.Controls.Add(this.label5);
            this.tabpgScores.Controls.Add(this.label2);
            this.tabpgScores.Controls.Add(this.label1);
            this.tabpgScores.Location = new System.Drawing.Point(4, 25);
            this.tabpgScores.Name = "tabpgScores";
            this.tabpgScores.Padding = new System.Windows.Forms.Padding(3);
            this.tabpgScores.Size = new System.Drawing.Size(746, 174);
            this.tabpgScores.TabIndex = 0;
            this.tabpgScores.Text = "Scores";
            this.tabpgScores.UseVisualStyleBackColor = true;
            // 
            // btnPaste
            // 
            this.btnPaste.Location = new System.Drawing.Point(485, 24);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(122, 23);
            this.btnPaste.TabIndex = 9;
            this.btnPaste.Text = "Вставить из буфера";
            this.btnPaste.UseVisualStyleBackColor = true;
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // nudScoresCurrentScores
            // 
            this.nudScoresCurrentScores.Location = new System.Drawing.Point(358, 24);
            this.nudScoresCurrentScores.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.nudScoresCurrentScores.Name = "nudScoresCurrentScores";
            this.nudScoresCurrentScores.Size = new System.Drawing.Size(120, 20);
            this.nudScoresCurrentScores.TabIndex = 8;
            this.nudScoresCurrentScores.ThousandsSeparator = true;
            this.nudScoresCurrentScores.ValueChanged += new System.EventHandler(this.nudScoresCurrentScores_ValueChanged);
            // 
            // lblScoresNeededPercent
            // 
            this.lblScoresNeededPercent.AutoSize = true;
            this.lblScoresNeededPercent.Location = new System.Drawing.Point(277, 156);
            this.lblScoresNeededPercent.Name = "lblScoresNeededPercent";
            this.lblScoresNeededPercent.Size = new System.Drawing.Size(0, 13);
            this.lblScoresNeededPercent.TabIndex = 6;
            // 
            // lblScoresNeededScores
            // 
            this.lblScoresNeededScores.AutoSize = true;
            this.lblScoresNeededScores.Location = new System.Drawing.Point(355, 110);
            this.lblScoresNeededScores.Name = "lblScoresNeededScores";
            this.lblScoresNeededScores.Size = new System.Drawing.Size(0, 13);
            this.lblScoresNeededScores.TabIndex = 5;
            // 
            // lblScoresCurrentLevel
            // 
            this.lblScoresCurrentLevel.AutoSize = true;
            this.lblScoresCurrentLevel.Location = new System.Drawing.Point(355, 60);
            this.lblScoresCurrentLevel.Name = "lblScoresCurrentLevel";
            this.lblScoresCurrentLevel.Size = new System.Drawing.Size(0, 13);
            this.lblScoresCurrentLevel.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ваш уровень:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "До следующего уровня осталось:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите количество ваших очков и нажмите клавишу \"Enter\":";
            // 
            // tabpgLevel
            // 
            this.tabpgLevel.Controls.Add(this.lblLevelPercentNeeded);
            this.tabpgLevel.Controls.Add(this.lblLevelScoresNeeded);
            this.tabpgLevel.Controls.Add(this.label8);
            this.tabpgLevel.Controls.Add(this.txtboxLevelCurrentLevel);
            this.tabpgLevel.Controls.Add(this.label9);
            this.tabpgLevel.Location = new System.Drawing.Point(4, 25);
            this.tabpgLevel.Name = "tabpgLevel";
            this.tabpgLevel.Padding = new System.Windows.Forms.Padding(3);
            this.tabpgLevel.Size = new System.Drawing.Size(746, 222);
            this.tabpgLevel.TabIndex = 1;
            this.tabpgLevel.Text = "Level";
            this.tabpgLevel.UseVisualStyleBackColor = true;
            // 
            // lblLevelPercentNeeded
            // 
            this.lblLevelPercentNeeded.AutoSize = true;
            this.lblLevelPercentNeeded.Location = new System.Drawing.Point(207, 149);
            this.lblLevelPercentNeeded.Name = "lblLevelPercentNeeded";
            this.lblLevelPercentNeeded.Size = new System.Drawing.Size(0, 13);
            this.lblLevelPercentNeeded.TabIndex = 13;
            // 
            // lblLevelScoresNeeded
            // 
            this.lblLevelScoresNeeded.AutoSize = true;
            this.lblLevelScoresNeeded.Location = new System.Drawing.Point(204, 111);
            this.lblLevelScoresNeeded.Name = "lblLevelScoresNeeded";
            this.lblLevelScoresNeeded.Size = new System.Drawing.Size(0, 13);
            this.lblLevelScoresNeeded.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(179, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "До следующего уровня осталось:";
            // 
            // txtboxLevelCurrentLevel
            // 
            this.txtboxLevelCurrentLevel.Location = new System.Drawing.Point(210, 33);
            this.txtboxLevelCurrentLevel.Name = "txtboxLevelCurrentLevel";
            this.txtboxLevelCurrentLevel.Size = new System.Drawing.Size(358, 20);
            this.txtboxLevelCurrentLevel.TabIndex = 8;
            this.txtboxLevelCurrentLevel.WordWrap = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(165, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Введите ваш текущий уровень:";
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.Location = new System.Drawing.Point(0, 205);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(754, 46);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 251);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.tabControl);
            this.Name = "MainForm";
            this.Text = "Калькулятор osu!";
            this.tabControl.ResumeLayout(false);
            this.tabpgScores.ResumeLayout(false);
            this.tabpgScores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudScoresCurrentScores)).EndInit();
            this.tabpgLevel.ResumeLayout(false);
            this.tabpgLevel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabpgScores;
        private System.Windows.Forms.TabPage tabpgLevel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblScoresNeededPercent;
        private System.Windows.Forms.Label lblScoresNeededScores;
        private System.Windows.Forms.Label lblScoresCurrentLevel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblLevelPercentNeeded;
        private System.Windows.Forms.Label lblLevelScoresNeeded;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtboxLevelCurrentLevel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nudScoresCurrentScores;
        private System.Windows.Forms.Button btnPaste;
        private System.Windows.Forms.Button btnExit;
    }
}

