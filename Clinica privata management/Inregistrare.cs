using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace Clinica_privata_management
{
    public partial class Inregistrare : System.Windows.Forms.Form
    {
        public Inregistrare()
        {
            InitializeComponent(); t3.PasswordChar = '*';
        }
        IFirebaseConfig fb = new FirebaseConfig()
        {
            AuthSecret = "oPcsmG7DMhoxAa8Zk3jXejQYmnmsRU3whHbYLw0l",
            BasePath = "https://management-clinici-private-default-rtdb.europe-west1.firebasedatabase.app/"
        };
        IFirebaseClient conexiune;

        private void Inregistrare_Load(object sender, EventArgs e)
        {
            conexiune = new FireSharp.FirebaseClient(fb);
        }

        private void arata_CheckedChanged(object sender, EventArgs e)
        {
            if (arata.Checked)
            {
                t3.PasswordChar = '\0'; arata.Text = "Ascunde parola";
            }
            else
            {
                t3.PasswordChar = '*'; arata.Text = "Arata parola";
            }
        }
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
                if (t1.TextLength == 0 || t3.TextLength == 0 || t2.TextLength == 0)
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
                                parola = t3.Text,
                                cnp_pacient = t2.Text

                            };
                            var setter = conexiune.Set($"Pacienti/{t1.Text} ({t2.Text})", dp);
                            MessageBox.Show(" Inregistrare finalizata ");
                            t1.Clear();
                            t2.Clear();
                            t3.Clear();
                            Form1.panel.Controls.Clear();
                            Logare logare = new Logare();
                            logare.TopLevel = false;
                            Form1.panel.Controls.Add(logare);
                            logare.Show();

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

        private void pagina_inregistrare_pacienti_inapoi_Click(object sender, EventArgs e)
        {
            this.Close();
            Logare l = new Logare();
            l.TopLevel = false; Form1.panel.Controls.Add(l);
            l.Show();
        }
    }
}
