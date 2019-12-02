using System;
using System.Collections.Generic;
using System.Text;

namespace W3D1_CSharp_17071623
{
    class KeuzeVraag : Vraag
    {
        public List<String> KeuzeList;


        public KeuzeVraag(int moeilijkheidsgraad, string tekst, string antwoord, string categorie) : base(moeilijkheidsgraad, tekst, antwoord, categorie)
        {
            KeuzeList = new List<string>();
        }

        public void AddChoice(string keuze, bool correct)
        {

            KeuzeList.Add(keuze);

            if (correct)
            {
                String keuzeString = "" + KeuzeList.Count;
                Antwoord = keuzeString;
            }
        }

        public void Display()
        {
            int i = 1;
            foreach (string keuze in KeuzeList)
            {
                Console.WriteLine($"{i}: {keuze}");
                i++;
            }
        }
    }
}
