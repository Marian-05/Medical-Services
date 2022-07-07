namespace Clinica_privata_management
{
    partial class Lista_Clinici
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lista_Clinici));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabel_clinici = new System.Windows.Forms.DataGridView();
            this.Nume_Clinica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.inapoi = new ePOSOne.btnProduct.Button_WOC();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabel_clinici)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(955, 660);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
           
            // 
            // tabel_clinici
            // 
            this.tabel_clinici.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabel_clinici.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tabel_clinici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabel_clinici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nume_Clinica});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tabel_clinici.DefaultCellStyle = dataGridViewCellStyle2;
            this.tabel_clinici.GridColor = System.Drawing.SystemColors.Highlight;
            this.tabel_clinici.Location = new System.Drawing.Point(45, 119);
            this.tabel_clinici.Name = "tabel_clinici";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabel_clinici.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tabel_clinici.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabel_clinici.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.tabel_clinici.RowTemplate.Height = 30;
            this.tabel_clinici.Size = new System.Drawing.Size(447, 154);
            this.tabel_clinici.TabIndex = 2;
          
            this.tabel_clinici.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabel_clinici_CellContentDoubleClick);
            // 
            // Nume_Clinica
            // 
            this.Nume_Clinica.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nume_Clinica.HeaderText = "Nume Clinici";
            this.Nume_Clinica.MinimumWidth = 6;
            this.Nume_Clinica.Name = "Nume_Clinica";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.CadetBlue;
            this.label1.Font = new System.Drawing.Font("MV Boli", 21.75F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(320, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lista clinici particulare";
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
            this.inapoi.TabIndex = 49;
            this.inapoi.Text = "Inapoi";
            this.inapoi.TextColor = System.Drawing.Color.White;
            this.inapoi.UseVisualStyleBackColor = false;
            this.inapoi.Click += new System.EventHandler(this.inapoi_Click);
            // 
            // Lista_Clinici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 662);
            this.Controls.Add(this.inapoi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabel_clinici);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Lista_Clinici";
            this.Text = "Vizualizare1";
            this.Load += new System.EventHandler(this.Lista_Clinici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabel_clinici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView tabel_clinici;
        private System.Windows.Forms.Label label1;
        private ePOSOne.btnProduct.Button_WOC inapoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nume_Clinica;
    }
}