namespace Clinica_privata_management
{
    partial class Date_Pacient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Date_Pacient));
            this.titilu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.t2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.masc = new System.Windows.Forms.RadioButton();
            this.fem = new System.Windows.Forms.RadioButton();
            this.t1 = new System.Windows.Forms.ComboBox();
            this.t3 = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.inapoi = new ePOSOne.btnProduct.Button_WOC();
            this.CC = new ePOSOne.btnProduct.Button_WOC();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // titilu
            // 
            this.titilu.AutoSize = true;
            this.titilu.BackColor = System.Drawing.Color.CadetBlue;
            this.titilu.Font = new System.Drawing.Font("MV Boli", 21.75F);
            this.titilu.Location = new System.Drawing.Point(260, 50);
            this.titilu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titilu.Name = "titilu";
            this.titilu.Size = new System.Drawing.Size(35, 49);
            this.titilu.TabIndex = 8;
            this.titilu.Text = ".";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(845, 764);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Numele si CNP sunt introdus automat";
            // 
            // t2
            // 
            this.t2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t2.Location = new System.Drawing.Point(609, 393);
            this.t2.Margin = new System.Windows.Forms.Padding(4);
            this.t2.Name = "t2";
            this.t2.Size = new System.Drawing.Size(144, 34);
            this.t2.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 294);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 45);
            this.label2.TabIndex = 14;
            this.label2.Text = "Varsta :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(291, 288);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 45);
            this.label3.TabIndex = 15;
            this.label3.Text = "Sex :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(243, 388);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(335, 45);
            this.label4.TabIndex = 16;
            this.label4.Text = "Numar de telefon :";
            // 
            // masc
            // 
            this.masc.AutoSize = true;
            this.masc.BackColor = System.Drawing.Color.Transparent;
            this.masc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masc.Location = new System.Drawing.Point(436, 294);
            this.masc.Margin = new System.Windows.Forms.Padding(4);
            this.masc.Name = "masc";
            this.masc.Size = new System.Drawing.Size(142, 35);
            this.masc.TabIndex = 19;
            this.masc.TabStop = true;
            this.masc.Text = "Masculin";
            this.masc.UseVisualStyleBackColor = false;
            this.masc.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // fem
            // 
            this.fem.AutoSize = true;
            this.fem.BackColor = System.Drawing.Color.Transparent;
            this.fem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fem.Location = new System.Drawing.Point(609, 294);
            this.fem.Margin = new System.Windows.Forms.Padding(4);
            this.fem.Name = "fem";
            this.fem.Size = new System.Drawing.Size(131, 35);
            this.fem.TabIndex = 20;
            this.fem.TabStop = true;
            this.fem.Text = "Feminin";
            this.fem.UseVisualStyleBackColor = false;
            this.fem.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // t1
            // 
            this.t1.DropDownHeight = 200;
            this.t1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t1.FormattingEnabled = true;
            this.t1.IntegralHeight = false;
            this.t1.Items.AddRange(new object[] {
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
            "100"});
            this.t1.Location = new System.Drawing.Point(65, 359);
            this.t1.Margin = new System.Windows.Forms.Padding(4);
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(81, 33);
            this.t1.TabIndex = 21;
            this.t1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // t3
            // 
            this.t3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t3.Location = new System.Drawing.Point(161, 546);
            this.t3.Margin = new System.Windows.Forms.Padding(4);
            this.t3.Name = "t3";
            this.t3.Size = new System.Drawing.Size(431, 146);
            this.t3.TabIndex = 22;
            this.t3.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(279, 470);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(209, 45);
            this.label6.TabIndex = 23;
            this.label6.Text = "Simptome :";
            // 
            // inapoi
            // 
            this.inapoi.BackColor = System.Drawing.Color.Transparent;
            this.inapoi.BorderColor = System.Drawing.Color.Transparent;
            this.inapoi.ButtonColor = System.Drawing.Color.Blue;
            this.inapoi.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(78)))), ((int)(((byte)(82)))));
            this.inapoi.FlatAppearance.BorderSize = 0;
            this.inapoi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.inapoi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.inapoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inapoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inapoi.Location = new System.Drawing.Point(35, 726);
            this.inapoi.Margin = new System.Windows.Forms.Padding(4);
            this.inapoi.Name = "inapoi";
            this.inapoi.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.inapoi.OnHoverButtonColor = System.Drawing.Color.MidnightBlue;
            this.inapoi.OnHoverTextColor = System.Drawing.Color.White;
            this.inapoi.Size = new System.Drawing.Size(112, 44);
            this.inapoi.TabIndex = 50;
            this.inapoi.Text = "Inapoi";
            this.inapoi.TextColor = System.Drawing.Color.White;
            this.inapoi.UseVisualStyleBackColor = false;
            this.inapoi.Click += new System.EventHandler(this.inapoi_Click);
            // 
            // CC
            // 
            this.CC.BackColor = System.Drawing.Color.Transparent;
            this.CC.BorderColor = System.Drawing.Color.Transparent;
            this.CC.ButtonColor = System.Drawing.Color.ForestGreen;
            this.CC.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(78)))), ((int)(((byte)(82)))));
            this.CC.FlatAppearance.BorderSize = 0;
            this.CC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.CC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.CC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CC.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CC.Location = new System.Drawing.Point(779, 670);
            this.CC.Margin = new System.Windows.Forms.Padding(4);
            this.CC.Name = "CC";
            this.CC.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.CC.OnHoverButtonColor = System.Drawing.Color.DarkGreen;
            this.CC.OnHoverTextColor = System.Drawing.Color.White;
            this.CC.Size = new System.Drawing.Size(404, 75);
            this.CC.TabIndex = 39;
            this.CC.Text = "Continuare programare";
            this.CC.TextColor = System.Drawing.Color.Black;
            this.CC.UseVisualStyleBackColor = false;
            this.CC.Click += new System.EventHandler(this.CC_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, -4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1273, 818);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // Date_Pacient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 815);
            this.Controls.Add(this.inapoi);
            this.Controls.Add(this.CC);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.t3);
            this.Controls.Add(this.t1);
            this.Controls.Add(this.fem);
            this.Controls.Add(this.masc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.t2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titilu);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Date_Pacient";
            this.Text = "Date_Pacient";
            this.Load += new System.EventHandler(this.Date_Pacient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label titilu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox t2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton masc;
        private System.Windows.Forms.RadioButton fem;
        private System.Windows.Forms.ComboBox t1;
        private System.Windows.Forms.RichTextBox t3;
        private System.Windows.Forms.Label label6;
        private ePOSOne.btnProduct.Button_WOC CC;
        private ePOSOne.btnProduct.Button_WOC inapoi;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}