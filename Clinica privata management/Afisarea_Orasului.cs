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
    public partial class Afisarea_Orasului : Form
    {
        public Afisarea_Orasului()
        {
            InitializeComponent();
        }
        IFirebaseConfig fb = new FirebaseConfig()
        {
            AuthSecret = "oPcsmG7DMhoxAa8Zk3jXejQYmnmsRU3whHbYLw0l",
            BasePath = "https://management-clinici-private-default-rtdb.europe-west1.firebasedatabase.app/"
        };
        IFirebaseClient conexiune;

        public static string orasul;
        private void continuare_programare1_Click(object sender, EventArgs e)
        {
            if (t1.Text.Length > 0)
            {
                try
                {
                    FirebaseResponse response = conexiune.Get("Clinici/");

                    orasul = t1.Text;
                    if (Logare.cont_clinica == false)
                    {
                        P1.pp.Controls.Clear();
                        Lista_Clinici vizualizare1 = new Lista_Clinici(); vizualizare1.TopLevel = false;
                        P1.pp.Controls.Add(vizualizare1); vizualizare1.Show();
                    }
                    else
                    {
                        P2.PP.Controls.Clear();
                        Lista_Clinici vizualizare1 = new Lista_Clinici(); vizualizare1.TopLevel = false;
                        P2.PP.Controls.Add(vizualizare1); vizualizare1.Show();
                    }
                }
                catch
                {
                    MessageBox.Show("  Nu aveti conexiune la internet !");
                }

            }
            else MessageBox.Show("  Aleveti-va orasul in care doriti sa va faceti programarea !");
        }

        private void Afisarea_Orasului_Load(object sender, EventArgs e)
        {
            conexiune = new FireSharp.FirebaseClient(fb);
            continuare_programare1.Parent = pictureBox1;

        }
    }
}
