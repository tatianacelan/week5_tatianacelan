using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week5_tatianacelan
{
    public static class Menu
    {
        internal static void Start()
        {
            bool exit = true;

            do
            {
                Console.WriteLine();
                Console.WriteLine("\nAdesso sei nel Menu. Scegli una opzione: " +
                "\n  1- Prenota un esame " +
                "\n  2- Verbalizza un esame prenotato" +
                "\n  Q- Uscire" +
                "\n");

            char choice = Console.ReadKey().KeyChar;

            switch (choice)
            {
                case '1':
                        Console.WriteLine("desideri prenotare un esame.");
                        PrenotaEsame();

                    break;
                case '2':

                    break;
                case 'Q':
                    exit = false;
                    Console.WriteLine("alla prossima!");
                    break;
            }
        } while (exit);
    }

        private static void PrenotaEsame()
        {
            Console.WriteLine("per prenotare un esame inserisci la tua matricola");

            int matricola;
            string cdl=null;
           
            Console.WriteLine("(TODO: per alessandra) ho queste matricole: 101, 102 ,103 ");

            do
            {
                Console.WriteLine("Inserisci la tua matricola: ");
            

            } while (!int.TryParse(Console.ReadLine(), out matricola));


            Studente matr = GestioneEsami.VerificaEsistenza(matricola);

            // se ok fai vedere lista dei corsi che puo prenotare 
            if (matr != null)
            {
                //string nome;
                //string cognome;
                //GestioneEsami.StampaDati(matr);
              
                //Console.WriteLine($"ciao {matr} ");


                // inserisci Cdl 
                Console.WriteLine("inserisci il tuo cdl");
     
                Console.WriteLine("TODO:ho L-9, L-10 , LM-1 ");

               cdl = Console.ReadLine();
        
                Console.WriteLine(" Questa e la lista degli esami presenti nel tuo CDL:");
                Console.WriteLine();

                //metodo per far vedere esami a studente inscritto a un certo cdl

                GestioneEsami.StampaEsamiPerCDL(cdl);

                //Console.WriteLine("Scegli l'esame che vuoi prenotare!");
                //Console.WriteLine();
                //Console.WriteLine("Inserisci codice corso tra quelli sopra..");
                //int codInserito = int.Parse(Console.ReadLine());

                //Console.WriteLine(+codInserito);

            }

            else
            {
                Console.WriteLine("Non esiste una matricola con questo codice");
            }

            Console.WriteLine("Inserisci codice corso tra quelli sopra..");
            int codInserito = int.Parse(Console.ReadLine());

            Console.WriteLine($" il codice da te inserito e :" + codInserito);  


            GestioneEsami.VerificaCorettezza(codInserito, matr, cdl);

           




        }


    }
}

