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
    public partial class CreareClinica : System.Windows.Forms.Form
    {
        public CreareClinica()
        {
            InitializeComponent(); t4.PasswordChar = '*';
        }
        IFirebaseConfig fb = new FirebaseConfig()
        {
            AuthSecret = "oPcsmG7DMhoxAa8Zk3jXejQYmnmsRU3whHbYLw0l",
            BasePath = "https://management-clinici-private-default-rtdb.europe-west1.firebasedatabase.app/"
        };
        IFirebaseClient conexiune1;




        private void button_WOC2_Click(object sender, EventArgs e)
        {

            this.Close();
            Alegere_oras alegere_Oras = new Alegere_oras();
            alegere_Oras.TopLevel = false;
            Form1.panel.Controls.Add(alegere_Oras);
            alegere_Oras.Show();
        }

        private void CC_Click(object sender, EventArgs e)
        {
            bool v = false;
            try
            {
                if (t1.Text.Length > 0 && t2.Text.Length > 0 && t3.Text.Length > 0 && t4.Text.Length > 0)
                {



                    if (t4.Text == ",$[gVz#7t5w-w(9`")
                    {
                        Clinica clinica = new Clinica()
                        {
                            nume_clinica = t1.Text + " (" + t3.Text + ")",
                            parola_clinica = t2.Text,
                            oras_clinica = Alegere_oras.nume_oras,
                            nume_clinica_simplificat = t1.Text,

                        };
                        string nume = t1.Text + " (" + t3.Text + ")";
                        FirebaseResponse response1 = conexiune1.Get($"Clinici/");
                        Dictionary<string, Clinica> result = response1.ResultAs<Dictionary<string, Clinica>>();
                        if (result != null)
                        {
                            foreach (var get in result)
                            {
                                string t = get.Value.nume_clinica;

                                if (t == nume)
                                {
                                    v = true;
                                }
                            }
                        }
                        if (v == false)
                        {
                            var setter = conexiune1.Set($"Clinici/{t1.Text} ({t3.Text})", clinica);
                            MessageBox.Show("Inregistrare reusita");
                            t1.Clear();
                            t2.Clear();
                            t3.Clear();
                            t4.Clear();
                            Logare.verificare_clinica = false;
                            Form1.panel.Controls.Clear();
                            Logare logare = new Logare();
                            logare.TopLevel = false;
                            Form1.panel.Controls.Add(logare);
                            logare.Show();
                        }
                        else
                        {
                            MessageBox.Show("  Acest nume de clinica este deja folosit !");
                        }
                    }
                    else if (t4.TextLength == 0) MessageBox.Show("  Introduceti toate datele !");
                    else MessageBox.Show("Introduceti ID National incorect !");
                }
                else
                {
                    MessageBox.Show("  Introduceti toate datele !");
                }
            }
            catch
            {
                MessageBox.Show("  Nu aveti conexiune la internet !");
            }
        }

        private void CreareClinica_Load(object sender, EventArgs e)
        {
            conexiune1 = new FireSharp.FirebaseClient(fb);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
