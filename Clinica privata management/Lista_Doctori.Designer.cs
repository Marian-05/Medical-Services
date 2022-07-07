namespace Clinica_privata_management
{
    partial class Lista_Doctori
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lista_Doctori));
            this.tabel_doctorii = new System.Windows.Forms.DataGridView();
            this.Nume_Doctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Specializare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titlu = new System.Windows.Forms.Label();
            this.inapoi = new ePOSOne.btnProduct.Button_WOC();
            this.inregistrare_manuala_pacienti = new ePOSOne.btnProduct.Button_WOC();
            this.fundal = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tabel_doctorii)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fundal)).BeginInit();
            this.SuspendLayout();
            // 
            // tabel_doctorii
            // 
            this.tabel_doctorii.BackgroundColor = System.Drawing.Color.White;
            this.tabel_doctorii.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Comic Sans MS", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabel_doctorii.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.tabel_doctorii.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabel_doctorii.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nume_Doctor,
            this.Specializare});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tabel_doctorii.DefaultCellStyle = dataGridViewCellStyle14;
            this.tabel_doctorii.Location = new System.Drawing.Point(45, 119);
            this.tabel_doctorii.Name = "tabel_doctorii";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabel_doctorii.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.tabel_doctorii.RowHeadersWidth = 30;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabel_doctorii.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.tabel_doctorii.RowTemplate.Height = 30;
            this.tabel_doctorii.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabel_doctorii.Size = new System.Drawing.Size(491, 168);
            this.tabel_doctorii.TabIndex = 2;
           
            this.tabel_doctorii.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabel_doctorii_CellContentDoubleClick);
            // 
            // Nume_Doctor
            // 
            this.Nume_Doctor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nume_Doctor.HeaderText = "Nume Medic";
            this.Nume_Doctor.MinimumWidth = 6;
            this.Nume_Doctor.Name = "Nume_Doctor";
            // 
            // Specializare
            // 
            this.Specializare.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Specializare.HeaderText = "Specializare";
            this.Specializare.MinimumWidth = 6;
            this.Specializare.Name = "Specializare";
            // 
            // titlu
            // 
            this.titlu.AutoSize = true;
            this.titlu.BackColor = System.Drawing.Color.CadetBlue;
            this.titlu.Font = new System.Drawing.Font("MV Boli", 21.75F);
            this.titlu.Location = new System.Drawing.Point(148, 37);
            this.titlu.Name = "titlu";
            this.titlu.Size = new System.Drawing.Size(28, 39);
            this.titlu.TabIndex = 6;
            this.titlu.Text = ".";
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
            this.inapoi.Location = new System.Drawing.Point(26, 590);
            this.inapoi.Name = "inapoi";
            this.inapoi.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.inapoi.OnHoverButtonColor = System.Drawing.Color.MidnightBlue;
            this.inapoi.OnHoverTextColor = System.Drawing.Color.White;
            this.inapoi.Size = new System.Drawing.Size(84, 36);
            this.inapoi.TabIndex = 50;
            this.inapoi.Text = "Inapoi";
            this.inapoi.TextColor = System.Drawing.Color.White;
            this.inapoi.UseVisualStyleBackColor = false;
            this.inapoi.Click += new System.EventHandler(this.inapoi_Click);
            // 
            // inregistrare_manuala_pacienti
            // 
            this.inregistrare_manuala_pacienti.BackColor = System.Drawing.Color.Transparent;
            this.inregistrare_manuala_pacienti.BorderColor = System.Drawing.Color.Transparent;
            this.inregistrare_manuala_pacienti.ButtonColor = System.Drawing.Color.MediumPurple;
            this.inregistrare_manuala_pacienti.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(78)))), ((int)(((byte)(82)))));
            this.inregistrare_manuala_pacienti.FlatAppearance.BorderSize = 0;
            this.inregistrare_manuala_pacienti.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.inregistrare_manuala_pacienti.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.inregistrare_manuala_pacienti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inregistrare_manuala_pacienti.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inregistrare_manuala_pacienti.Location = new System.Drawing.Point(507, 566);
            this.inregistrare_manuala_pacienti.Name = "inregistrare_manuala_pacienti";
            this.inregistrare_manuala_pacienti.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.inregistrare_manuala_pacienti.OnHoverButtonColor = System.Drawing.Color.Purple;
            this.inregistrare_manuala_pacienti.OnHoverTextColor = System.Drawing.Color.White;
            this.inregistrare_manuala_pacienti.Size = new System.Drawing.Size(378, 61);
            this.inregistrare_manuala_pacienti.TabIndex = 48;
            this.inregistrare_manuala_pacienti.Text = "Inregistrare manuala pacienti";
            this.inregistrare_manuala_pacienti.TextColor = System.Drawing.Color.Black;
            this.inregistrare_manuala_pacienti.UseVisualStyleBackColor = false;
            this.inregistrare_manuala_pacienti.Click += new System.EventHandler(this.inregistrare_manuala_pacienti_Click);
            // 
            // fundal
            // 
            this.fundal.Image = ((System.Drawing.Image)(resources.GetObject("fundal.Image")));
            this.fundal.Location = new System.Drawing.Point(-2, 2);
            this.fundal.Name = "fundal";
            this.fundal.Size = new System.Drawing.Size(955, 660);
            this.fundal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fundal.TabIndex = 51;
            this.fundal.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 591);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 16);
            this.label1.TabIndex = 52;
            this.label1.Text = "Selectati coloana din tabel la care medic doriti sa faceti programarea\r\n";
            // 
            // Lista_Doctori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 662);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inapoi);
            this.Controls.Add(this.inregistrare_manuala_pacienti);
            this.Controls.Add(this.titlu);
            this.Controls.Add(this.tabel_doctorii);
            this.Controls.Add(this.fundal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Lista_Doctori";
            this.Text = "Lista_Doctori";
            this.Load += new System.EventHandler(this.Lista_Doctori_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabel_doctorii)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fundal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView tabel_doctorii;
        private System.Windows.Forms.Label titlu;
        private ePOSOne.btnProduct.Button_WOC inregistrare_manuala_pacienti;
        private ePOSOne.btnProduct.Button_WOC inapoi;
        private System.Windows.Forms.PictureBox fundal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nume_Doctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Specializare;
        private System.Windows.Forms.Label label1;
    }
}