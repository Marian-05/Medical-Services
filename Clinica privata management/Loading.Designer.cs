namespace Clinica_privata_management
{
    partial class Loading
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loading));
            this.label1 = new System.Windows.Forms.Label();
            this.titlu = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.incarcare = new System.Windows.Forms.Panel();
            this.inc = new System.Windows.Forms.Timer(this.components);
            this.procent = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3037, 248);
            this.label1.Margin = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // titlu
            // 
            this.titlu.ForeColor = System.Drawing.Color.DarkGreen;
            this.titlu.Location = new System.Drawing.Point(219, 16);
            this.titlu.Name = "titlu";
            this.titlu.Size = new System.Drawing.Size(844, 50);
            this.titlu.TabIndex = 1;
            this.titlu.Text = "Medical Services";
            this.titlu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-29, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1217, 674);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.Controls.Add(this.incarcare);
            this.panel1.Location = new System.Drawing.Point(190, 585);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(810, 33);
            this.panel1.TabIndex = 3;
            // 
            // incarcare
            // 
            this.incarcare.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.incarcare.Dock = System.Windows.Forms.DockStyle.Left;
            this.incarcare.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.incarcare.Location = new System.Drawing.Point(5, 5);
            this.incarcare.Name = "incarcare";
            this.incarcare.Size = new System.Drawing.Size(10, 23);
            this.incarcare.TabIndex = 4;
            // 
            // inc
            // 
            this.inc.Interval = 30;
            this.inc.Tick += new System.EventHandler(this.inc_Tick);
            // 
            // procent
            // 
            this.procent.AutoSize = true;
            this.procent.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.procent.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.procent.Location = new System.Drawing.Point(594, 530);
            this.procent.Name = "procent";
            this.procent.Size = new System.Drawing.Size(31, 42);
            this.procent.TabIndex = 4;
            this.procent.Text = ".";
            // 
            // Loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(29F, 55F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 671);
            this.Controls.Add(this.procent);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.titlu);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(15, 13, 15, 13);
            this.Name = "Loading";
            this.Text = "Loading";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label titlu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel incarcare;
        private System.Windows.Forms.Timer inc;
        private System.Windows.Forms.Label procent;
    }
}