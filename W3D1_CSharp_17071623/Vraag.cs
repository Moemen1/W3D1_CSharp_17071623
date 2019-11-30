using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace W3D1_CSharp_17071623
{
    class Vraag
    {
        public int Moeilijkheidsgraad { get; set; }
        public string Tekst { get; set;}
        public string Antwoord { get; set;}

        public Vraag(int moeilijkheidsgraad, string tekst, string antwoord)
        {
            if (new int[] { 1, 2, 3 }.Contains(moeilijkheidsgraad))
            {
                Moeilijkheidsgraad = moeilijkheidsgraad;
            }
            else 
            {
                Console.WriteLine("De moeilijkheidsgraad van de vraag klopt niet.");
            }
            
            Tekst = tekst;
            Antwoord = antwoord;
        }

        public Vraag() { }

        public bool CheckAnswer(string CorrectAntwoord)
        {
            return Antwoord == CorrectAntwoord;
        }

    }
}
