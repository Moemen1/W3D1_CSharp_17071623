using System;

namespace W3D1_CSharp_17071623
{
    class Program
    {
        //TODO vragen fliteren op moeilijkheidsgraad dvm LINQ
        // User vraag laten kiezen
        // User antwoord input laten geven
        // Programma loopen
        
        static void Main(string[] args)
        {
            Quiz q = new Quiz();

            KeuzeVraag v1 = new KeuzeVraag(2, "In which country was the inventor of Python born?", "Netherlands", "Programmeren");
            v1.AddChoice("Netherlands", true);
            v1.AddChoice("Japan", false);
            v1.AddChoice("Egypt", false);
            v1.AddChoice("United States", false);

            KeuzeVraag v2 = new KeuzeVraag(2, "In which country was the inventor of C# born?", "Denmark", "Programmeren");
            v2.AddChoice("China", false);
            v2.AddChoice("Germany", false);
            v2.AddChoice("Switzerland", false);
            v2.AddChoice("Denmark", true);
            
            KeuzeVraag v3 = new KeuzeVraag(3, "In which country was the inventor of Java born?", "United States", "Programmeren");
            v3.AddChoice("China", false);
            v3.AddChoice("United States", true);
            v3.AddChoice("Switzerland", false);
            v3.AddChoice("Canada", false);

            KeuzeVraag v4 = new KeuzeVraag(1, "Wat is 100 + 110?", "210", "Rekenen");
            v4.AddChoice("220", false);
            v4.AddChoice("110", false);
            v4.AddChoice("120", false);
            v4.AddChoice("210", true);

            KeuzeVraag v5 = new KeuzeVraag(1, "Wat is 540 - 105?", "435", "Rekenen");
            v5.AddChoice("425", false);
            v5.AddChoice("445", false);
            v5.AddChoice("435", true);
            v5.AddChoice("425", false);

            q.AddVraag(v1); q.AddVraag(v2); q.AddVraag(v3); q.AddVraag(v4); q.AddVraag(v5); //Add alle keuzevragen            

            Console.WriteLine("Welkom bij de Quiz! \n" +
                              "Voordat we beginnen moet je filteren op categorie of moeilijkheidsgraad. \n" +
                              "Hieronder worden de diverse opties weergegeven. \n");

            while (true)
            {
                Console.WriteLine("1: Categorie \n" +
                                              "2: Moelijkheidsgraad \n" +
                                              "3: Exit \n");

                Console.Write("Waar wilt u op filteren?: ");

                int input = Int32.Parse(Console.ReadLine());

                Console.WriteLine();

                q.KiesCategorieOfMoelijkheid(input);

                if (input == 1)
                {
                    q.FilterCategorie();
                }
                else if (input == 2)
                {
                    q.FilterMoeilijkheid();
                }

                Console.WriteLine();
            }
            
        }
    }
}
