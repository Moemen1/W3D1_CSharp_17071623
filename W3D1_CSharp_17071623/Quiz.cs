using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace W3D1_CSharp_17071623
{
    class Quiz
    {
        List<Vraag> VragenList = new List<Vraag>();   

        public void AddVraag(Vraag v)
        {
            VragenList.Add(v);
        }

        public void KiesCategorieOfMoelijkheid(int input)
        {          
            if (input == 1)
            {
                int i = 1;

                foreach (Vraag v in VragenList.Distinct())
                {
                    Console.WriteLine($"{i}: {v.Categorie}");
                    i++;
                }

                Console.WriteLine();
            }
            else if (input == 2)
            {
                Console.WriteLine("Moelijkheidsgraad: 1, 2, 3 \n");
            }
            else { Environment.Exit(0); }      
        }

        public void FilterMoeilijkheid()
        {
            Console.Write("Op welke moeilijkheidsgraad wilt u vragen krijgen?: ");
            int input = Int32.Parse(Console.ReadLine());
            Console.WriteLine();

            //LINQ filter op moeilijkheid
            var vragenBijMoeilijkheid = VragenList.Where(v => v.Moeilijkheidsgraad == input).ToList();         

            int i = 1;
            foreach (Vraag v in vragenBijMoeilijkheid)
            {
                Console.WriteLine($"{i}: {v}");
                i++;
            }            

            KiesVraag(vragenBijMoeilijkheid);
        }

        public void FilterCategorie()
        {
            Console.Write("Op welke categorie wilt u vragen krijgen? \n" +
                          "Typ de categorie in: ");
            string input = Console.ReadLine();
            Console.WriteLine();

            //LINQ filter op categorie
            var vragenBijCategorie = VragenList.Where(v => v.Categorie.ToLower() == input.ToLower()).ToList();           

            int i = 1;
            foreach (Vraag v in vragenBijCategorie)
            {
                Console.WriteLine($"{i}: {v}");
                i++;
            }

            KiesVraag(vragenBijCategorie);
        }

        public void KiesVraag(List<Vraag> vragenBijInput)
        {
            Console.WriteLine();
            Console.Write("Kies een vraag: ");
            int input = Int32.Parse(Console.ReadLine());

            Vraag gekozenVraag = vragenBijInput[input - 1];

            Console.Write("Jouw antwoord: ");
            string antwoord = Console.ReadLine();

            Console.WriteLine("Het antwoord is: " + gekozenVraag.CheckAnswer(antwoord));
        }      
    }
}
