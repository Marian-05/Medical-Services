using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica_privata_management
{
     class Dpacient
    {
        public string oras_pacient { get; set; }
        public string nume { get; set; }
        public string parola { get; set; }  
        public string cnp_pacient{ get; set; }
       
    }
    
    class Ddoctor
    {
        public string nume1 { get; set; }
        public string parola1 { get; set; }
        public string specealizare { get; set; }
        public string cnp_doctor { get; set; }
        public string oras_doctor { get; set; }
       
    }
    class Clinica
    {
        public string nume_clinica { get; set; }
        public string nume_clinica_simplificat{ get; set; }
        public string parola_clinica { get; set; }
        public string oras_clinica { get; set; }
        public string strada_clinica { get; set; }
       

    }
    class Programari {
        
        public string nume { get; set; }
        public string varsta { get; set; }
        public string sex1 { get; set; }
        public string nr_tel { get; set; }
        public string probleme_sanatate { get; set; }
        public string data { get; set; }
        public string ora { get; set; }
        public string cnp_date_inregistrare { get; set; }
        public string oras_programare { get; set; }

    }
    class Nr_Pacienti
    {
        public int numar_pacienti { get; set; }
    }


}
