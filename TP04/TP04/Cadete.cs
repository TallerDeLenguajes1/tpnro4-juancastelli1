using System;
using System.Collections.Generic;
using System.Text;

namespace TP04
{
    class Cadete : Persona
    {
        int idCadete;
        List<Pedido> pedidos;

        public Cadete(int idCadete, string nombre, string direccion, int telefono) : base(nombre,direccion, telefono)
        {
            this.idCadete = idCadete;
            this.pedidos = new List<Pedido>();
        }

        public int IdCadete { get => idCadete; set => idCadete = value; }
        internal List<Pedido> Pedidos { get => pedidos; set => pedidos = value; }

        public int cantidadPedidosE()
        {
            int pedidosent = 0;
            foreach (Pedido ped in pedidos)
            {
                if (ped.Est == estado.Entregado)
                {
                    pedidosent = pedidosent + 1;
                }
            }
            return pedidosent;
        }
        public int jornalacobrar()
        {
            return (this.cantidadPedidosE()) * 100;
        }
        public void informe()
        {
            Console.Write("Cadete numero" + idCadete + "\n");
            Console.Write("nombre:" + Nombre + "\n");
            Console.Write("Cantidad pedidos entregados:" + this.cantidadPedidosE() + "\n");
            Console.Write("jornal:" + this.jornalacobrar() + "\n" + "\n" + "\n");
        }
        public double promedioentregados()
        {
            return (double)this.cantidadPedidosE() / (double)this.pedidos.Count;
        }
        public void pedidosdecadete()
        {
            Console.WriteLine("Pedidos Del Cadete " + this.Nombre + "\n");
            foreach (Pedido ped in pedidos)
            {
                Console.WriteLine("Nropedido:" + ped.IdPedido + "\n");
                Console.WriteLine("Cliente:" + ped.Cli.Nombre + "\n");
                Console.WriteLine("Direccion:" + ped.Cli.Direccion + "\n");
                Console.WriteLine("Estado:" + ped.Est + "\n");
                Console.WriteLine("\n \n");
            }
        }
    }
}
