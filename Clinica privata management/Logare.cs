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
    public partial class Logare : System.Windows.Forms.Form
    {
        int doctor_verificare = 0;
        public Logare()
        {
            InitializeComponent(); parola.PasswordChar = '*'; label2.Parent = fundal;
            label1.Parent = fundal; pictureBox1.Parent = fundal; titlu.Parent = fundal;
            inregistrare_operator.Parent = fundal;
            buton_inregistrare_pacienti.Parent = fundal;
            buton_inregistrare_doctori.Parent = fundal;
            buton_logare.Parent = fundal;
            checkBox1.Parent = fundal;
            arata.Parent = fundal;

        }
        public static int ok = 0;
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (arata.Checked)
            {
                parola.PasswordChar = '\0'; arata.Text = "Ascunde parola";
            }
            else
            {
                parola.PasswordChar = '*'; arata.Text = "Arata parola";
            }
        }
        public static string doctor_name;

        public static IFirebaseConfig fb = new FirebaseConfig()
        {
            AuthSecret = "oPcsmG7DMhoxAa8Zk3jXejQYmnmsRU3whHbYLw0l",
            BasePath = "https://management-clinici-private-default-rtdb.europe-west1.firebasedatabase.app/"
        };
        public static IFirebaseClient conexiune;
        private void Logare_Load(object sender, EventArgs e)
        {
            checkBox2.Parent = fundal;
            conexiune = new FireSharp.FirebaseClient(fb);
        }
        public static string Nume;
        int ver1 = 0;



        int centralist_verificare = 0;
        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                centralist_verificare = 1;
                checkBox1.Checked = false;
            }

            else centralist_verificare = 0;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                doctor_verificare = 1;
                checkBox2.Checked = false;
            }
            else doctor_verificare = 0;

        }
        public static string numele_clinicii_logare;
        public static bool cont_clinica = false;
        public static string cnppacient;
        public static string cnpdoctor;
        public static string clinica_oras;
        public static string clinica_nume;
        private void buton_logare_Click_1(object sender, EventArgs e)
        {
            int ver2 = 0;

            if (doctor_verificare == 0 && centralist_verificare == 0)
            {
                try
                {
                    FirebaseResponse response = conexiune.Get("Pacienti/");
                    Dictionary<string, Dpacient> result1 = response.ResultAs<Dictionary<string, Dpacient>>();

                    if (result1 != null)
                    {

                        foreach (var get in result1)
                        {

                            string N = get.Value.nume;
                            string P = get.Value.parola;
                            if (N == nume0.Text && P == parola.Text)
                            {
                                Nume = nume0.Text;
                                ok = 1;
                                this.Hide();
                                P1 p1 = new P1();
                                p1.TopLevel = false;
                                Form1.panel.Controls.Add(p1);
                                p1.Show();
                                ver1 = 1;
                                cnppacient = get.Value.cnp_pacient;
                            }
                        }
                        if (ver1 == 0 && centralist_verificare == 0 && doctor_verificare == 0)
                        {
                            MessageBox.Show("  Introduceti datele corect  !");
                        }
                    }

                }
                catch
                {
                    MessageBox.Show("  Nu aveti conexiune la internet !");
                }

            }

            else if (doctor_verificare == 1 && centralist_verificare == 0)
            {
                ok = 1; doctor_name = nume0.Text;
                try
                {
                    FirebaseResponse response = conexiune.Get("Doctori/");
                    Dictionary<string, Ddoctor> result = response.ResultAs<Dictionary<string, Ddoctor>>();
                    if (result != null)
                    {
                        foreach (var get in result)
                        {

                            string N = get.Value.nume1;
                            string P = get.Value.parola1;
                            if (N == nume0.Text && P == parola.Text)
                            {
                                this.Hide();
                                P2 p2 = new P2();
                                p2.TopLevel = false;
                                Form1.panel.Controls.Add(p2);
                                p2.Show(); ver2 = 1;
                                cnpdoctor = get.Value.cnp_doctor;
                            }

                        }
                        if (ver2 == 0)
                        {
                            MessageBox.Show("  Introduceti datele corect !");
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("  Nu aveti conexiune la internet !");
                }
            }
            if (centralist_verificare == 1 && doctor_verificare == 0)
            {
                FirebaseResponse response = conexiune.Get("Clinici/");
                Dictionary<string, Clinica> result = response.ResultAs<Dictionary<string, Clinica>>();
                if (nume0.Text.Length > 0 && parola.Text.Length > 0)
                {
                    foreach (var get in result)
                    {
                        if (get.Value.nume_clinica_simplificat == nume0.Text && get.Value.parola_clinica == parola.Text)
                        {
                            numele_clinicii_logare = get.Value.nume_clinica_simplificat;
                            cont_clinica = true;
                            clinica_oras = get.Value.oras_clinica;
                            clinica_nume = get.Value.nume_clinica;
                            this.Hide();
                            P2 p2 = new P2();
                            p2.TopLevel = false;
                            Form1.panel.Controls.Add(p2);
                            p2.Show(); ver2 = 1;
                        }
                    }
                    if (ver2 == 0)
                    {
                        MessageBox.Show("  Introduceti datele corect !");
                    }
                }
                else
                {
                    MessageBox.Show("  Introduceti toate datele !");
                }
            }

        }
        public static bool verificare_clinica = false;
        public static bool verificare_doctor = false;
        private void buton_inregistrare_pacienti_Click(object sender, EventArgs e)
        {
            this.Hide(); Form1.panel.Controls.RemoveAt(0);
            Inregistrare inregistrare = new Inregistrare();
            inregistrare.TopLevel = false;
            Form1.panel.Controls.Add(inregistrare);
            inregistrare.Show();
        }

        private void buton_inregistrare_doctori_Click_1(object sender, EventArgs e)
        {
            this.Close(); verificare_doctor = true;
            verificare_clinica = false;

            Alegere_specialitate alegere_Specialitate = new Alegere_specialitate();
            alegere_Specialitate.TopLevel = false; Form1.panel.Controls.Add(alegere_Specialitate);
            alegere_Specialitate.Show();
        }

        private void inregistrare_operator_Click(object sender, EventArgs e)
        {
            verificare_doctor = false;
            verificare_clinica = true;
            Form1.panel.Controls.RemoveAt(0);
            Alegere_oras alegere_Oras = new Alegere_oras();
            alegere_Oras.TopLevel = false;
            Form1.panel.Controls.Add(alegere_Oras);
            alegere_Oras.Show();
        }

    }
}