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
    public partial class Date_Pacient : System.Windows.Forms.Form
    {

        public Date_Pacient()
        {
            InitializeComponent(); CC.Parent = pictureBox1;
        }
        IFirebaseConfig fb = new FirebaseConfig()
        {
            AuthSecret = "oPcsmG7DMhoxAa8Zk3jXejQYmnmsRU3whHbYLw0l",
            BasePath = "https://management-clinici-private-default-rtdb.europe-west1.firebasedatabase.app/"
        };
        IFirebaseClient conexiune1;

        private void Date_Pacient_Load(object sender, EventArgs e)
        {
            inapoi.Parent = pictureBox1;
            if (Logare.cont_clinica == true)
            {
                CC.ButtonColor = Color.MediumPurple;
                CC.OnHoverButtonColor = Color.Purple;
            }
            fem.Parent = pictureBox1;
            masc.Parent = pictureBox1;
            titilu.Text = "Date programare la Medicul " + Lista_Doctori.nume_doctor_selectat;


        }
        int sex = 0;
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            sex = 2;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            sex = 1;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        string sex_name;

        public static string varsta_pt_data_si_ora;
        public static string nr_tel_pt_data_si_ora;
        public static string sex_pt_data_si_ora;
        public static string probleme_de_sanatate_pt_data_si_ora;

        private void CC_Click(object sender, EventArgs e)

        {


            conexiune1 = new FireSharp.FirebaseClient(fb);


            if (t1.Text.Length > 0 && t2.Text.Length > 0 && t3.Text.Length > 0 && (sex == 1 || sex == 2))
            {
                if (long.TryParse(t2.Text, out long value))
                {
                    // daca este doar numeric


                    if (t2.Text.Length == 10)
                    {

                        if (sex == 1)
                            sex_name = "Masculin";
                        if (sex == 2) sex_name = "Feminin";
                        if (Lista_Doctori.veri == true)
                        {
                            Logare.Nume = Inregistrare_manuala__pacienti.numele_pacientului;
                            Logare.cnppacient = Inregistrare_manuala__pacienti.cnp_pacientului;

                        }
                        varsta_pt_data_si_ora = t1.Text;
                        nr_tel_pt_data_si_ora = t2.Text;
                        sex_pt_data_si_ora = sex_name;
                        probleme_de_sanatate_pt_data_si_ora = t3.Text;
                        if (Logare.cont_clinica == false)
                        {
                            P1.pp.Controls.RemoveAt(0);
                            Data_si_ora data_Si_Ora = new Data_si_ora();
                            data_Si_Ora.TopLevel = false;
                            P1.pp.Controls.Add(data_Si_Ora);
                            data_Si_Ora.Show();


                        }
                        else
                        {
                            P2.PP.Controls.RemoveAt(0);
                            Data_si_ora data_Si_Ora = new Data_si_ora();
                            data_Si_Ora.TopLevel = false;
                            P2.PP.Controls.Add(data_Si_Ora);
                            data_Si_Ora.Show();

                        }


                    }
                    else
                    {
                        MessageBox.Show("  Nr de telefon trebuie sa contina 10 cifre al dumneavoatra contine " + t2.TextLength);
                    }
                }
                else
                {// daca nu este doar numeric
                    if (t2.TextLength > 11)
                    {
                        MessageBox.Show("  Nr de tel are 10 cifre al dumneavoastra are " + t2.TextLength);
                    }
                    else
                        MessageBox.Show("  Nr de telefon trebuie sa contina doar numere !");
                }
            }
            else MessageBox.Show("  Introduceti toate datele !");
        }

        private void inapoi_Click(object sender, EventArgs e)
        {
            if (Logare.cont_clinica == false)
            {
                P1.pp.Controls.Clear();
                Lista_Doctori lista_Doctori = new Lista_Doctori();
                lista_Doctori.TopLevel = false;
                P1.pp.Controls.Add(lista_Doctori);
                lista_Doctori.Show();
            }
            else
            {

                P2.PP.Controls.Clear();
                Inregistrare_manuala__pacienti inregistrare_Manuala__Pacienti = new Inregistrare_manuala__pacienti();
                inregistrare_Manuala__Pacienti.TopLevel = false;
                P2.PP.Controls.Add(inregistrare_Manuala__Pacienti);
                inregistrare_Manuala__Pacienti.Show();
            }
        }
    }
}
