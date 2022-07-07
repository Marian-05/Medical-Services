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
    public partial class Lista_Clinici : System.Windows.Forms.Form
    {
        public Lista_Clinici()
        {
            InitializeComponent();
        }
        public static IFirebaseConfig fb = new FirebaseConfig()
        {
            AuthSecret = "oPcsmG7DMhoxAa8Zk3jXejQYmnmsRU3whHbYLw0l",
            BasePath = "https://management-clinici-private-default-rtdb.europe-west1.firebasedatabase.app/"
        };
        public static IFirebaseClient conexiune;


        int conexiune_internet = 1;

        public static string nume_clinica_selectata;

        private void Lista_Clinici_Load(object sender, EventArgs e)
        {
            tabel_clinici.RowHeadersVisible = false;
            tabel_clinici.Parent = pictureBox1;
            inapoi.Parent = pictureBox1;
            tabel_clinici.ColumnHeadersDefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            conexiune = new FireSharp.FirebaseClient(fb);
            try
            {
                FirebaseResponse response = conexiune.Get("Clinici/");
                Dictionary<string, Clinica> result = response.ResultAs<Dictionary<string, Clinica>>();
                if (result != null)
                {
                    bool afisare_clinici = false;

                    foreach (var get in result)
                    {
                        int nr_d = 0;

                        string nnn1 = get.Value.oras_clinica;
                        if (nnn1 == Afisarea_Orasului.orasul)
                        {
                            afisare_clinici = true;

                            string nc = get.Value.nume_clinica;

                            tabel_clinici.Rows.Add(new object[] { nc, nr_d });
                        }
                    }
                    if (afisare_clinici == false)
                    {
                        MessageBox.Show("Nu a fost creata nicio clinica pana acum !");
                    }
                }
                else
                {
                    MessageBox.Show("  Nu a fost creata nicio clinica !");
                }
            }
            catch
            {
                conexiune_internet = 0;
                MessageBox.Show("  Nu aveti conexiune la internet !");

            }
        }

        private void tabel_clinici_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (conexiune_internet == 1)
            {
                if (tabel_clinici.CurrentRow.Cells[0].Value != null)
                {
                    nume_clinica_selectata = tabel_clinici.CurrentRow.Cells[0].Value.ToString();
                    if (Logare.cont_clinica == false)
                    {
                        P1.pp.Controls.RemoveAt(0);
                        Lista_Doctori l_d = new Lista_Doctori();
                        l_d.TopLevel = false;
                        P1.pp.Controls.Add(l_d);
                        l_d.Show();
                    }

                }
                else MessageBox.Show("  Nu a fost creatat nicio clinica !");
            }
        }

        private void inapoi_Click(object sender, EventArgs e)
        {
            P1.pp.Controls.Clear();
            Afisarea_Orasului afisarea_Orasului = new Afisarea_Orasului();
            afisarea_Orasului.TopLevel = false;
            P1.pp.Controls.Add(afisarea_Orasului);
            afisarea_Orasului.Show();
        }
    }
}
