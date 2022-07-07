using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica_privata_management
{
    public partial class Loading : System.Windows.Forms.Form
    {
        public Loading()
        {
            InitializeComponent();
            titlu.Parent = pictureBox1;
            titlu.BackColor = Color.Transparent;
            procent.Parent = pictureBox1;
            procent.BackColor = Color.Transparent;
            inc.Start();
            incarcare.Width = 0;
        }
        int i = 0;
        private void inc_Tick(object sender, EventArgs e)
        {

            if (incarcare.Width < 800)
            {
                i++;
                incarcare.Width += 8;
                procent.Text = i.ToString() + " %";
            }
            else
            {
                inc.Stop(); this.Hide();
                Form1.panel.Controls.RemoveAt(0);
                Logare logare = new Logare();
                logare.TopLevel = false;
                Form1.panel.Controls.Add(logare);
                logare.Show();
            }
        }
    }
}
