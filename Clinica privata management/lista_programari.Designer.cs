namespace Clinica_privata_management
{
    partial class Lista_Programari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lista_Programari));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.titilu = new System.Windows.Forms.Label();
            this.tabel = new System.Windows.Forms.DataGridView();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nume_pacient1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descrere_probleme = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.stergere = new ePOSOne.btnProduct.Button_WOC();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabel)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1275, 821);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // titilu
            // 
            this.titilu.AutoSize = true;
            this.titilu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.titilu.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titilu.Location = new System.Drawing.Point(425, 86);
            this.titilu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titilu.Name = "titilu";
            this.titilu.Size = new System.Drawing.Size(457, 49);
            this.titilu.TabIndex = 9;
            this.titilu.Text = "Lista programari pacienti";
            // 
            // tabel
            // 
            this.tabel.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tabel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Index,
            this.cnp,
            this.Nume_pacient1,
            this.Column6,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tabel.DefaultCellStyle = dataGridViewCellStyle2;
            this.tabel.Location = new System.Drawing.Point(31, 292);
            this.tabel.Margin = new System.Windows.Forms.Padding(4);
            this.tabel.Name = "tabel";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabel.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tabel.RowHeadersWidth = 4;
            this.tabel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabel.Size = new System.Drawing.Size(1157, 222);
            this.tabel.TabIndex = 10;
            this.tabel.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabel_CellContentDoubleClick);
            // 
            // Index
            // 
            this.Index.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Index.HeaderText = "Index";
            this.Index.MinimumWidth = 6;
            this.Index.Name = "Index";
            this.Index.Width = 94;
            // 
            // cnp
            // 
            this.cnp.HeaderText = "CNP";
            this.cnp.MinimumWidth = 6;
            this.cnp.Name = "cnp";
            this.cnp.Width = 125;
            // 
            // Nume_pacient1
            // 
            this.Nume_pacient1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Nume_pacient1.HeaderText = "Nume pacient";
            this.Nume_pacient1.MinimumWidth = 6;
            this.Nume_pacient1.Name = "Nume_pacient1";
            this.Nume_pacient1.Width = 158;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column6.HeaderText = "Varsta";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 104;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "Sex";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 79;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "Numar de telefon";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 187;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.HeaderText = "Data";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 86;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.HeaderText = "Ora";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 77;
            // 
            // descrere_probleme
            // 
            this.descrere_probleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descrere_probleme.Location = new System.Drawing.Point(409, 565);
            this.descrere_probleme.Margin = new System.Windows.Forms.Padding(4);
            this.descrere_probleme.Name = "descrere_probleme";
            this.descrere_probleme.Size = new System.Drawing.Size(443, 184);
            this.descrere_probleme.TabIndex = 11;
            this.descrere_probleme.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Bisque;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(549, 518);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 31);
            this.label1.TabIndex = 12;
            this.label1.Text = "Simptome :";
            // 
            // stergere
            // 
            this.stergere.BackColor = System.Drawing.Color.Transparent;
            this.stergere.BorderColor = System.Drawing.Color.Transparent;
            this.stergere.ButtonColor = System.Drawing.Color.Red;
            this.stergere.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(78)))), ((int)(((byte)(82)))));
            this.stergere.FlatAppearance.BorderSize = 0;
            this.stergere.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.stergere.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.stergere.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stergere.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stergere.Location = new System.Drawing.Point(851, 725);
            this.stergere.Margin = new System.Windows.Forms.Padding(4);
            this.stergere.Name = "stergere";
            this.stergere.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.stergere.OnHoverButtonColor = System.Drawing.Color.DarkRed;
            this.stergere.OnHoverTextColor = System.Drawing.Color.White;
            this.stergere.Size = new System.Drawing.Size(369, 75);
            this.stergere.TabIndex = 40;
            this.stergere.Text = "Stergere programare";
            this.stergere.TextColor = System.Drawing.Color.Black;
            this.stergere.UseVisualStyleBackColor = false;
            this.stergere.Click += new System.EventHandler(this.stergere_Click);
            // 
            // Lista_Programari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 815);
            this.Controls.Add(this.stergere);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.descrere_probleme);
            this.Controls.Add(this.tabel);
            this.Controls.Add(this.titilu);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Lista_Programari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "`";
            this.Load += new System.EventHandler(this.Lista_Programari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label titilu;
        private System.Windows.Forms.DataGridView tabel;
        private System.Windows.Forms.RichTextBox descrere_probleme;
        private System.Windows.Forms.Label label1;
        private ePOSOne.btnProduct.Button_WOC stergere;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nume_pacient1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}