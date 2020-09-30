using System;
using System.Collections.Generic;
using System.Text;

namespace TP04
{
    public class Cliente : Persona
    {
        int idCliente;
        public Cliente(int idCliente, string nom, string direc, int tel): base(nom, direc, tel)
        {
            this.idCliente = idCliente;
        }
    }
}
