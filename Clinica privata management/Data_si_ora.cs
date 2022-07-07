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
    public partial class Data_si_ora : Form
    {
        public Data_si_ora()
        {
            InitializeComponent();
        }
        IFirebaseConfig fb = new FirebaseConfig()
        {
            AuthSecret = "oPcsmG7DMhoxAa8Zk3jXejQYmnmsRU3whHbYLw0l",
            BasePath = "https://management-clinici-private-default-rtdb.europe-west1.firebasedatabase.app/"
        };
        IFirebaseClient conexiune;

        private void Data_si_ora_Load(object sender, EventArgs e)
        {
            calendar.Value = DateTime.Now;
            if (Logare.cont_clinica == true)
            {
                CC.ButtonColor = Color.MediumPurple;
                CC.OnHoverButtonColor = Color.Purple;
            }
            inapoi.Parent = fundal;
            CC.Parent = fundal;
            Afisare_ora_programare.Parent = fundal;
            conexiune = new FireSharp.FirebaseClient(fb);

        }

        private void CC_Click(object sender, EventArgs e)
        {
            try
            {

                if (ora_programare.Text.Length > 0)
                {
                    Programari programari = new Programari()
                    {
                        nume = Logare.Nume,
                        varsta = Date_Pacient.varsta_pt_data_si_ora,
                        nr_tel = Date_Pacient.nr_tel_pt_data_si_ora,
                        probleme_sanatate = Date_Pacient.probleme_de_sanatate_pt_data_si_ora,
                        data = calendar.Text,
                        ora = ora_programare.Text,
                        sex1 = Date_Pacient.sex_pt_data_si_ora,
                        cnp_date_inregistrare = Logare.cnppacient,
                        oras_programare = Afisarea_Orasului.orasul
                    };

                    var setter1 = conexiune.Set($"Programari/Doctorul {Lista_Doctori.nume_doctor_selectat} ({Lista_Doctori.cnp_doooctor})/Pacienti/{Logare.Nume} ({Logare.cnppacient})/", programari);
                    MessageBox.Show("Programare finalizata !");
                    if (Logare.cont_clinica == false)
                    {
                        P1.pp.Controls.RemoveAt(0);

                        Home1 home1 = new Home1(); home1.TopLevel = false;
                        P1.pp.Controls.Add(home1);
                        home1.Show();
                        P1.button_acasa.BackColor = Color.Green;
                        P1.buton_incepere_inregistrare.BackColor = Color.Transparent;
                    }
                    else
                    {
                        P2.PP.Controls.RemoveAt(0);
                        Home1 home1 = new Home1(); home1.TopLevel = false;
                        P2.PP.Controls.Add(home1);
                        home1.Show();
                        P2.b_acasa.BackColor = Color.Green;
                        P2.b_programare.BackColor = Color.Transparent;

                    }
                }
                else
                {
                    MessageBox.Show("  Alegeti-va ora programarii !");
                }
            }
            catch
            {
                MessageBox.Show("  Nu aveti conexiune la internet !");
            }
        }

        private void calendar_ValueChanged(object sender, EventArgs e)
        {

            if (calendar.Value >= DateTime.Now)
            {
                if (calendar.Text.Contains("duminică"))
                {
                    MessageBox.Show("  Duminica nu se fac programari !");
                    calendar.Value = DateTime.Now;
                }
                else if (calendar.Text.Contains("sâmbătă"))
                {
                    MessageBox.Show("  Sâmbăta nu se fac programari ! ");
                    calendar.Value = DateTime.Now;
                }
            }
            else
            {
                MessageBox.Show("  Nu puteti face programari in trecut !");
                calendar.Value = DateTime.Now;
            }
        }

        string ora;
        bool ok;
        private void Afisare_ora_programare_Click(object sender, EventArgs e)
        {
            calendar.Format = DateTimePickerFormat.Custom;
            calendar.CustomFormat = "dd-MM-yyyy";
            if (calendar.Value >= DateTime.Now)
            {
                ora_programare.Items.Clear();
                int min = 0;
                for (int h = 8; h <= 15; h++)
                {
                    min = 0;
                    for (int j = 1; j <= 2; j++)
                    {
                        ora = $"{h}:{min}0";
                        if (h != 12)
                        {
                            FirebaseResponse response = conexiune.Get($"Programari/Doctorul {Lista_Doctori.nume_doctor_selectat} ({Lista_Doctori.cnp_doooctor})/Pacienti/");
                            Dictionary<string, Programari> result1 = response.ResultAs<Dictionary<string, Programari>>();

                            if (result1 != null)
                            {
                                ok = true;
                                foreach (var get in result1)
                                {
                                    min = 0;
                                    if (get.Value.data == calendar.Text)
                                    {
                                        if (get.Value.ora == ora)
                                        {
                                            ok = false;

                                        }
                                    }
                                }
                                if (ok == true)
                                {
                                    ora_programare.Items.Add(ora);
                                }

                                min += 3;
                            }
                            else
                            {
                                ora_programare.Items.Add(ora);
                                min += 3;
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("  Nu puteti face programari in trecut !");
            }
        }

        private void inapoi_Click(object sender, EventArgs e)
        {
            Date_Pacient date_Pacient = new Date_Pacient();
            date_Pacient.TopLevel = false;
            if (Logare.cont_clinica == true)
            {
                P2.PP.Controls.Clear();

                P2.PP.Controls.Add(date_Pacient);
            }
            else
            {
                P1.pp.Controls.Clear();
                P1.pp.Controls.Add(date_Pacient);
            }
            date_Pacient.Show();
        }
    }
}
