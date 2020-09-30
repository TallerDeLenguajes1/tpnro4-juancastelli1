using System;
using System.Collections.Generic;
using System.Text;

namespace TP04
{
    class Cadeteria
    {
        string nombre;
        List<Cadete> cadetes;

        public Cadeteria(string nombre)
        {
            this.nombre = nombre;
            this.cadetes = new List<Cadete>();
        }

        public string Nombre { get => nombre; set => nombre = value; }
        internal List<Cadete> Cadetes { get => cadetes; set => cadetes = value; }

        public void informecadetes()
        {
            foreach (Cadete cad in cadetes)
            {
                cad.informe();
            }
        }
        public void informecadetescompleto()
        {
            foreach (Cadete cad in cadetes)
            {
                cad.informe();
                cad.pedidosdecadete();
            }
        }
        void mejorcadete()
        {
            Cadete maxcadi = new Cadete(0, " ", " ", 0);
            foreach (Cadete cad in cadetes)
            {
                if (cad.cantidadPedidosE() > maxcadi.cantidadPedidosE())
                {
                    maxcadi = cad;
                }
            }
            maxcadi.informe();
            Console.WriteLine("promedio entregados:" + maxcadi.promedioentregados());
        }
    }
}
