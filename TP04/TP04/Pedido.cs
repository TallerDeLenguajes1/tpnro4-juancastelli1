using System;
using System.Collections.Generic;
using System.Text;

namespace TP04
{
    public enum estado { Recibido = 0, Preparado = 1, EnCamino = 2, Entregado = 3 };
    public class Pedido
    {
        int idPedido;
        string observaciones;
        Cliente cli;
        estado est;
        public int IdPedido { get => idPedido; set => idPedido = value; }
        public string Observaciones { get => observaciones; set => observaciones = value; }
        public estado Est { get => est; set => est = value; }
        internal Cliente Cli { get => cli; set => cli = value; }

        public Pedido(int idPedido, string observaciones,
        int idCliente, string nombre, string direccion, int telefono, estado est)
        {
            this.idPedido = idPedido;
            this.observaciones = observaciones;
            this.cli = new Cliente(idCliente, nombre, direccion, telefono);
            this.est = est;
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
    }

}
