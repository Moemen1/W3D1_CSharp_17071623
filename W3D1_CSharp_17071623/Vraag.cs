using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace W3D1_CSharp_17071623
{
    class Vraag : IEquatable<Vraag>
    {
        public int Moeilijkheidsgraad { get; set; }
        public string Tekst { get; set;}
        public string Antwoord { get; set;}
        public string Categorie { get; set; }

        public Vraag(int moeilijkheidsgraad, string tekst, string antwoord, string categorie)
        {
            if (new int[] { 1, 2, 3 }.Contains(moeilijkheidsgraad))
            {
                Moeilijkheidsgraad = moeilijkheidsgraad;
            }
            else 
            {
                Console.WriteLine("De moeilijkheidsgraad klopt niet.");
            }
            
            Tekst = tekst;
            Antwoord = antwoord;
            Categorie = categorie;
        }

        public Vraag() { }

        public bool CheckAnswer(string CorrectAntwoord)
        {
            return Antwoord == CorrectAntwoord;
        }

        public bool Equals(Vraag other)
        {
            return Categorie == other.Categorie;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Categorie);
        }

        public override string ToString()
        {
            return ($"{Tekst}"); ;
        }
    }
}
