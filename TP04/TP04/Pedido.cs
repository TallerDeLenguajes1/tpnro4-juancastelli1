using System;
using System.Collections.Generic;
using System.Text;

namespace TP04
{
    public enum tipoped {Delicado, Express, Ecologico}
    public enum estado { Recibido = 0, Preparado = 1, EnCamino = 2, Entregado = 3 };
    public class Pedido
    {
        int idPedido;
        string observaciones;
        Cliente cli;
        estado est;
        tipoped tipo;
        bool cupon;
        public int IdPedido { get => idPedido; set => idPedido = value; }
        public string Observaciones { get => observaciones; set => observaciones = value; }
        public estado Est { get => est; set => est = value; }
        internal Cliente Cli { get => cli; set => cli = value; }
        public tipoped Tipo { get => tipo; set => tipo = value; }
        public bool Cupon { get => cupon; set => cupon = value; }

        public Pedido(int idPedido, string observaciones,
        int idCliente, string nombre, string direccion, int telefono, estado est, tipoped tipo, bool cupon)
        {
            this.idPedido = idPedido;
            this.observaciones = observaciones;
            this.cli = new Cliente(idCliente, nombre, direccion, telefono);
            this.est = est;
            this.Tipo = tipo;
            this.Cupon = cupon;
        }
        public Pedido(int idPedido, string observaciones,Cliente cli, estado est, tipoped tipo, bool cupon)
        {
            this.idPedido = idPedido;
            this.observaciones = observaciones;
            this.cli = cli;
            this.est = est;
            this.Tipo = tipo;
            this.Cupon = cupon;
        }
        void cambiarEstado(string esta)
        {
            switch (esta)
            {
                case "Recibido":
                    this.est = estado.Recibido;
                    break;
                case "Preparado":
                    this.est = estado.Preparado;
                    break;
                case "EnCamino":
                    this.est = estado.EnCamino;
                    break;
                case "Entregado":
                    this.est = estado.Entregado;
                    break;
                default:
                    this.est = estado.Recibido;
                    break;
            }
        }
        public double calcularcosto() 
        {
            double costo = 150;
            switch (this.Tipo) 
            {
                case tipoped.Delicado:
                    costo = costo*(1.3);
                    break;
                case tipoped.Express:
                    costo = costo * (1.25);
                    break;
                default:
                    break;
            }
            if (this.Cupon) 
            {
                costo = costo * 0.9;
            }
            return costo;
        }
    }

}
