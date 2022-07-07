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
    public partial class Alegere_oras : Form
    {
        public static string nume_oras;
        public Alegere_oras()
        {
            InitializeComponent();
        }
        IFirebaseConfig fb = new FirebaseConfig()
        {
            AuthSecret = "oPcsmG7DMhoxAa8Zk3jXejQYmnmsRU3whHbYLw0l",
            BasePath = "https://management-clinici-private-default-rtdb.europe-west1.firebasedatabase.app/"
        };
        IFirebaseClient conexiune;
       private void Alegere_oras_Load(object sender, EventArgs e)
        {
            conexiune = new FireSharp.FirebaseClient(fb);
           
        }

        private void nume_orasului_Click(object sender, EventArgs e)
        {
         
            {
                if (numeorase.Text.Length > 0)
                {

                    
                    nume_oras = numeorase.Text;
                   
                    MessageBox.Show(" Inregistrare orasului " + numeorase.Text + " a fost efectuata !");
                    if (Logare.verificare_doctor == true)
                    {
                        Form1.panel.Controls.Clear();

                        InregistrareDoctor inregistrareDoctor = new InregistrareDoctor();
                        inregistrareDoctor.TopLevel = false;
                        Form1.panel.Controls.Add(inregistrareDoctor);
                        inregistrareDoctor.Show();
                    }
                    if(Logare.verificare_clinica == true)
                    {
                        Form1.panel.Controls.Clear();
                      
                        CreareClinica cc = new CreareClinica();
                        cc.TopLevel = false;
                        Form1.panel.Controls.Add(cc);
                        cc.Show();

                    }

                }

                else MessageBox.Show("  Alegeti-va orasul !");
            }
           
        }

        private void button_WOC2_Click(object sender, EventArgs e)
        {
            Form1.panel.Controls.Clear();
            if (Logare.verificare_clinica == false)
            {
                Alegere_specialitate alegere_Specialitate = new Alegere_specialitate();
                alegere_Specialitate.TopLevel = false;
                Form1.panel.Controls.Add(alegere_Specialitate);
                alegere_Specialitate.Show();
            }
            else if(Logare.verificare_clinica == true )
            {
                Logare logare   =new Logare();
                logare.TopLevel = false;
                Form1.panel.Controls.Add(logare);
                logare.Show();
            }
        }
    }
}
