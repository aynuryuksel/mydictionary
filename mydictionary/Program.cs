using System;

namespace mydictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Mydictionary<int, string> personelListesi = new Mydictionary<int, string>();
            personelListesi.Add(0, "Aynur Yüksel");
            personelListesi.Add(1, "Hakan Caymaz");
          
        }
    }
}
