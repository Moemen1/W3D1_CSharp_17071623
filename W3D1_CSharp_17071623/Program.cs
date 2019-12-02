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

            q.AddVraag(new Vraag(1, "Wat is 100 + 110?", "210", "Rekenen"));
            q.AddVraag(new Vraag(1, "Wat is 540 - 105?", "435", "Rekenen"));
            q.AddVraag(new Vraag(2, "In which country was the inventor of Python born?", "Netherlands", "Programmeren"));
            q.AddVraag(new Vraag(2, "In which country was the inventor of C# born?", "Denmark", "Programmeren"));
            q.AddVraag(new Vraag(3, "In which country was the inventor of Java born?", "United States", "Programmeren"));

            Console.WriteLine("Welkom bij de Quiz! \n" +
                              "Voordat we beginnen moet je filteren op categorie of moeilijkheidsgraad. \n" +
                              "Hieronder worden de diverse opties weergegeven. \n");

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
        }
    }
}
