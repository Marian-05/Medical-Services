using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
namespace Clinica_privata_management
{
    public partial class P2 : System.Windows.Forms.Form
    {
        public static Panel PP;
        public static Button b_acasa;
        public static Button b_programare;
        public P2()
        {
            InitializeComponent(); PP = P; b_acasa = buton1;
            b_programare = buton2;
        }
        public static IFirebaseConfig fb = new FirebaseConfig()
        {
            AuthSecret = "oPcsmG7DMhoxAa8Zk3jXejQYmnmsRU3whHbYLw0l",
            BasePath = "https://management-clinici-private-default-rtdb.europe-west1.firebasedatabase.app/"
        };
        public static IFirebaseClient conexiune;
        private void P2_Load(object sender, EventArgs e)
        {
            conexiune = new FireSharp.FirebaseClient(fb);
            if (Logare.cont_clinica == true)
            {
                numee_clinica.Text = Logare.numele_clinicii_logare;
                Clinica_clinica.Text = "Clinica";
                numee_clinica.Show();
                Clinica_clinica.Show();
                formula_de_intampinare.Hide();
                numele_doctorului.Hide();
            }
            if (Logare.ok == 1)
            {
                numele_doctorului.Text = "Medicul " + Logare.doctor_name;
                numee_clinica.Hide();
                Clinica_clinica.Hide();
                formula_de_intampinare.Show();
                numele_doctorului.Show();
            }
            buton1.BackColor = Color.Green;
            buton2.BackColor = Color.Transparent;
            buton3.BackColor = Color.Transparent;

            Home1 home1 = new Home1();
            home1.TopLevel = false;
            PP.Controls.Add(home1);
            home1.Show(); Logare.ok = 0;

        }

        private void buton1_Click(object sender, EventArgs e)
        {
            buton1.BackColor = Color.Green;
            buton2.BackColor = Color.Transparent;
            buton3.BackColor = Color.Transparent;

            PP.Controls.Clear();
            Home1 Home1 = new Home1();
            Home1.TopLevel = false;
            PP.Controls.Add(Home1);
            Home1.Show();

        }
        public static string cnp_doooctor;

        private void buton2_Click(object sender, EventArgs e)
        {
            if (Logare.cont_clinica == true)
            {
                PP.Controls.Clear();
                Lista_Doctori lista_Doctori = new Lista_Doctori();
                lista_Doctori.TopLevel = false;
                PP.Controls.Add(lista_Doctori);
                lista_Doctori.Show();
            }
            else
            {
                PP.Controls.Clear();
                FirebaseResponse response = conexiune.Get("Doctori/");
                Dictionary<string, Ddoctor> result = response.ResultAs<Dictionary<string, Ddoctor>>();
                foreach (var get in result)
                {
                    if (Logare.doctor_name == get.Value.nume1)
                    {
                        cnp_doooctor = get.Value.cnp_doctor;
                    }
                }
                Lista_Programari lista_Pp = new Lista_Programari();
                lista_Pp.TopLevel = false;
                PP.Controls.Add(lista_Pp);
                lista_Pp.Show();
            }
            buton2.BackColor = Color.Green;
            buton1.BackColor = Color.Transparent;
            buton3.BackColor = Color.Transparent;
        }

        private void buton3_Click(object sender, EventArgs e)
        {
            if (Logare.cont_clinica == true)
            {
                Logare.cont_clinica = false;
            }
            buton3.BackColor = Color.Green;
            buton1.BackColor = Color.Transparent;
            buton1.BackColor = Color.Transparent;

            this.Hide();
            Logare logare = new Logare();
            logare.TopLevel = false; Form1.panel.Controls.Add(logare);
            logare.Show();

        }
    }

}
