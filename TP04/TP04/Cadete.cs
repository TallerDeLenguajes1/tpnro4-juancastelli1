using System;
using System.Collections.Generic;
using System.Text;

namespace TP04
{
    public enum Vehiculo {Bicicleta, Auto, Moto }
    class Cadete : Persona
    {
        int idCadete;
        List<Pedido> pedidos;
        Vehiculo vehi;

        public Cadete(int idCadete, string nombre, string direccion, int telefono, Vehiculo vehi) : base(nombre,direccion, telefono)
        {
            this.idCadete = idCadete;
            this.pedidos = new List<Pedido>();
            this.Vehi = vehi;
        }

        public int IdCadete { get => idCadete; set => idCadete = value; }
        internal List<Pedido> Pedidos { get => pedidos; set => pedidos = value; }
        public Vehiculo Vehi { get => vehi; set => vehi = value; }

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
        public double jornalacobrar()
        {
            double aumento = 0;
            switch (this.Vehi)
            {
                case Vehiculo.Bicicleta:
                    aumento = 1.05;
                    break;
                case Vehiculo.Moto:
                    aumento = 1.2;
                    break;
                case Vehiculo.Auto:
                    aumento = 1.25;
                    break;
            }
            return ((this.cantidadPedidosE()) * 100)*aumento;
        }
        public void informe()
        {
            Console.Write("Cadete numero" + idCadete + "\n");
            Console.Write("nombre:" + Nombre + "\n");
            Console.Write("Cantidad pedidos entregados:" + this.cantidadPedidosE() + "\n");
            Console.Write("Vehiculo que usa:" + this.Vehi + "\n");
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
                Console.WriteLine("Nropedido: " + ped.IdPedido + "\n");
                Console.WriteLine("Cliente: " + ped.Cli.Nombre + "\n");
                Console.WriteLine("Direccion: " + ped.Cli.Direccion + "\n");
                Console.WriteLine("Estado: " + ped.Est + "\n");
                Console.WriteLine("Tipo Pedido: " + ped.Tipo + "\n");
                Console.WriteLine("Tiene Cupon: " + ped.Cupon + "\n");
                Console.WriteLine("Costo Pedido: " + ped.calcularcosto() + "\n");
                Console.WriteLine("\n \n");
            }
        }
        public override int contarpedidos()
        {
            return pedidos.Count;
        }
    }
}
