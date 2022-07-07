using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica_privata_management
{
    public partial class Form1 : System.Windows.Forms.Form
    { public static  Panel panel;
        int intrare1 = 0;
        public Form1()
        {
            InitializeComponent();
            panel = p;
            if (intrare1 == 0)
            {
                Loading loading = new Loading();
                loading.TopLevel = false;
                p.Controls.Add(loading);
                loading.Show();intrare1 = 1;
            }
        }

    }
}
