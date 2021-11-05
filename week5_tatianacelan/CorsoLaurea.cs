using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week5_tatianacelan
{
  public  class CorsoLaurea
    {
        public string CodiceCDL { get; set; }
        public string NomeCDL { get; set; }
        public int AnniCDL { get; set; }
        public int CfuCDL { get; set; }

    
        public List<CorsoAssociato>  ListaCorsiAssociatiLaurea = new List<CorsoAssociato>();

        public List<Studente> StudentiInscrittiCdl  = new List<Studente>();



    } 
}
