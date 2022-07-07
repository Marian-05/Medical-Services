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
    public partial class InregistrareDoctor : System.Windows.Forms.Form
    {// o sa pun la numele doctorului in fata cuvantul doctor 
        //asa si pt programari
        public InregistrareDoctor()
        {
            InitializeComponent(); t4.PasswordChar = '*';
        }


        //o sa 

        private void arata_CheckedChanged(object sender, EventArgs e)
        {
            if (arata.Checked)
            {

                t4.PasswordChar = '\0'; arata.Text = "Ascunde parola";
            }
            else
            {
                t4.PasswordChar = '*'; arata.Text = "Arata parola";
            }
        }


        int error = 0;

        private void inrd_Click(object sender, EventArgs e)
        {
            int v = 0;
            bool verificarE = false;
            try
            {
                FirebaseResponse response = conexiune.Get("Doctori/");
                Dictionary<string, Ddoctor> result1 = response.ResultAs<Dictionary<string, Ddoctor>>();
                if (result1 != null)
                {
                    foreach (var get in result1)
                    {
                        if (t2.Text == get.Value.cnp_doctor) { MessageBox.Show("  Acest CNP este deja folosit !"); v = 1; }
                    }
                }
                if (v == 0)
                {





                    if (comboBox1.Text.Length > 0 && t1.Text.Length > 0 && t4.Text.Length > 0 && t2.Text.Length > 0 && t3.Text.Length > 0)
                    {


                        if (long.TryParse(t2.Text, out long value))
                        {
                            // daca este doar numeric
                            if (t2.TextLength != 13)
                            {
                                MessageBox.Show(" CNP are 13 cifre al dumneavoastra are " + t2.TextLength);
                            }
                            else
                            {


                                FirebaseResponse response1 = conexiune.Get($"Clinici/");
                                Dictionary<string, Clinica> result = response1.ResultAs<Dictionary<string, Clinica>>();

                                if (result != null)
                                {
                                    foreach (var get in result)
                                    {

                                        if (t3.Text == get.Value.parola_clinica)
                                        {
                                            verificarE = true;

                                        }

                                    }
                                    if (verificarE == false)
                                    {
                                        MessageBox.Show(" Introduceti corect parola clinicii !");
                                    }
                                    if (verificarE == true)
                                    {
                                        Ddoctor ddoctor = new Ddoctor()
                                        {
                                            nume1 = t1.Text,
                                            parola1 = t4.Text,
                                            specealizare = Alegere_specialitate.SPECEALIZARE,
                                            cnp_doctor = t2.Text,
                                            oras_doctor = Alegere_oras.nume_oras,

                                        };
                                        try
                                        {
                                            var setter1 = conexiune.Set($"Clinici/{clinica_name}/Doctori/Doctorul {t1.Text} ({t2.Text})/", ddoctor);
                                            var setter = conexiune.Set($"Doctori/Doctorul {t1.Text} ({t2.Text})", ddoctor);
                                            Alegere_specialitate.id_national = false;
                                            Logare.verificare_doctor = false;




                                            t1.Clear();
                                            t2.Clear();
                                            t3.Clear();
                                            t4.Clear();
                                            comboBox1.ResetText();

                                            MessageBox.Show("Inregistrare finalizata !");
                                            Form1.panel.Controls.Clear();
                                            Logare logare = new Logare();
                                            logare.TopLevel = false;
                                            Form1.panel.Controls.Add(logare);
                                            logare.Show();
                                        }
                                        catch
                                        {
                                            error = 1;
                                            MessageBox.Show("  Nu aveti conexiune la internet !");
                                        }
                                    }
                                    //inregistrare doctor
                                }
                                else
                                {

                                }


                            }
                        }
                        else
                        {
                            if (t2.TextLength > 19)
                            {
                                MessageBox.Show(" CNP are 13 cifre al dumneavoastra are " + t2.TextLength);
                            }
                            else
                                MessageBox.Show("  Nr de telefon trebuie sa contina doar numere");
                            // daca nu este doar numeric
                        }
                    }

                    else
                    {
                        if (error == 0)
                            MessageBox.Show("  Introduceti toate datele !");

                    }
                }
            }
            catch
            {

            }
        }
        IFirebaseConfig fb = new FirebaseConfig()
        {
            AuthSecret = "oPcsmG7DMhoxAa8Zk3jXejQYmnmsRU3whHbYLw0l",
            BasePath = "https://management-clinici-private-default-rtdb.europe-west1.firebasedatabase.app/"
        };
        IFirebaseClient conexiune;
        private void InregistrareDoctor_Load(object sender, EventArgs e)
        {
            conexiune = new FireSharp.FirebaseClient(fb);
            label1.Text = " Clinici orasul " + Alegere_oras.nume_oras;

        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            this.Close();
            Alegere_oras alegere_Oras = new Alegere_oras();
            alegere_Oras.TopLevel = false;
            Form1.panel.Controls.Add(alegere_Oras);
            alegere_Oras.Show();
        }

        public static string clinica_name;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                FirebaseResponse response = conexiune.Get($"Clinici/");
                Dictionary<string, Clinica> result = response.ResultAs<Dictionary<string, Clinica>>();
                if (result != null)
                {
                    foreach (var get in result)
                    {
                        string nnn2 = get.Value.nume_clinica;


                        if (nnn2 == comboBox1.Text)
                        {
                            clinica_name = nnn2;
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("  Nu aveti conexiune la internet !");
            }
        }

        int intrare1 = 0;
        private void button_WOC2_Click_1(object sender, EventArgs e)
        {
            bool afisare_clinici = false;

            try
            {
                if (intrare1 == 0)
                {

                    intrare1 = 1;

                    FirebaseResponse response = conexiune.Get("Clinici/");
                    Dictionary<string, Clinica> result = response.ResultAs<Dictionary<string, Clinica>>();
                    if (result != null)
                    {
                        foreach (var get in result)
                        {
                            string nnn1 = get.Value.oras_clinica;
                            if (nnn1 == Alegere_oras.nume_oras)
                            {
                                afisare_clinici = true;
                                string nnn2 = get.Value.nume_clinica;
                                comboBox1.Items.Add(nnn2);
                            }
                        }
                        if (afisare_clinici == false)
                        {
                            MessageBox.Show("Nu a fost creata nicio clinica pana acum !");

                        }
                    }
                    else MessageBox.Show("Nu a fost creata nicio clinica pana acum !");

                }
            }
            catch
            {
                MessageBox.Show("  Nu aveti conexiune la internet !");
            }
        }


    }
}
