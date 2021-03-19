using System;
using ClasseBatiment.Classes;

namespace ClasseBatiment
{
    class Program
    {
        static void Main(string[] args)
        {
            Batiment Batiment1 = new Batiment("96 rue Jacques Cartier");
            Console.WriteLine(Batiment1);

            Maison Maison1 = new Maison("14 Adams", 4);
            Console.WriteLine(Maison1);

            Entrepot Entrepot1 = new Entrepot("476 rue Mainville", "Bois", 345);
            Console.WriteLine(Entrepot1);
        }
    }
}
