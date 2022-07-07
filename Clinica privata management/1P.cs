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
    public partial class P1 : System.Windows.Forms.Form
    {
        public static Button button_acasa;
        public static Button buton_incepere_inregistrare;
        public static Panel pp;
        public P1()
        {
            InitializeComponent();label2.Text = Logare.Nume;pp = P;
            button_acasa = pagina_principala_pacient;
            buton_incepere_inregistrare = creare_programrare_pacienti;

        }
        private void P1_Load(object sender, EventArgs e)
        {
            if (Logare.ok == 1)
            {
                pagina_principala_pacient.BackColor = Color.Green;
                creare_programrare_pacienti.BackColor = Color.Transparent;
                iesire_din_cont_pacienti.BackColor = Color.Transparent;

                Home1 home1 = new Home1();
                home1.TopLevel = false;
                pp.Controls.Add(home1);
                home1.Show(); Logare.ok = 0;
            }
        }

        private void pagina_principala_pacient_Click(object sender, EventArgs e)
        {
            pagina_principala_pacient.BackColor = Color.Green;
            creare_programrare_pacienti.BackColor = Color.Transparent;
            iesire_din_cont_pacienti.BackColor = Color.Transparent;
            pp.Controls.RemoveAt(0);
            Home1 home1 = new Home1();
            home1.TopLevel = false;
            pp.Controls.Add(home1); home1.Show();

        }

       

        private void iesire_din_cont_pacienti_Click(object sender, EventArgs e)
        {
            pagina_principala_pacient.BackColor = Color.Transparent;
            creare_programrare_pacienti.BackColor = Color.Transparent;
            iesire_din_cont_pacienti.BackColor = Color.Green;
            this.Hide();
            Logare logare = new Logare();
            logare.TopLevel = false;
            Form1.panel.Controls.Add(logare);
            logare.Show();
        }


        private void creare_programrare_pacienti_Click_1(object sender, EventArgs e)
        {
           
            pagina_principala_pacient.BackColor = Color.Transparent;
            creare_programrare_pacienti.BackColor = Color.Green;
            iesire_din_cont_pacienti.BackColor = Color.Transparent;
            pp.Controls.Clear();
            Afisarea_Orasului afisarea_Orasului = new Afisarea_Orasului();
            afisarea_Orasului.TopLevel = false;
            pp.Controls.Add(afisarea_Orasului);
            afisarea_Orasului.Show();
        }

        
    }

        
    
}
