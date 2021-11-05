using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week5_tatianacelan
{
  public class Studente
    {
        public int Matricola { get; set; }
        public string NomeS { get; set; }
        public string CognomeS { get; set; }
        public DateTime AnnoNascitaS { get; set; }
        public bool RichiestaLaureaS { get; set; }
        public int CfuAccumulatiS { get; set; }
      
        public List<Esame> esamiStudente = new List<Esame>();
        public string LaureaCodiceCDL { get; set; }

    }

 

}
