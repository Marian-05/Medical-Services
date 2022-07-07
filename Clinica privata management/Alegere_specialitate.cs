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
    public partial class Alegere_specialitate : System.Windows.Forms.Form
    {
        int alegere_specialitate = 0;
        public static bool id_national;
        public static string spe;
        int cardiologie = 0, chirurgie = 0, boli_infectioase = 0, medicina_interna = 0, oftalmologie = 0;
        int neurologie = 0, orl = 0, pediatrie = 0, psihiatrie = 0, medicina_generala = 0;



        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            cardiologie = 0; chirurgie = 0; boli_infectioase = 0; medicina_interna = 0; oftalmologie = 1;
            neurologie = 0; orl = 0; pediatrie = 0; psihiatrie = 0; medicina_generala = 0;
            alegere_specialitate = 1;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            cardiologie = 0; chirurgie = 0; boli_infectioase = 0; medicina_interna = 0; oftalmologie = 0;
            neurologie = 1; orl = 0; pediatrie = 0; psihiatrie = 0; medicina_generala = 0; alegere_specialitate = 1;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            cardiologie = 0; chirurgie = 0; boli_infectioase = 0; medicina_interna = 0; oftalmologie = 0;
            neurologie = 0; orl = 1; pediatrie = 0; psihiatrie = 0; medicina_generala = 0; alegere_specialitate = 1;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            cardiologie = 0; chirurgie = 0; boli_infectioase = 0; medicina_interna = 0; oftalmologie = 0;
            neurologie = 0; orl = 0; pediatrie = 1; psihiatrie = 0; medicina_generala = 0; alegere_specialitate = 1;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            cardiologie = 0; chirurgie = 0; boli_infectioase = 0; medicina_interna = 0; oftalmologie = 0;
            neurologie = 0; orl = 0; pediatrie = 0; psihiatrie = 1; medicina_generala = 0; alegere_specialitate = 1;
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            cardiologie = 0; chirurgie = 0; boli_infectioase = 0; medicina_interna = 0; oftalmologie = 0;
            neurologie = 0; orl = 0; pediatrie = 0; psihiatrie = 0; medicina_generala = 1; alegere_specialitate = 1;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            cardiologie = 0; chirurgie = 0; boli_infectioase = 0; medicina_interna = 1; oftalmologie = 0;
            neurologie = 0; orl = 0; pediatrie = 0; psihiatrie = 0; medicina_generala = 0; alegere_specialitate = 1;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            cardiologie = 0; chirurgie = 0; boli_infectioase = 1; medicina_interna = 0; oftalmologie = 0;
            neurologie = 0; orl = 0; pediatrie = 0; psihiatrie = 0; medicina_generala = 0; alegere_specialitate = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            cardiologie = 0; chirurgie = 1; boli_infectioase = 0; medicina_interna = 0; oftalmologie = 0;
            neurologie = 0; orl = 0; pediatrie = 0; psihiatrie = 0; medicina_generala = 0; alegere_specialitate = 1;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            cardiologie = 1; chirurgie = 0; boli_infectioase = 0; medicina_interna = 0; oftalmologie = 0;
            neurologie = 0; orl = 0; pediatrie = 0; psihiatrie = 0; medicina_generala = 0; alegere_specialitate = 1;
        }
        public static string SPECEALIZARE;
        public Alegere_specialitate()
        {
            InitializeComponent();
            t1.PasswordChar = '*';
            id_national = false;
        }

        private void inrd_Click(object sender, EventArgs e)
        {
            if (alegere_specialitate == 1)
            {
                if (t1.Text == ",$[gVz#7t5w-w(9`")
                {

                    if (cardiologie == 1) SPECEALIZARE = "Cardiolog";
                    if (chirurgie == 1) SPECEALIZARE = "Chirurgie";
                    if (boli_infectioase == 1) SPECEALIZARE = "Boli infectioase";
                    if (medicina_interna == 1) SPECEALIZARE = "Medicina interna";
                    if (oftalmologie == 1) SPECEALIZARE = "Oftalmologie";
                    if (neurologie == 1) SPECEALIZARE = "Neurologie";
                    if (orl == 1) SPECEALIZARE = "ORL";
                    if (pediatrie == 1) SPECEALIZARE = "Pediatrie";
                    if (psihiatrie == 1) SPECEALIZARE = "Psihiatrie";
                    if (medicina_generala == 1) SPECEALIZARE = "Medicina generala";
                    MessageBox.Show("Inregistrare finalizata a specializarii dumneavoastra!");
                    Form1.panel.Controls.Clear();

                    Alegere_oras alegere_Oras = new Alegere_oras();
                    alegere_Oras.TopLevel = false;
                    Form1.panel.Controls.Add(alegere_Oras);
                    alegere_Oras.Show();

                    id_national = true;
                }
                else
                    MessageBox.Show("Introduceti corect Id National !");

            }
            else
            {
                MessageBox.Show("Alegeti-va speacialitatea !");
            }
        }


        private void button_WOC1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Logare logare = new Logare();
            logare.TopLevel = false;
            Form1.panel.Controls.Add(logare);
            logare.Show();
        }
    }
}
