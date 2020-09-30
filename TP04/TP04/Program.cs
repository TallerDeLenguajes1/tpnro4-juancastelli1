using System;

namespace TP04
{
    class Program
    {
        static void Main(string[] args)
        {
            int cadnum;
            Cadeteria CadetSpeed = new Cadeteria("CadetSpeed");
            Console.WriteLine("Cuantos cadetes quiere crear?");
            cadnum = int.Parse(Console.ReadLine());
            Helper.CrearCadetes(cadnum, CadetSpeed);
            CadetSpeed.informecadetescompleto();
            Console.WriteLine("Toque cualquier tecla para finalizar");
            Console.ReadKey();
        }
    }
}
