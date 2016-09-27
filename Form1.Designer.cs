using System;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnExit = new System.Windows.Forms.Button();
            this.cmbBoxCurLvl = new System.Windows.Forms.ComboBox();
            this.lblLevelScoresNeeded = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnPaste = new System.Windows.Forms.Button();
            this.nudScoresCurrentScores = new System.Windows.Forms.NumericUpDown();
            this.lblScoresNeededPercent = new System.Windows.Forms.Label();
            this.lblScoresNeededScores = new System.Windows.Forms.Label();
            this.lblScoresCurrentLevel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudScoresCurrentScores)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.Control;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExit.Location = new System.Drawing.Point(229, 221);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(89, 35);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cmbBoxCurLvl
            // 
            this.cmbBoxCurLvl.FormattingEnabled = true;
            this.cmbBoxCurLvl.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "100",
            "101",
            "102",
            "103",
            "104",
            "105",
            "106",
            "107",
            "108",
            "109",
            "110",
            "111",
            "112",
            "113",
            "114",
            "115",
            "116",
            "117",
            "118",
            "119",
            "120",
            "121",
            "122",
            "123",
            "124",
            "125",
            "126",
            "127",
            "128",
            "129",
            "130"});
            this.cmbBoxCurLvl.Location = new System.Drawing.Point(229, 153);
            this.cmbBoxCurLvl.Name = "cmbBoxCurLvl";
            this.cmbBoxCurLvl.Size = new System.Drawing.Size(65, 21);
            this.cmbBoxCurLvl.TabIndex = 30;
            this.cmbBoxCurLvl.SelectedIndexChanged += new System.EventHandler(this.cmbBoxCurLvl_SelectedIndexChanged);
            // 
            // lblLevelScoresNeeded
            // 
            this.lblLevelScoresNeeded.AutoSize = true;
            this.lblLevelScoresNeeded.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLevelScoresNeeded.Location = new System.Drawing.Point(226, 188);
            this.lblLevelScoresNeeded.Name = "lblLevelScoresNeeded";
            this.lblLevelScoresNeeded.Size = new System.Drawing.Size(101, 13);
            this.lblLevelScoresNeeded.TabIndex = 29;
            this.lblLevelScoresNeeded.Text = "До следующего";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(207, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "До следующего уровня осталось:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(195, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Введите ваш текущий уровень:";
            // 
            // btnPaste
            // 
            this.btnPaste.Location = new System.Drawing.Point(375, 7);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(142, 23);
            this.btnPaste.TabIndex = 26;
            this.btnPaste.Text = "Вставить из буфера";
            this.btnPaste.UseVisualStyleBackColor = true;
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // nudScoresCurrentScores
            // 
            this.nudScoresCurrentScores.Location = new System.Drawing.Point(229, 7);
            this.nudScoresCurrentScores.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.nudScoresCurrentScores.Name = "nudScoresCurrentScores";
            this.nudScoresCurrentScores.Size = new System.Drawing.Size(140, 21);
            this.nudScoresCurrentScores.TabIndex = 25;
            this.nudScoresCurrentScores.ThousandsSeparator = true;
            this.nudScoresCurrentScores.ValueChanged += new System.EventHandler(this.nudScoresCurrentScores_ValueChanged);
            // 
            // lblScoresNeededPercent
            // 
            this.lblScoresNeededPercent.AutoSize = true;
            this.lblScoresNeededPercent.Location = new System.Drawing.Point(343, 188);
            this.lblScoresNeededPercent.Name = "lblScoresNeededPercent";
            this.lblScoresNeededPercent.Size = new System.Drawing.Size(0, 13);
            this.lblScoresNeededPercent.TabIndex = 24;
            // 
            // lblScoresNeededScores
            // 
            this.lblScoresNeededScores.AutoSize = true;
            this.lblScoresNeededScores.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblScoresNeededScores.Location = new System.Drawing.Point(226, 81);
            this.lblScoresNeededScores.Name = "lblScoresNeededScores";
            this.lblScoresNeededScores.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblScoresNeededScores.Size = new System.Drawing.Size(147, 13);
            this.lblScoresNeededScores.TabIndex = 23;
            this.lblScoresNeededScores.Text = "До следующего уровня";
            // 
            // lblScoresCurrentLevel
            // 
            this.lblScoresCurrentLevel.AutoSize = true;
            this.lblScoresCurrentLevel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblScoresCurrentLevel.Location = new System.Drawing.Point(226, 53);
            this.lblScoresCurrentLevel.Name = "lblScoresCurrentLevel";
            this.lblScoresCurrentLevel.Size = new System.Drawing.Size(111, 13);
            this.lblScoresCurrentLevel.TabIndex = 22;
            this.lblScoresCurrentLevel.Text = "Текущий уровень";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Ваш уровень:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "До следующего уровня осталось:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 26);
            this.label1.TabIndex = 19;
            this.label1.Text = "Введите количество ваших очков \r\nи нажмите клавишу \"Enter\":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Или";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(528, 268);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbBoxCurLvl);
            this.Controls.Add(this.lblLevelScoresNeeded);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnPaste);
            this.Controls.Add(this.nudScoresCurrentScores);
            this.Controls.Add(this.lblScoresNeededPercent);
            this.Controls.Add(this.lblScoresNeededScores);
            this.Controls.Add(this.lblScoresCurrentLevel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Калькулятор osu!";
            ((System.ComponentModel.ISupportInitialize)(this.nudScoresCurrentScores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox cmbBoxCurLvl;
        private System.Windows.Forms.Label lblLevelScoresNeeded;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnPaste;
        private System.Windows.Forms.NumericUpDown nudScoresCurrentScores;
        private System.Windows.Forms.Label lblScoresNeededPercent;
        private System.Windows.Forms.Label lblScoresNeededScores;
        private System.Windows.Forms.Label lblScoresCurrentLevel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private EventHandler MainForm_Load;
    }
}

