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
    public partial class Inregistrare_manuala__pacienti : Form
    {
        public Inregistrare_manuala__pacienti()
        {
            InitializeComponent();
        }
        public static IFirebaseConfig fb = new FirebaseConfig()
        {
            AuthSecret = "oPcsmG7DMhoxAa8Zk3jXejQYmnmsRU3whHbYLw0l",
            BasePath = "https://management-clinici-private-default-rtdb.europe-west1.firebasedatabase.app/"
        };
        public static IFirebaseClient conexiune;
        private void Inregistrare_manuala__pacienti_Load(object sender, EventArgs e)
        {
            conexiune = new FireSharp.FirebaseClient(fb); titlu.Parent = fundal;
            pictureBox2.Parent = fundal;
            pagina_inregistrare_pacienti.Parent = fundal;

        }
        public static string numele_pacientului;
        public static string cnp_pacientului;

        private void pagina_inregistrare_pacienti_Click(object sender, EventArgs e)
        {
            int v = 0;

            try
            {
                FirebaseResponse response = conexiune.Get("Pacienti/");
                Dictionary<string, Dpacient> result1 = response.ResultAs<Dictionary<string, Dpacient>>();
                if (result1 != null)
                {
                    foreach (var get in result1)
                    {
                        if (t2.Text == get.Value.cnp_pacient) { MessageBox.Show("  Acest CNP este deja folosit !"); v = 1; }
                    }
                }
                if (t1.TextLength == 0 || t2.TextLength == 0)
                {
                    MessageBox.Show(" Introduceti toate datele !");
                }
                else if (long.TryParse(t2.Text, out long value))
                {
                    // daca este doar numeric

                    if (t2.TextLength != 13)
                    {
                        MessageBox.Show(" CNP are 13 cifre al dumneavoastra are " + t2.TextLength); v = 1;
                    }

                    if (v == 0)
                    {
                        try
                        {
                            Dpacient dp = new Dpacient()
                            {
                                nume = t1.Text,

                                cnp_pacient = t2.Text

                            };
                            numele_pacientului = t1.Text;
                            cnp_pacientului = t2.Text;
                            Lista_Doctori.veri = true;

                            MessageBox.Show(" Inregistrare finalizata ");
                            t1.Clear();
                            t2.Clear();

                            if (Logare.cont_clinica == false)
                            {
                                Form1.panel.Controls.Clear();
                                Logare logare = new Logare();
                                logare.TopLevel = false;
                                Form1.panel.Controls.Add(logare);
                                logare.Show();
                            }
                            else
                            {
                                P2.PP.Controls.Clear();
                                Date_Pacient date_Pacient = new Date_Pacient();
                                date_Pacient.TopLevel = false;
                                P2.PP.Controls.Add(date_Pacient);
                                date_Pacient.Show();


                            }

                        }
                        catch
                        {
                            MessageBox.Show("Nu aveti conexiune la internet !");
                        }
                    }
                }
                else
                {// daca nu este doar numeric
                    if (t2.TextLength > 19)
                    {
                        MessageBox.Show(" Nr de tel are 10 cifre al dumneavoastra are " + t2.TextLength);
                    }
                    else
                        MessageBox.Show("  Nr de telefon trebuie sa contina doar numere !");
                }
            }
            catch
            {

            }
        }


    }
}
