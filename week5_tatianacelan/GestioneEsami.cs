using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week5_tatianacelan
{
    public static class GestioneEsami
    {
        public static List<CorsoLaurea> corsiLaurea = new List<CorsoLaurea>()
        {
            new CorsoLaurea{ CodiceCDL="L-9", NomeCDL="ing.meccanica", AnniCDL=3, CfuCDL=180 },
            new CorsoLaurea{ CodiceCDL="L-10", NomeCDL="ing.informatica", AnniCDL=3, CfuCDL=180 },
            new CorsoLaurea{ CodiceCDL="LM-1", NomeCDL="fisica", AnniCDL=2, CfuCDL=120 }

         };
        public static List<CorsoAssociato> corsiAssociati = new List<CorsoAssociato>()
        {  
            new CorsoAssociato{ IdCorso=1, NomeCorso="informatica", CfuCorso=120, LaureaCodiceCDL="L-10" },
            new CorsoAssociato{ IdCorso=2, NomeCorso="informatica2", CfuCorso=50, LaureaCodiceCDL="L-10" },
            new CorsoAssociato{ IdCorso=3, NomeCorso="informatica3", CfuCorso=10, LaureaCodiceCDL="L-10" },
            new CorsoAssociato{ IdCorso=4, NomeCorso="informatica4", CfuCorso=60, LaureaCodiceCDL="L-10" },
            new CorsoAssociato{ IdCorso=5, NomeCorso="costruzioni", CfuCorso=120, LaureaCodiceCDL="L-9" },
            new CorsoAssociato{ IdCorso=6, NomeCorso="impianti industriali", CfuCorso=120, LaureaCodiceCDL="L-9" },
            new CorsoAssociato{ IdCorso=7, NomeCorso="macchine", CfuCorso=10, LaureaCodiceCDL="L-9" },
            new CorsoAssociato{ IdCorso=8, NomeCorso="fisica A", CfuCorso=100, LaureaCodiceCDL="LM-1" },
            new CorsoAssociato{ IdCorso=9, NomeCorso="fisica B", CfuCorso=70, LaureaCodiceCDL="LM-1" },
            new CorsoAssociato{ IdCorso=10, NomeCorso="fisica C", CfuCorso=20, LaureaCodiceCDL="LM-1" },
        };

        internal static void StampaDati(Studente matr)
        {
            foreach (Studente s in studenti)
            {
                
               
            }
        }

        public static List<Studente> studenti = new List<Studente>()
        {  new Studente{ Matricola=101, NomeS="Elisa", CognomeS="Baglioni", AnnoNascitaS= new DateTime(1998-02-01), RichiestaLaureaS=false, CfuAccumulatiS=0, LaureaCodiceCDL="L-9"},
           new Studente{ Matricola=102, NomeS="Andrea", CognomeS="Ciocca", AnnoNascitaS=new DateTime(1998,02,01), RichiestaLaureaS=false, CfuAccumulatiS=0, LaureaCodiceCDL="L-10"},
           new Studente{ Matricola=101, NomeS="Federico", CognomeS="Granocchia", AnnoNascitaS= new DateTime(1995,02,01), RichiestaLaureaS=false, CfuAccumulatiS=0, LaureaCodiceCDL="LM-1"},

        };

        internal static void StampaEsamiPerCDL(string cdl)
        {
            foreach (CorsoAssociato ca in corsiAssociati)
                if (ca.LaureaCodiceCDL == cdl)
                {
                    Console.WriteLine($"Codice corso:{ ca.IdCorso} Nome Corso:{ ca.NomeCorso}");
                }


        }

        internal static Studente VerificaEsistenza(int matricola)
        {
            foreach (Studente s in studenti)
            {
                if (s.Matricola == matricola)
                {
                    return s;
                }
            }

            return null;
        }

      
        internal static void VerificaCorettezza(int codInserito, Studente matr, string cdl)
        {

            // qui faccio controllo che il codice giusto
            // se richiesta laurea e falso vai avanti , alrtimenti hai finito gli esami!
            DomandaLaurea();
           
            // 
            foreach (CorsoAssociato ca in corsiAssociati)
            {
                //if (ca.IdCorso != codInserito) // se non esiste questo corso
                //{
                //    Console.WriteLine("\n Non esiste un corso con questo codice ");
                //}

                if
                  (( ca.IdCorso==codInserito) && (ca.LaureaCodiceCDL!= cdl))   // se un esame non del suo corso--
                {
                    Console.WriteLine("\n  Questo esame non fa parte del tuo corso");
                 }

            

                else if ((ca.IdCorso == codInserito) && (ca.LaureaCodiceCDL == cdl))
                {
                    // se ok, verifico se e stao gia sostenuto o i crediti 
                    //1. se gia sostenuto - oppure 
                    // 2. se tropi crediti per raggiungere laurea--

                     Console.WriteLine("\n  Questo esame e valido per la scelta. ma prima verifico se puoi sostenerlo ");
                     

                    //  alla fine 
                    // Console.WriteLine("\n  Esame prenotato corretamente. ");

                    // aggiungo esame ad una lista esami prenotati 
                    //  AggiungoEsamePrenotato();



                }

            }
             }

        private static void DomandaLaurea()
        {

            // qui verifico se ha raggiunto il numero  di cfu previsto per cdl
          //  CalcolaCfu();
        }


       
    }
   }
    

       

    

