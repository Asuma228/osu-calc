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
            this.lblScoresNeededPercent = new System.Windows.Forms.Label();
            this.lblScoresNeededScores = new System.Windows.Forms.Label();
            this.lblScoresCurrentLevel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxScoresCurrentScores = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = global::osu_calc.Properties.Resources.exit_passive;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.Transparent;
            this.btnExit.Location = new System.Drawing.Point(355, 248);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 40);
            this.btnExit.TabIndex = 1;
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
            this.cmbBoxCurLvl.Location = new System.Drawing.Point(280, 160);
            this.cmbBoxCurLvl.Name = "cmbBoxCurLvl";
            this.cmbBoxCurLvl.Size = new System.Drawing.Size(65, 21);
            this.cmbBoxCurLvl.TabIndex = 30;
            this.cmbBoxCurLvl.SelectedIndexChanged += new System.EventHandler(this.cmbBoxCurLvl_SelectedIndexChanged);
            // 
            // lblLevelScoresNeeded
            // 
            this.lblLevelScoresNeeded.AutoSize = true;
            this.lblLevelScoresNeeded.BackColor = System.Drawing.Color.Transparent;
            this.lblLevelScoresNeeded.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLevelScoresNeeded.ForeColor = System.Drawing.Color.Black;
            this.lblLevelScoresNeeded.Location = new System.Drawing.Point(277, 188);
            this.lblLevelScoresNeeded.Name = "lblLevelScoresNeeded";
            this.lblLevelScoresNeeded.Size = new System.Drawing.Size(121, 16);
            this.lblLevelScoresNeeded.TabIndex = 29;
            this.lblLevelScoresNeeded.Text = "До следующего";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(12, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(254, 16);
            this.label8.TabIndex = 28;
            this.label8.Text = "До следующего уровня осталось:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(12, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(239, 16);
            this.label9.TabIndex = 27;
            this.label9.Text = "Введите ваш текущий уровень:";
            // 
            // btnPaste
            // 
            this.btnPaste.Location = new System.Drawing.Point(426, 7);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(142, 23);
            this.btnPaste.TabIndex = 26;
            this.btnPaste.Text = "Вставить из буфера";
            this.btnPaste.UseVisualStyleBackColor = true;
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // lblScoresNeededPercent
            // 
            this.lblScoresNeededPercent.AutoSize = true;
            this.lblScoresNeededPercent.BackColor = System.Drawing.Color.Transparent;
            this.lblScoresNeededPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblScoresNeededPercent.ForeColor = System.Drawing.Color.Black;
            this.lblScoresNeededPercent.Location = new System.Drawing.Point(404, 188);
            this.lblScoresNeededPercent.Name = "lblScoresNeededPercent";
            this.lblScoresNeededPercent.Size = new System.Drawing.Size(0, 16);
            this.lblScoresNeededPercent.TabIndex = 24;
            // 
            // lblScoresNeededScores
            // 
            this.lblScoresNeededScores.AutoSize = true;
            this.lblScoresNeededScores.BackColor = System.Drawing.Color.Transparent;
            this.lblScoresNeededScores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblScoresNeededScores.ForeColor = System.Drawing.Color.Black;
            this.lblScoresNeededScores.Location = new System.Drawing.Point(277, 81);
            this.lblScoresNeededScores.Name = "lblScoresNeededScores";
            this.lblScoresNeededScores.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblScoresNeededScores.Size = new System.Drawing.Size(178, 16);
            this.lblScoresNeededScores.TabIndex = 23;
            this.lblScoresNeededScores.Text = "До следующего уровня";
            // 
            // lblScoresCurrentLevel
            // 
            this.lblScoresCurrentLevel.AutoSize = true;
            this.lblScoresCurrentLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblScoresCurrentLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblScoresCurrentLevel.ForeColor = System.Drawing.Color.Black;
            this.lblScoresCurrentLevel.Location = new System.Drawing.Point(277, 53);
            this.lblScoresCurrentLevel.Name = "lblScoresCurrentLevel";
            this.lblScoresCurrentLevel.Size = new System.Drawing.Size(138, 16);
            this.lblScoresCurrentLevel.TabIndex = 22;
            this.lblScoresCurrentLevel.Text = "Текущий уровень";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(12, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Ваш уровень:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "До следующего уровня осталось:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 32);
            this.label1.TabIndex = 19;
            this.label1.Text = "Введите количество ваших очков \r\nи нажмите клавишу \"Enter\":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 31;
            this.label3.Text = "Или";
            // 
            // txtBoxScoresCurrentScores
            // 
            this.txtBoxScoresCurrentScores.Location = new System.Drawing.Point(280, 7);
            this.txtBoxScoresCurrentScores.Name = "txtBoxScoresCurrentScores";
            this.txtBoxScoresCurrentScores.Size = new System.Drawing.Size(135, 21);
            this.txtBoxScoresCurrentScores.TabIndex = 32;
            this.txtBoxScoresCurrentScores.TextChanged += new System.EventHandler(this.txtBoxScoresCurrentScores_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::osu_calc.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(755, 300);
            this.Controls.Add(this.txtBoxScoresCurrentScores);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbBoxCurLvl);
            this.Controls.Add(this.lblLevelScoresNeeded);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnPaste);
            this.Controls.Add(this.lblScoresNeededPercent);
            this.Controls.Add(this.lblScoresNeededScores);
            this.Controls.Add(this.lblScoresCurrentLevel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Калькулятор osu!";
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
        private System.Windows.Forms.Label lblScoresNeededPercent;
        private System.Windows.Forms.Label lblScoresNeededScores;
        private System.Windows.Forms.Label lblScoresCurrentLevel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private EventHandler MainForm_Load;
        private System.Windows.Forms.TextBox txtBoxScoresCurrentScores;
    }
}

