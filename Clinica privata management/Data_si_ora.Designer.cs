namespace Clinica_privata_management
{
    partial class Data_si_ora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Data_si_ora));
            this.calendar = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.ora_programare = new System.Windows.Forms.ComboBox();
            this.fundal = new System.Windows.Forms.PictureBox();
            this.inapoi = new ePOSOne.btnProduct.Button_WOC();
            this.Afisare_ora_programare = new ePOSOne.btnProduct.Button_WOC();
            this.CC = new ePOSOne.btnProduct.Button_WOC();
            ((System.ComponentModel.ISupportInitialize)(this.fundal)).BeginInit();
            this.SuspendLayout();
            // 
            // calendar
            // 
            this.calendar.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendar.Location = new System.Drawing.Point(443, 158);
            this.calendar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.calendar.Name = "calendar";
            this.calendar.Size = new System.Drawing.Size(440, 37);
            this.calendar.TabIndex = 47;
            this.calendar.Value = new System.DateTime(2022, 6, 1, 19, 51, 0, 0);
            this.calendar.ValueChanged += new System.EventHandler(this.calendar_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.CadetBlue;
            this.label5.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(384, 50);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(564, 49);
            this.label5.TabIndex = 45;
            this.label5.Text = "Alegere data si ora programarii";
            // 
            // ora_programare
            // 
            this.ora_programare.DropDownHeight = 180;
            this.ora_programare.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ora_programare.FormattingEnabled = true;
            this.ora_programare.IntegralHeight = false;
            this.ora_programare.ItemHeight = 30;
            this.ora_programare.Location = new System.Drawing.Point(544, 366);
            this.ora_programare.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ora_programare.Name = "ora_programare";
            this.ora_programare.Size = new System.Drawing.Size(138, 38);
            this.ora_programare.TabIndex = 49;
            // 
            // fundal
            // 
            this.fundal.Image = ((System.Drawing.Image)(resources.GetObject("fundal.Image")));
            this.fundal.Location = new System.Drawing.Point(-3, -5);
            this.fundal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fundal.Name = "fundal";
            this.fundal.Size = new System.Drawing.Size(1273, 819);
            this.fundal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fundal.TabIndex = 52;
            this.fundal.TabStop = false;
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
            this.inapoi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inapoi.Name = "inapoi";
            this.inapoi.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.inapoi.OnHoverButtonColor = System.Drawing.Color.MidnightBlue;
            this.inapoi.OnHoverTextColor = System.Drawing.Color.White;
            this.inapoi.Size = new System.Drawing.Size(112, 44);
            this.inapoi.TabIndex = 53;
            this.inapoi.Text = "Inapoi";
            this.inapoi.TextColor = System.Drawing.Color.White;
            this.inapoi.UseVisualStyleBackColor = false;
            this.inapoi.Click += new System.EventHandler(this.inapoi_Click);
            // 
            // Afisare_ora_programare
            // 
            this.Afisare_ora_programare.BackColor = System.Drawing.Color.Transparent;
            this.Afisare_ora_programare.BorderColor = System.Drawing.Color.Transparent;
            this.Afisare_ora_programare.ButtonColor = System.Drawing.Color.DodgerBlue;
            this.Afisare_ora_programare.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(78)))), ((int)(((byte)(82)))));
            this.Afisare_ora_programare.FlatAppearance.BorderSize = 0;
            this.Afisare_ora_programare.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Afisare_ora_programare.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Afisare_ora_programare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Afisare_ora_programare.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Afisare_ora_programare.Location = new System.Drawing.Point(177, 347);
            this.Afisare_ora_programare.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Afisare_ora_programare.Name = "Afisare_ora_programare";
            this.Afisare_ora_programare.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.Afisare_ora_programare.OnHoverButtonColor = System.Drawing.Color.Blue;
            this.Afisare_ora_programare.OnHoverTextColor = System.Drawing.Color.White;
            this.Afisare_ora_programare.Size = new System.Drawing.Size(220, 75);
            this.Afisare_ora_programare.TabIndex = 50;
            this.Afisare_ora_programare.Text = "Ora programare";
            this.Afisare_ora_programare.TextColor = System.Drawing.Color.Black;
            this.Afisare_ora_programare.UseVisualStyleBackColor = false;
            this.Afisare_ora_programare.Click += new System.EventHandler(this.Afisare_ora_programare_Click);
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
            this.CC.Location = new System.Drawing.Point(513, 668);
            this.CC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CC.Name = "CC";
            this.CC.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.CC.OnHoverButtonColor = System.Drawing.Color.DarkGreen;
            this.CC.OnHoverTextColor = System.Drawing.Color.White;
            this.CC.Size = new System.Drawing.Size(343, 75);
            this.CC.TabIndex = 46;
            this.CC.Text = "Creaza programare";
            this.CC.TextColor = System.Drawing.Color.Black;
            this.CC.UseVisualStyleBackColor = false;
            this.CC.Click += new System.EventHandler(this.CC_Click);
            // 
            // Data_si_ora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 815);
            this.Controls.Add(this.inapoi);
            this.Controls.Add(this.Afisare_ora_programare);
            this.Controls.Add(this.ora_programare);
            this.Controls.Add(this.calendar);
            this.Controls.Add(this.CC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fundal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Data_si_ora";
            this.Text = "Data_si_ora";
            this.Load += new System.EventHandler(this.Data_si_ora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fundal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker calendar;
        private ePOSOne.btnProduct.Button_WOC CC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ora_programare;
        private ePOSOne.btnProduct.Button_WOC Afisare_ora_programare;
        private System.Windows.Forms.PictureBox fundal;
        private ePOSOne.btnProduct.Button_WOC inapoi;
    }
}