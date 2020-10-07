using System;
using System.Collections.Generic;
using System.Text;

namespace TP04
{
    public class Cliente : Persona
    {
        int idCliente;
        List<Pedido> pedidos;
        public Cliente(int idCliente, string nom, string direc, int tel): base(nom, direc, tel)
        {
            this.idCliente = idCliente;
            this.Pedidos = new List<Pedido>();
        }

        public List<Pedido> Pedidos { get => pedidos; set => pedidos = value; }

        public override int contarpedidos()
        {
            return Pedidos.Count;
        }
    }
}
