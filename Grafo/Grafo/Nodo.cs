using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Grafo
{
    [Serializable]
    public class Nodo
    {
        public string Nombre { get; set; }
        public List<Nodo> ListaDeNodosAdyacentes { get; set; }
        public Rectangle Posicion { get; set; }
        public int Ponderacion { get; set; }
        public int identificador { get; set; }
        public bool Activo { get; set; }
        // automatas
        public bool EstadoInicial { get; set; }
        public bool EsAceptante { get; set; }
        public bool EstaChecando { get; set; }

        //adyacentes
        public Nodo(int idenficadorNodo, int Ponderacion,Rectangle posicionAdyacencia, bool esAceptante)
        {
            this.identificador = idenficadorNodo;
            this.Ponderacion = Ponderacion;
            this.Posicion = posicionAdyacencia;
            this.Activo = true;

            // automatas
            this.EsAceptante = esAceptante;
        }
        
        //directorio
        public Nodo(string Nombre, List<Nodo> ListaDeNodosAdyacentes, Rectangle PosicionNodo, int identificador,
            bool esInicial, bool esAceptante, bool estaChecando)
        {
            this.Nombre = Nombre;
            this.ListaDeNodosAdyacentes = ListaDeNodosAdyacentes;
            this.Posicion = PosicionNodo;
            this.Ponderacion = int.MinValue;
                this.Activo = true;
                this.identificador = identificador;
            // automatas
                this.EstadoInicial = esInicial;
                this.EsAceptante = esAceptante;
                this.EstaChecando = estaChecando;
        }
        //constructor vacio
        public Nodo()
        { }
    }
}
