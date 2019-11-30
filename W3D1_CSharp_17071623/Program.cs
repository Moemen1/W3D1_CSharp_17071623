using System;

namespace W3D1_CSharp_17071623
{
    class Program
    {
        static void Main(string[] args)
        {
            Vraag v2 = new Vraag
            {
                Moeilijkheidsgraad = 1,
                Tekst = "Wat is 10 + 10?",
                Antwoord = "20"
            };

            Console.WriteLine($"{v2.Tekst}");
            Console.WriteLine(v2.CheckAnswer(Console.ReadLine()));
        }
    }
}
