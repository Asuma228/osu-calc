﻿namespace osu_calc
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
            this.tabpgLevel = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxScoresCurrentScores = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblScoresCurrentScores = new System.Windows.Forms.Label();
            this.lblScoresNeededScores = new System.Windows.Forms.Label();
            this.lblScoresNeededPercent = new System.Windows.Forms.Label();
            this.lblLevelPercentNeeded = new System.Windows.Forms.Label();
            this.lblLevelScoresNeeded = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtboxLevelCurrentLevel = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabpgScores.SuspendLayout();
            this.tabpgLevel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabpgScores);
            this.tabControl.Controls.Add(this.tabpgLevel);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.ItemSize = new System.Drawing.Size(45, 21);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.Padding = new System.Drawing.Point(129, 3);
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(584, 226);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 0;
            // 
            // tabpgScores
            // 
            this.tabpgScores.Controls.Add(this.lblScoresNeededPercent);
            this.tabpgScores.Controls.Add(this.lblScoresNeededScores);
            this.tabpgScores.Controls.Add(this.lblScoresCurrentScores);
            this.tabpgScores.Controls.Add(this.label5);
            this.tabpgScores.Controls.Add(this.label2);
            this.tabpgScores.Controls.Add(this.txtboxScoresCurrentScores);
            this.tabpgScores.Controls.Add(this.label1);
            this.tabpgScores.Location = new System.Drawing.Point(4, 25);
            this.tabpgScores.Name = "tabpgScores";
            this.tabpgScores.Padding = new System.Windows.Forms.Padding(3);
            this.tabpgScores.Size = new System.Drawing.Size(576, 197);
            this.tabpgScores.TabIndex = 0;
            this.tabpgScores.Text = "Scores";
            this.tabpgScores.UseVisualStyleBackColor = true;
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
            this.tabpgLevel.Size = new System.Drawing.Size(576, 197);
            this.tabpgLevel.TabIndex = 1;
            this.tabpgLevel.Text = "Level";
            this.tabpgLevel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите количество ваших очков:";
            // 
            // txtboxScoresCurrentScores
            // 
            this.txtboxScoresCurrentScores.Location = new System.Drawing.Point(210, 30);
            this.txtboxScoresCurrentScores.Name = "txtboxScoresCurrentScores";
            this.txtboxScoresCurrentScores.Size = new System.Drawing.Size(358, 20);
            this.txtboxScoresCurrentScores.TabIndex = 1;
            this.txtboxScoresCurrentScores.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "До следующего уровня осталось:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ваш уровень:";
            // 
            // lblScoresCurrentScores
            // 
            this.lblScoresCurrentScores.AutoSize = true;
            this.lblScoresCurrentScores.Location = new System.Drawing.Point(207, 75);
            this.lblScoresCurrentScores.Name = "lblScoresCurrentScores";
            this.lblScoresCurrentScores.Size = new System.Drawing.Size(0, 13);
            this.lblScoresCurrentScores.TabIndex = 4;
            // 
            // lblScoresNeededScores
            // 
            this.lblScoresNeededScores.AutoSize = true;
            this.lblScoresNeededScores.Location = new System.Drawing.Point(207, 109);
            this.lblScoresNeededScores.Name = "lblScoresNeededScores";
            this.lblScoresNeededScores.Size = new System.Drawing.Size(0, 13);
            this.lblScoresNeededScores.TabIndex = 5;
            // 
            // lblScoresNeededPercent
            // 
            this.lblScoresNeededPercent.AutoSize = true;
            this.lblScoresNeededPercent.Location = new System.Drawing.Point(210, 147);
            this.lblScoresNeededPercent.Name = "lblScoresNeededPercent";
            this.lblScoresNeededPercent.Size = new System.Drawing.Size(0, 13);
            this.lblScoresNeededPercent.TabIndex = 6;
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 226);
            this.Controls.Add(this.tabControl);
            this.Name = "MainForm";
            this.Text = "Калькулятор osu!";
            this.tabControl.ResumeLayout(false);
            this.tabpgScores.ResumeLayout(false);
            this.tabpgScores.PerformLayout();
            this.tabpgLevel.ResumeLayout(false);
            this.tabpgLevel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabpgScores;
        private System.Windows.Forms.TabPage tabpgLevel;
        private System.Windows.Forms.TextBox txtboxScoresCurrentScores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblScoresNeededPercent;
        private System.Windows.Forms.Label lblScoresNeededScores;
        private System.Windows.Forms.Label lblScoresCurrentScores;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblLevelPercentNeeded;
        private System.Windows.Forms.Label lblLevelScoresNeeded;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtboxLevelCurrentLevel;
        private System.Windows.Forms.Label label9;
    }
}

