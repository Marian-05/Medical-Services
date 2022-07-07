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
    public partial class Lista_Doctori : System.Windows.Forms.Form
    {
        public Lista_Doctori()
        {
            InitializeComponent();
        }



        private void button3_Click(object sender, EventArgs e)
        {

        }
        public static IFirebaseConfig fb = new FirebaseConfig()
        {
            AuthSecret = "oPcsmG7DMhoxAa8Zk3jXejQYmnmsRU3whHbYLw0l",
            BasePath = "https://management-clinici-private-default-rtdb.europe-west1.firebasedatabase.app/"
        };
        public static IFirebaseClient conexiune;

        string nd, s;
        public static string nume_doctor_selectat;
        public static string cnp_doooctor;
        private void tabel_doctorii_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                nume_doctor_selectat = tabel_doctorii.CurrentRow.Cells[0].Value.ToString();

                FirebaseResponse response = conexiune.Get("Doctori/");
                Dictionary<string, Ddoctor> result = response.ResultAs<Dictionary<string, Ddoctor>>();
                foreach (var get in result)
                {
                    if (nume_doctor_selectat == get.Value.nume1)
                    {
                        cnp_doooctor = get.Value.cnp_doctor;

                    }
                }

                if (Logare.cont_clinica == false)
                {
                    P1.pp.Controls.RemoveAt(0);
                    Date_Pacient date_Pacient = new Date_Pacient();
                    date_Pacient.TopLevel = false;
                    P1.pp.Controls.Add(date_Pacient);
                    date_Pacient.Show();
                }
                else
                {

                    P2.PP.Controls.RemoveAt(0);
                    Lista_Programari lista_Programari = new Lista_Programari();
                    lista_Programari.TopLevel = false;
                    P2.PP.Controls.Add(lista_Programari);
                    lista_Programari.Show();
                }
            }
            catch
            {
                MessageBox.Show("  Nu aveti conexiune la internet !");
            }
        }

        public static bool veri = false;
        public static string doctor_name;

        private void inregistrare_manuala_pacienti_Click(object sender, EventArgs e)
        {
            FirebaseResponse response = conexiune.Get("Doctori/");
            Dictionary<string, Ddoctor> result = response.ResultAs<Dictionary<string, Ddoctor>>();

            try
            {
                if (tabel_doctorii.CurrentRow.Cells["Nume_Doctor"].Value != null)
                {
                    nume_doctor_selectat = tabel_doctorii.CurrentRow.Cells["Nume_Doctor"].Value.ToString();
                    doctor_name = tabel_doctorii.CurrentRow.Cells["Nume_Doctor"].Value.ToString();
                    foreach (var get in result)
                    {
                        if (nume_doctor_selectat == get.Value.nume1)
                        {
                            cnp_doooctor = get.Value.cnp_doctor;

                        }
                    }

                    P2.PP.Controls.Clear();
                    Inregistrare_manuala__pacienti inregistrare_Manuala__Pacienti = new Inregistrare_manuala__pacienti();
                    inregistrare_Manuala__Pacienti.TopLevel = false;
                    P2.PP.Controls.Add(inregistrare_Manuala__Pacienti);
                    inregistrare_Manuala__Pacienti.Show();
                }
                else
                {
                    MessageBox.Show(" Alegeti un rand completat !");
                }
            }
            catch
            {

            }
        }
        private void inapoi_Click(object sender, EventArgs e)
        {
            Lista_Clinici l_c = new Lista_Clinici();
            l_c.TopLevel = false;
            P1.pp.Controls.RemoveAt(0);
            P1.pp.Controls.Add(l_c);
            l_c.Show();
        }

        private void Lista_Doctori_Load(object sender, EventArgs e)
        {
            tabel_doctorii.ColumnHeadersDefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            if (Logare.cont_clinica == true)
            {
                inapoi.Hide();
            }
            tabel_doctorii.RowHeadersVisible = false;
            if (Logare.cont_clinica == false)
            {
                label1.Hide();
                inregistrare_manuala_pacienti.Hide();
            }
            veri = false;
            inregistrare_manuala_pacienti.Parent = fundal;
            if (Logare.cont_clinica == false)
            {
                titlu.Text = "Doctori " + Lista_Clinici.nume_clinica_selectata;
            }
            else
            {
                titlu.Text = "Doctori " + Logare.clinica_nume;
            }
            inapoi.Parent = fundal;

            conexiune = new FireSharp.FirebaseClient(fb);
            try
            {

                if (Logare.cont_clinica == true)
                {
                    FirebaseResponse response1 = conexiune.Get($"Clinici/{Logare.clinica_nume}/Doctori/");
                    Dictionary<string, Ddoctor> result1 = response1.ResultAs<Dictionary<string, Ddoctor>>();
                    if (result1 != null)
                    {
                        foreach (var get in result1)
                        {
                            nd = get.Value.nume1;
                            s = get.Value.specealizare;

                            tabel_doctorii.Rows.Add(new object[] { nd, s });
                        }
                    }
                    else
                    {
                        MessageBox.Show(" Nu s-a logat niciun doctor !");
                    }
                }
                else
                {
                    FirebaseResponse response1 = conexiune.Get($"Clinici/{Lista_Clinici.nume_clinica_selectata}/Doctori/");
                    Dictionary<string, Ddoctor> result1 = response1.ResultAs<Dictionary<string, Ddoctor>>();
                    if (result1 != null)
                    {
                        foreach (var get in result1)
                        {
                            nd = get.Value.nume1;
                            s = get.Value.specealizare;

                            tabel_doctorii.Rows.Add(new object[] { nd, s });
                        }
                    }
                    else
                    {
                        MessageBox.Show(" Nu s-a logat niciun doctor !");
                    }
                }
            }
            catch
            {
                MessageBox.Show("  Nu aveti conexiune la internet !");
            }
        }
    }
}
