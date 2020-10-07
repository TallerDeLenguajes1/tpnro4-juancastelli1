using System;
using System.Collections.Generic;
using System.Text;

namespace TP04
{
    public class Persona
    {
        string nombre;
        string direccion;
        int telefono;
        public Persona(string nombre, string direccion, int telefono)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.telefono = telefono;
        }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public int Telefono { get => telefono; set => telefono = value; }

        public virtual int contarpedidos()
        {
            return 0;
        }

    }
}
