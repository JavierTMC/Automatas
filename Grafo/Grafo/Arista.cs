using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Grafo
{
    class Arista
    {
       public Point Origen { get; set; }
       public Point Destino { get; set; }
       public int Ponderacion = int.MinValue;


       public Arista()
       { }

       public Arista(Point primerNodo, Point segundoNodo, int ponderacionArista)
       {
           this.Origen = primerNodo;
           this.Destino = segundoNodo;
           this.Ponderacion = ponderacionArista;
       }
    }
}
