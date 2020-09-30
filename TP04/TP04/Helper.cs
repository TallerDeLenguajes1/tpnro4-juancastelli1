using System;
using System.Collections.Generic;
using System.Text;

namespace TP04
{
    class Helper
    {

        public static string[] nombres = { "Juan ", "Jorge ", "Cristiano ", "Eduardo ", "Luciano " };
        public static string[] apes = { "Castelli", "Paz", "Roseda", "Carabajal", "Ronaldo" };
        static Random rnd = new Random();
        public static int aleatorio(int hasta)
        {
            return rnd.Next(hasta);
        }
        public static int aleatorio(int desde, int hasta)
        {
            return rnd.Next(desde, hasta);
        }
        public static int aleatorio(uint desde, uint hasta)
        {
            return rnd.Next((int)desde, (int)hasta);
        }
        public static string nombrealeat()
        {
            return (nombres[Helper.aleatorio(4)] + apes[Helper.aleatorio(4)]);
        }
        public static List<Pedido> CrearPedidos(int pednum, int cont)
        {
            List<Pedido> pedidos = new List<Pedido>();
            for (int l = 0; l < pednum; l++)
            {
                Pedido ped = new Pedido(cont, " ", cont, Helper.nombrealeat(), " ", Helper.aleatorio(3810000000, 3819999999), (estado)Helper.aleatorio(4));
                pedidos.Add(ped);
                cont = cont + 1;
            }
            return pedidos;
        }
        public static void CrearCadetes(int num, Cadeteria cadet)
        {
            int cont = 0;
            for (int i = 0; i < num; i++)
            {
                cadet.Cadetes.Add(new Cadete(i, Helper.nombrealeat(), " ", Helper.aleatorio(3810000000, 3819999999)));
                Console.WriteLine("Cuantos pedidos quiere crear para cadete " + i + "?");
                int pednum = int.Parse(Console.ReadLine());
                cadet.Cadetes[i].Pedidos.AddRange(CrearPedidos(pednum, cont));
                cont = cont + pednum;
            }
        }
    }
}
