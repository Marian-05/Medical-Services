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
    public partial class Lista_Programari : System.Windows.Forms.Form
    {
        public Lista_Programari()
        {
            InitializeComponent();
        }
        IFirebaseConfig fb = new FirebaseConfig()
        {
            AuthSecret = "oPcsmG7DMhoxAa8Zk3jXejQYmnmsRU3whHbYLw0l",
            BasePath = "https://management-clinici-private-default-rtdb.europe-west1.firebasedatabase.app/"
        };
        IFirebaseClient conexiune;
        string c, n, v, s, p, d, o, nr, or;
        string cnp_pacient_stergere;
        string nnn;
        private void stergere_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Sunteti sigur sa doriti sa stergeti acesta programare ?", "Stergere programare", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

            {
                cnp_pacient_stergere = tabel.CurrentRow.Cells["CNP"].Value.ToString();
                nnn = tabel.CurrentRow.Cells["Nume_pacient1"].Value.ToString();
                if (Logare.cont_clinica == false)
                {
                    try
                    {

                        var result = conexiune.Delete($"Programari/Doctorul {Logare.doctor_name} ({P2.cnp_doooctor})/Pacienti/{nnn} ({cnp_pacient_stergere})");
                        int rowIndex = tabel.CurrentCell.RowIndex;
                        tabel.Rows.RemoveAt(rowIndex);
                    }
                    catch
                    {
                        MessageBox.Show("  Nu aveti conexiune la internet !");
                    }
                }
                else
                {
                    try
                    {
                        var result = conexiune.Delete($"Programari/Doctorul {Lista_Doctori.nume_doctor_selectat} ({Lista_Doctori.cnp_doooctor})/Pacienti/{nnn} ({cnp_pacient_stergere})");
                        int rowIndex = tabel.CurrentCell.RowIndex;
                        tabel.Rows.RemoveAt(rowIndex);
                    }
                    catch
                    {
                        MessageBox.Show("  Nu aveti conexiune la internet !");
                    }
                }

            }
            int index = 0;

            try
            {
                if (Logare.cont_clinica == true)
                {
                    FirebaseResponse response1 = conexiune.Get($"Programari/Doctorul {Lista_Doctori.nume_doctor_selectat} ({Lista_Doctori.cnp_doooctor})/Pacienti/");
                    Dictionary<string, Programari> result1 = response1.ResultAs<Dictionary<string, Programari>>();
                    if (result1 != null)
                    {
                        foreach (var get in result1)
                        {
                            index++;


                            tabel.CurrentRow.Cells["Index"].Value = index.ToString();


                        };
                    }
                    else
                    {
                        MessageBox.Show("  Nu aveti conexiune la internet !");
                    }
                }

                else
                {
                    FirebaseResponse response = conexiune.Get($"Programari/Doctorul {Logare.doctor_name} ({P2.cnp_doooctor})/Pacienti/");
                    Dictionary<string, Programari> result = response.ResultAs<Dictionary<string, Programari>>();
                    if (result != null)
                    {

                        foreach (var get in result)
                        {
                            index++;

                            tabel.CurrentRow.Cells["Index"].Value = index.ToString();
                        };
                    }
                    else
                    {
                        MessageBox.Show("  Nu aveti conexiune la internet !");
                    }
                }

            }
            catch
            {
                MessageBox.Show("  Nu aveti conexiune la internet !");
            }
        }
        private void Lista_Programari_Load(object sender, EventArgs e)
        {
            if (Logare.cont_clinica == true)
            {
                stergere.ButtonColor = Color.MediumPurple;
                stergere.OnHoverButtonColor = Color.Purple;
            }
            tabel.ColumnHeadersDefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            tabel.RowHeadersVisible = false;
            stergere.Parent = pictureBox1;
            conexiune = new FireSharp.FirebaseClient(fb);
            try
            {
                if (Logare.cont_clinica == true)
                {
                    int index = 0;
                    FirebaseResponse response1 = conexiune.Get($"Programari/Doctorul {Lista_Doctori.nume_doctor_selectat} ({Lista_Doctori.cnp_doooctor})/Pacienti/");
                    Dictionary<string, Programari> result1 = response1.ResultAs<Dictionary<string, Programari>>();
                    if (result1 != null)
                    {
                        foreach (var get in result1)
                        {
                            index++;
                            n = get.Value.nume;
                            v = get.Value.varsta;
                            s = get.Value.sex1;
                            nr = get.Value.nr_tel;
                            p = get.Value.probleme_sanatate;
                            d = get.Value.data;
                            o = get.Value.ora;
                            c = get.Value.cnp_date_inregistrare;


                            tabel.Rows.Add(new object[] { index, c, n, v, s, nr, d, o });


                        };
                    }
                    else MessageBox.Show("  Nu aveti nicio programare !");
                }
                else
                {
                    int index = 0;

                    FirebaseResponse response = conexiune.Get($"Programari/Doctorul {Logare.doctor_name} ({P2.cnp_doooctor})/Pacienti/");
                    Dictionary<string, Programari> result = response.ResultAs<Dictionary<string, Programari>>();
                    if (result != null)
                    {

                        foreach (var get in result)
                        {
                            index++;
                            n = get.Value.nume;
                            v = get.Value.varsta;
                            s = get.Value.sex1;
                            nr = get.Value.nr_tel;
                            p = get.Value.probleme_sanatate;
                            d = get.Value.data;
                            o = get.Value.ora;
                            c = get.Value.cnp_date_inregistrare;

                            tabel.Rows.Add(new object[] { index, c, n, v, s, nr, d, o });
                        };
                    }
                    else MessageBox.Show("  Nu aveti nicio programare !");
                }
            }
            catch
            {
                MessageBox.Show("  Nu aveti conexiune la internet !");
            }

        }

        private void tabel_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (Logare.cont_clinica == false)
                {
                    FirebaseResponse response = conexiune.Get($"Programari/Doctorul {Logare.doctor_name} ({P2.cnp_doooctor})/Pacienti/");
                    Dictionary<string, Programari> result = response.ResultAs<Dictionary<string, Programari>>();
                    if (result != null)
                    {

                        foreach (var get in result)
                        {

                            c = get.Value.cnp_date_inregistrare;
                            p = get.Value.probleme_sanatate;
                            string nn;
                            try
                            {
                                nn = tabel.CurrentRow.Cells["cnp"].Value.ToString();
                                if (nn == c)
                                {
                                    descrere_probleme.Text = p;

                                }
                            }
                            catch
                            {

                            }
                        }
                    }
                }
                else
                {
                    FirebaseResponse response = conexiune.Get($"Programari/Doctorul {Lista_Doctori.nume_doctor_selectat} ({Lista_Doctori.cnp_doooctor})/Pacienti/");
                    Dictionary<string, Programari> result = response.ResultAs<Dictionary<string, Programari>>();
                    if (result != null)
                    {

                        foreach (var get in result)
                        {

                            c = get.Value.cnp_date_inregistrare;
                            p = get.Value.probleme_sanatate;
                            string nn;
                            try
                            {
                                nn = tabel.CurrentRow.Cells["cnp"].Value.ToString();
                                if (nn == c)
                                {
                                    descrere_probleme.Text = p;
                                }
                            }
                            catch
                            {

                            }
                        }
                    }
                }
            }
            catch
            {

            }

        }


    }
}
