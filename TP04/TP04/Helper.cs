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
        public static bool boolaleatorio()
        {
            return (rnd.Next(2)== 1);
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
                Cliente cli = new Cliente(cont, Helper.nombrealeat(), " ", Helper.aleatorio(3810000000, 3819999999));
                Pedido ped = new Pedido(cont, " ", cli, (estado)Helper.aleatorio(4), (tipoped)Helper.aleatorio(3), Helper.boolaleatorio());
                cli.Pedidos.Add(ped);
                pedidos.Add(ped);
                cont = cont + 1;
            }
            return pedidos;
        }
        public static List<Pedido> CrearPedidosEco(int pednum, int cont)
        {
            List<Pedido> pedidos = new List<Pedido>();
            for (int l = 0; l < pednum; l++)
            {
                Cliente cli = new Cliente(cont, Helper.nombrealeat(), " ", Helper.aleatorio(3810000000, 3819999999));
                Pedido ped = new Pedido(cont, " ", cli, (estado)Helper.aleatorio(4), tipoped.Ecologico, Helper.boolaleatorio());
                cli.Pedidos.Add(ped);
                pedidos.Add(ped);
                cont = cont + 1;
            }
            return pedidos;
        }
        public static List<Pedido> CrearPedidosExp(int pednum, int cont)
        {
            List<Pedido> pedidos = new List<Pedido>();
            for (int l = 0; l < pednum; l++)
            {
                Cliente cli = new Cliente(cont, Helper.nombrealeat(), " ", Helper.aleatorio(3810000000, 3819999999));
                Pedido ped = new Pedido(cont, " ", cli, (estado)Helper.aleatorio(4), tipoped.Express, Helper.boolaleatorio());
                cli.Pedidos.Add(ped);
                pedidos.Add(ped);
                cont = cont + 1;
            }
            return pedidos;
        }
        public static List<Pedido> CrearPedidosDeli(int pednum, int cont)
        {
            List<Pedido> pedidos = new List<Pedido>();
            for (int l = 0; l < pednum; l++)
            {
                Cliente cli = new Cliente(cont, Helper.nombrealeat(), " ", Helper.aleatorio(3810000000, 3819999999));
                Pedido ped = new Pedido(cont, " ", cli, (estado)Helper.aleatorio(4), tipoped.Delicado, Helper.boolaleatorio());
                cli.Pedidos.Add(ped);
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
                cadet.Cadetes.Add(new Cadete(i, Helper.nombrealeat(), " ", Helper.aleatorio(3810000000, 3819999999),(Vehiculo)Helper.aleatorio(3)));
                Console.WriteLine("Cuantos pedidos quiere crear para cadete " + i + "?");
                int pednum = int.Parse(Console.ReadLine());
                switch (cadet.Cadetes[i].Vehi) 
                {
                    case Vehiculo.Bicicleta:
                        cadet.Cadetes[i].Pedidos.AddRange(CrearPedidosEco(pednum, cont));
                        break;
                    case Vehiculo.Auto:
                        cadet.Cadetes[i].Pedidos.AddRange(CrearPedidosDeli(pednum, cont));
                        break;
                    case Vehiculo.Moto:
                        cadet.Cadetes[i].Pedidos.AddRange(CrearPedidosExp(pednum, cont));
                        break;
                }
                cont = cont + pednum;
            }
        }
    }
}
