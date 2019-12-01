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
            int i = 1;

            if (input == 1)
            {
                foreach (Vraag v in VragenList.Distinct())
                {
                    Console.WriteLine($"{i}: {v.Categorie}");
                    i++;
                }

                Console.WriteLine();
            }
            else if (input == 2)
            {
                Console.WriteLine($"Moelijkheidsgraad: 1, 2, 3 \n");
            }
            else
            {
                Console.WriteLine("Deze optie bestaat niet. \n");
            }
        }

        public void FilterMoeilijkheid()
        {
            Console.Write("Op welke moeilijkheidsgraad wilt u vragen krijgen?: ");
            int input = Int32.Parse(Console.ReadLine());
            Console.WriteLine();

            var vragenBijInput = from v in VragenList
                where v.Moeilijkheidsgraad == input
                select v;

            int i = 1;
            foreach (Vraag v in vragenBijInput)
            {
                Console.WriteLine($"{i}: {v}");
                i++;
            }

            Kiesvraag(vragenBijInput, i);
        }

        public void FilterCategorie()
        {
            Console.Write("Op welke categorie wilt u vragen krijgen? \n" +
                          "Typ de categorie in: ");
            string input = Console.ReadLine();
            Console.WriteLine();

            var vragenBijInput = from v in VragenList
                where v.Categorie.ToLowerInvariant() == input.ToLowerInvariant()
                select v;

            int i = 1;
            foreach (Vraag v in vragenBijInput)
            {
                Console.WriteLine($"{i}: {v}");
                i++;
            }

            Kiesvraag(vragenBijInput, i);
        }

        public void Kiesvraag(IEnumerable<Vraag> vragenBijInput, int i)
        {
            Console.WriteLine();
            Console.Write("Kies een vraag: ");
            int input = Int32.Parse(Console.ReadLine());

            Vraag gekozenVraag = null;

            foreach (Vraag v in vragenBijInput)
            {
                if(input == i)
                    Console.WriteLine(v);

                gekozenVraag = v;
            }

            Console.Write("Jouw antwoord: ");
            string antwoord = Console.ReadLine();
            Console.WriteLine(gekozenVraag.CheckAnswer(antwoord));
        }

    }
}
