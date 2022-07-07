namespace Clinica_privata_management
{
    partial class Logare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Logare));
            this.nume0 = new System.Windows.Forms.TextBox();
            this.parola = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.arata = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.titlu = new System.Windows.Forms.Label();
            this.fundal = new System.Windows.Forms.PictureBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.inregistrare_operator = new ePOSOne.btnProduct.Button_WOC();
            this.buton_logare = new ePOSOne.btnProduct.Button_WOC();
            this.buton_inregistrare_doctori = new ePOSOne.btnProduct.Button_WOC();
            this.buton_inregistrare_pacienti = new ePOSOne.btnProduct.Button_WOC();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fundal)).BeginInit();
            this.SuspendLayout();
            // 
            // nume0
            // 
            this.nume0.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nume0.Location = new System.Drawing.Point(399, 259);
            this.nume0.Name = "nume0";
            this.nume0.Size = new System.Drawing.Size(425, 38);
            this.nume0.TabIndex = 0;
            // 
            // parola
            // 
            this.parola.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parola.Location = new System.Drawing.Point(399, 365);
            this.parola.Name = "parola";
            this.parola.Size = new System.Drawing.Size(425, 38);
            this.parola.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(270, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 43);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nume :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(270, 364);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 43);
            this.label2.TabIndex = 3;
            this.label2.Text = "Parola :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.Red;
            this.checkBox1.Location = new System.Drawing.Point(704, 499);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(151, 29);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Esti doctor ?";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // arata
            // 
            this.arata.AutoSize = true;
            this.arata.BackColor = System.Drawing.Color.Transparent;
            this.arata.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arata.ForeColor = System.Drawing.Color.Navy;
            this.arata.Location = new System.Drawing.Point(527, 429);
            this.arata.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.arata.Name = "arata";
            this.arata.Size = new System.Drawing.Size(180, 35);
            this.arata.TabIndex = 7;
            this.arata.Text = "Arata parola";
            this.arata.UseVisualStyleBackColor = false;
            this.arata.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(539, 128);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // titlu
            // 
            this.titlu.BackColor = System.Drawing.Color.Transparent;
            this.titlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlu.ForeColor = System.Drawing.Color.Black;
            this.titlu.Location = new System.Drawing.Point(479, 6);
            this.titlu.Name = "titlu";
            this.titlu.Size = new System.Drawing.Size(322, 119);
            this.titlu.TabIndex = 9;
            this.titlu.Text = "Pagina de logare";
            this.titlu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fundal
            // 
            this.fundal.Image = ((System.Drawing.Image)(resources.GetObject("fundal.Image")));
            this.fundal.Location = new System.Drawing.Point(-30, -6);
            this.fundal.Name = "fundal";
            this.fundal.Size = new System.Drawing.Size(1253, 705);
            this.fundal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fundal.TabIndex = 24;
            this.fundal.TabStop = false;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.BackColor = System.Drawing.Color.Transparent;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.ForeColor = System.Drawing.Color.Purple;
            this.checkBox2.Location = new System.Drawing.Point(442, 499);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(181, 29);
            this.checkBox2.TabIndex = 26;
            this.checkBox2.Text = "Esti secretara ?";
            this.checkBox2.UseVisualStyleBackColor = false;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged_1);
            // 
            // inregistrare_operator
            // 
            this.inregistrare_operator.BackColor = System.Drawing.Color.Transparent;
            this.inregistrare_operator.BorderColor = System.Drawing.Color.Transparent;
            this.inregistrare_operator.ButtonColor = System.Drawing.Color.MediumPurple;
            this.inregistrare_operator.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(78)))), ((int)(((byte)(82)))));
            this.inregistrare_operator.FlatAppearance.BorderSize = 0;
            this.inregistrare_operator.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.inregistrare_operator.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.inregistrare_operator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inregistrare_operator.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inregistrare_operator.Location = new System.Drawing.Point(358, 580);
            this.inregistrare_operator.Name = "inregistrare_operator";
            this.inregistrare_operator.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.inregistrare_operator.OnHoverButtonColor = System.Drawing.Color.Purple;
            this.inregistrare_operator.OnHoverTextColor = System.Drawing.Color.White;
            this.inregistrare_operator.Size = new System.Drawing.Size(199, 52);
            this.inregistrare_operator.TabIndex = 25;
            this.inregistrare_operator.Text = "Inregistrare clinica";
            this.inregistrare_operator.TextColor = System.Drawing.Color.Black;
            this.inregistrare_operator.UseVisualStyleBackColor = false;
            this.inregistrare_operator.Click += new System.EventHandler(this.inregistrare_operator_Click);
            // 
            // buton_logare
            // 
            this.buton_logare.BackColor = System.Drawing.Color.Transparent;
            this.buton_logare.BorderColor = System.Drawing.Color.Transparent;
            this.buton_logare.ButtonColor = System.Drawing.Color.DeepSkyBlue;
            this.buton_logare.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(78)))), ((int)(((byte)(82)))));
            this.buton_logare.FlatAppearance.BorderSize = 0;
            this.buton_logare.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buton_logare.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buton_logare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buton_logare.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buton_logare.ForeColor = System.Drawing.Color.Black;
            this.buton_logare.Location = new System.Drawing.Point(977, 585);
            this.buton_logare.Name = "buton_logare";
            this.buton_logare.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.buton_logare.OnHoverButtonColor = System.Drawing.Color.DodgerBlue;
            this.buton_logare.OnHoverTextColor = System.Drawing.Color.White;
            this.buton_logare.Size = new System.Drawing.Size(179, 43);
            this.buton_logare.TabIndex = 23;
            this.buton_logare.Text = "Logare";
            this.buton_logare.TextColor = System.Drawing.Color.Black;
            this.buton_logare.UseVisualStyleBackColor = false;
            this.buton_logare.Click += new System.EventHandler(this.buton_logare_Click_1);
            // 
            // buton_inregistrare_doctori
            // 
            this.buton_inregistrare_doctori.BackColor = System.Drawing.Color.Transparent;
            this.buton_inregistrare_doctori.BorderColor = System.Drawing.Color.Transparent;
            this.buton_inregistrare_doctori.ButtonColor = System.Drawing.Color.Red;
            this.buton_inregistrare_doctori.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(78)))), ((int)(((byte)(82)))));
            this.buton_inregistrare_doctori.FlatAppearance.BorderSize = 0;
            this.buton_inregistrare_doctori.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buton_inregistrare_doctori.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buton_inregistrare_doctori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buton_inregistrare_doctori.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buton_inregistrare_doctori.Location = new System.Drawing.Point(685, 579);
            this.buton_inregistrare_doctori.Name = "buton_inregistrare_doctori";
            this.buton_inregistrare_doctori.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.buton_inregistrare_doctori.OnHoverButtonColor = System.Drawing.Color.DarkRed;
            this.buton_inregistrare_doctori.OnHoverTextColor = System.Drawing.Color.White;
            this.buton_inregistrare_doctori.Size = new System.Drawing.Size(199, 52);
            this.buton_inregistrare_doctori.TabIndex = 22;
            this.buton_inregistrare_doctori.Text = "Inregistrare medici";
            this.buton_inregistrare_doctori.TextColor = System.Drawing.Color.Black;
            this.buton_inregistrare_doctori.UseVisualStyleBackColor = false;
            this.buton_inregistrare_doctori.Click += new System.EventHandler(this.buton_inregistrare_doctori_Click_1);
            // 
            // buton_inregistrare_pacienti
            // 
            this.buton_inregistrare_pacienti.BackColor = System.Drawing.Color.Transparent;
            this.buton_inregistrare_pacienti.BorderColor = System.Drawing.Color.Transparent;
            this.buton_inregistrare_pacienti.ButtonColor = System.Drawing.Color.LightGreen;
            this.buton_inregistrare_pacienti.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(78)))), ((int)(((byte)(82)))));
            this.buton_inregistrare_pacienti.FlatAppearance.BorderSize = 0;
            this.buton_inregistrare_pacienti.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buton_inregistrare_pacienti.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buton_inregistrare_pacienti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buton_inregistrare_pacienti.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buton_inregistrare_pacienti.Location = new System.Drawing.Point(63, 578);
            this.buton_inregistrare_pacienti.Name = "buton_inregistrare_pacienti";
            this.buton_inregistrare_pacienti.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.buton_inregistrare_pacienti.OnHoverButtonColor = System.Drawing.Color.ForestGreen;
            this.buton_inregistrare_pacienti.OnHoverTextColor = System.Drawing.Color.White;
            this.buton_inregistrare_pacienti.Size = new System.Drawing.Size(207, 56);
            this.buton_inregistrare_pacienti.TabIndex = 21;
            this.buton_inregistrare_pacienti.Text = "Inregistrare pacienti";
            this.buton_inregistrare_pacienti.TextColor = System.Drawing.Color.Black;
            this.buton_inregistrare_pacienti.UseVisualStyleBackColor = false;
            this.buton_inregistrare_pacienti.Click += new System.EventHandler(this.buton_inregistrare_pacienti_Click);
            // 
            // Logare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1200, 671);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.inregistrare_operator);
            this.Controls.Add(this.buton_logare);
            this.Controls.Add(this.buton_inregistrare_doctori);
            this.Controls.Add(this.buton_inregistrare_pacienti);
            this.Controls.Add(this.titlu);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.arata);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.parola);
            this.Controls.Add(this.nume0);
            this.Controls.Add(this.fundal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Logare";
            this.Load += new System.EventHandler(this.Logare_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fundal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nume0;
        private System.Windows.Forms.TextBox parola;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox arata;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label titlu;
        private ePOSOne.btnProduct.Button_WOC buton_inregistrare_pacienti;
        private ePOSOne.btnProduct.Button_WOC buton_inregistrare_doctori;
        private ePOSOne.btnProduct.Button_WOC buton_logare;
        private System.Windows.Forms.PictureBox fundal;
        private ePOSOne.btnProduct.Button_WOC inregistrare_operator;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}