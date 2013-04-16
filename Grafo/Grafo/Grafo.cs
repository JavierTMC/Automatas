using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using Microsoft.VisualBasic;
using System.IO;

namespace Grafo
{
    public partial class Grafo : Form
    {
        #region Variables
        List<Nodo> Directorio;
        bool Dirigido;
        bool crearAdyacencia = false;
        bool agregandoNodos = true;
        //List<Rectangle> rectangulos = new List<Rectangle>();
        bool origenDestino = true;
        int nodoOrigenEncontrado;

        bool eliminarNodo = false;

        bool eliminarAdyacencia = false;
        int nodoDestinoencontrado;
        bool paso1 = false;

        bool encontradoEliminarAdyacencia = true;

        //grado de un nodo
        bool gradodeNodo = false;

        //orden del grafo
        int ordenGrafo;

        // guarda el string que contine el xml
        string Resultado = string.Empty;

        //Automatas
        bool esInicial = false;
        bool esAceptante = false;
        int nodoQueEstaChecando;
        List<int> cadenaString = new List<int>();
        List<Nodo> directorioNFA = new List<Nodo>();
        #endregion

        #region Constructor de la Forma
        public Grafo()
        {
            InitializeComponent();
        }
        #endregion

        #region Eventos
        #region Forma
        private void Grafo_Load(object sender, EventArgs e)
        {
            TSLOperacionEjecutandose.Text = string.Empty;
            TSSLAdyacencia.Text = string.Empty;
        }
        #endregion

        #region Panel
        private void panelGrafo_MouseDown(object sender, MouseEventArgs e)
        {
            if (agregandoNodos == true)
            {

                if (Directorio.Count == 0)
                {

                    Rectangle posicion=new Rectangle();
                    posicion.Location = e.Location;
                    posicion.Size = new Size(40, 40);

                    
                    Directorio.Add(new Nodo(string.Empty, new List<Nodo>(), posicion, Directorio.Count,false,false, false));
                    Pintar(Directorio);
                }
                else
                {
                    Point nuevaPosicion = e.Location;
                    bool NodoExistente = false;

                    foreach (var item in Directorio)
                    {
                        if ((item.Posicion.Contains(nuevaPosicion) || item.Posicion.IntersectsWith(new Rectangle(nuevaPosicion, new Size(40, 40))))&& item.Activo == true)
                        {
                            NodoExistente = true;
                        }
                    }

                    if (NodoExistente == false)
                    {
                        Directorio.Add(new Nodo(string.Empty, new List<Nodo>(),new Rectangle(nuevaPosicion,new Size(40,40)),Directorio.Count, false,false, false));
                        Pintar(Directorio);
                    }
                    else
                    {
                        MessageBox.Show("No se puede pintar sobre un nodo existente");
                    }
                }
            }
            else if (eliminarNodo)
            {
                //eliminar nodos
                bool encontrado1 = false;
                for (int i = 0; i < Directorio.Count; i++)
                {
                    if (Directorio[i].Posicion.Contains(e.Location))
                    {
                        nodoOrigenEncontrado = i;
                        encontrado1 = true;
                        Directorio[i].Activo = false;

                        foreach (var item in Directorio[nodoOrigenEncontrado].ListaDeNodosAdyacentes)
                        {
                            item.Activo = false;
                        }

                        break;
                    }
                }

                if (encontrado1 == false)
                {
                    MessageBox.Show("Selecciona un nodo a eliminar");
                }
                else
                {
                    for (int j = 0; j < Directorio.Count; j++)
                    {
                        for (int k = 0; k < Directorio[j].ListaDeNodosAdyacentes.Count; k++)
                        {
                            if (Directorio[j].ListaDeNodosAdyacentes[k].identificador == nodoOrigenEncontrado)
                            {
                                Directorio[j].ListaDeNodosAdyacentes[k].Activo = false;
                            }
                        }
                    }
                    encontrado1 = true;
                    Pintar(Directorio);   
                }
            }
            else if (crearAdyacencia)
            {
                bool encontrado = false;

                if (origenDestino)
                {
                    for (int i = 0; i < Directorio.Count; i++)
                    {
                        if (Directorio[i].Posicion.Contains(e.Location))
                        {
                            nodoOrigenEncontrado = i;
                            encontrado = true;
                            origenDestino = false;
                            break;
                        }
                    }

                    if (encontrado == false)
                    {
                        MessageBox.Show("Selecciona un nodo Origen");
                    }
                }
                else
                {
                    string result = string.Empty;

                    for (int i = 0; i < Directorio.Count; i++)
                    {
                        if (Directorio[i].Posicion.Contains(e.Location))
                        {
                            encontrado = true;

                            if (!Dirigido)
                            {
                                if (Directorio[nodoOrigenEncontrado].Posicion.Contains(e.Location))
                                {
                                    MessageBox.Show("No puedes agregar adyacencia al mismo Nodo");
                                }
                                else
                                {
                                    result = Microsoft.VisualBasic.Interaction.InputBox("Escribe la ponderacion", "Ponderacion", "", (this.Size.Width / 2) - 80, this.Size.Height / 2);
                                    Directorio[nodoOrigenEncontrado].ListaDeNodosAdyacentes.Add(new Nodo(i, Convert.ToInt32(result), Directorio[i].Posicion, false));
                                    Directorio[i].ListaDeNodosAdyacentes.Add(new Nodo(nodoOrigenEncontrado, Convert.ToInt32(result), Directorio[i].Posicion, false));
                                }
                            }
                            else
                            {
                                result = Microsoft.VisualBasic.Interaction.InputBox("Escribe la ponderacion", "Ponderacion", "", (this.Size.Width / 2) - 80, this.Size.Height / 2);
                                Directorio[nodoOrigenEncontrado].ListaDeNodosAdyacentes.Add(new Nodo(i, Convert.ToInt32(result), Directorio[i].Posicion, false));
                            }                           
                           
                            origenDestino = true;

                            break;
                        }
                    }
                    if (encontrado == false)
                    {
                        MessageBox.Show("Selecciona un nodo Destino");
                    }
                    else
                    {
                        Pintar(Directorio);
                    }
                }

                //int numAceptantes = ChecarSiTengoAceptantesEnDirectorio(Directorio).Count();
                //if (numAceptantes != 0)
                //{
                //    foreach (var item in ChecarSiTengoAceptantesEnDirectorio(Directorio))
                //    {
                //        CambiarAceptanteElNodo(Directorio, item);
                //    }
                //}
            }
            else if (eliminarAdyacencia)
            {
                if (encontradoEliminarAdyacencia)
                {
                    //buscar el nodo en el directorio
                    for (int i = 0; i < Directorio.Count; i++)
                    {
                        if (Directorio[i].Posicion.Contains(e.Location))
                        {
                            //este cambio sirve para ir a encontrar el nodo destino
                            encontradoEliminarAdyacencia = false;

                            nodoOrigenEncontrado = i;
                            break;
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < Directorio.Count; i++)
                    {
                        if (Directorio[i].Posicion.Contains(e.Location))
                        {
                            encontradoEliminarAdyacencia = true;

                            nodoDestinoencontrado = i;
                            paso1 = true;

                        }
                    }

                }
                if (Dirigido == true && paso1 == true)
                {
                    foreach (var item in Directorio[nodoOrigenEncontrado].ListaDeNodosAdyacentes)
                    {

                        if (item.identificador == Directorio[nodoDestinoencontrado].identificador)
                        {
                            item.Activo = false;
                            paso1 = false;
                        }
                    }
                    Pintar(Directorio);
                }
                else if(Dirigido == false && paso1 == true)
                {
                    foreach (var item in Directorio[nodoOrigenEncontrado].ListaDeNodosAdyacentes)
                    {
                        if (item.identificador == Directorio[nodoDestinoencontrado].identificador)
                        {
                            item.Activo = false;
                            paso1 = false;
                        }
                    }

                    foreach (var item in Directorio[nodoDestinoencontrado].ListaDeNodosAdyacentes)
                    {
                        if (item.identificador == Directorio[nodoOrigenEncontrado].identificador)
                        {
                            item.Activo = false;
                            paso1 = false;
                        }
                    }

                    Pintar(Directorio);
                }

            }
            else if (gradodeNodo)
            {
                bool encontrado = false;
                //encontrar el nodo seleccionado
                for (int i = 0; i < Directorio.Count; i++)
                {
                    if (Directorio[i].Posicion.Contains(e.Location))
                    {
                        encontrado = true;
                        nodoOrigenEncontrado = i;
                        break;
                    }
                }

                if (encontrado == false)
                {
                    MessageBox.Show("Selecciona un Nodo para saber su grado");
                }
                else
                {
                    int gradoEntrada = 0;
                    int gradoSalida = 0;

                    if (Dirigido)
                    {
                        //grado entrada
                        gradoEntrada = MuestraGradoEntradaDeUnNodo(Directorio, nodoOrigenEncontrado);
                        // grado de salida
                        gradoSalida = MuestraGradoSalidaDeUnNodo(Directorio, nodoOrigenEncontrado);
                        //Mostrar grados
                        MessageBox.Show("El  vertice " + (Directorio[nodoOrigenEncontrado].identificador + 1) + " \n tiene un grado de entrada de : " + gradoEntrada + "\n y un grado de salida de : "+ gradoSalida);
                    }
                    else
                    {
                        // grado de entrada
                        gradoEntrada = MuestraGradoEntradaDeUnNodo(Directorio, nodoOrigenEncontrado);
                        MessageBox.Show("El vertice " + (Directorio[nodoOrigenEncontrado].identificador + 1) + " \n tiene un grado de : " + gradoEntrada);
                    }                
                }
            }
            else if (esInicial)
            {
                // indicar que el nodo es inicial
                Point nuevaPosicion = e.Location;
                bool NodoExistente = false;

                foreach (var item in Directorio)
                {
                    if ((item.Posicion.Contains(nuevaPosicion) || item.Posicion.IntersectsWith(new Rectangle(nuevaPosicion, new Size(40, 40)))) && item.Activo == true)
                    {
                        NodoExistente = true;

                        // cambiar a estado inicial
                        item.EstadoInicial = true;
                        // cambiar a estado aceptante ese nodo
                        item.EstaChecando = true;

                        nodoQueEstaChecando = item.identificador;
                    }
                }

                if (NodoExistente == false)
                {
                    TSLOperacionEjecutandose.Text = "Status: Indica cual sera tu nodo Inicial";
                    //Directorio.Add(new Nodo(string.Empty, new List<Nodo>(), new Rectangle(nuevaPosicion, new Size(40, 40)), Directorio.Count, false));
                    //Pintar(Directorio);
                }
                else
                {
                    //poner leyenda
                    gbLeyenda.Visible = true;
                    Pintar(Directorio);
                }

                //cambiar variable a false
                esInicial = false;
            }
            else if (esAceptante)
            {
                // indicar que el nodo es inicial
                Point nuevaPosicion = e.Location;
                bool NodoExistente = false;

                foreach (var item in Directorio)
                {
                    if ((item.Posicion.Contains(nuevaPosicion) || item.Posicion.IntersectsWith(new Rectangle(nuevaPosicion, new Size(40, 40)))) && item.Activo == true && item.EstadoInicial == false)
                    {
                        NodoExistente = true;

                        // cambiar a estado aceptante ese nodo
                        //funcion para cambiar a aceptante ese identificador de nodo
                        //en el directorio y en las adyacentes
                        CambiarAceptanteElNodo(Directorio, item.identificador);
                        //item.EsAceptante = true;
                    }
                }

                if (NodoExistente == false)
                {
                    TSLOperacionEjecutandose.Text = "Status: Indica tus nodos aceptantes";
                    //Directorio.Add(new Nodo(string.Empty, new List<Nodo>(), new Rectangle(nuevaPosicion, new Size(40, 40)), Directorio.Count, false));
                    //Pintar(Directorio);
                }
                else
                {
                    //poner leyenda
                    gbLeyenda.Visible = true;
                    Pintar(Directorio);
                }

                //cambiar variable a false
                esInicial = false;
            }
        }
        #endregion

        #region BtnCrearGrafo
        private void btn_crearGrafo_Click(object sender, EventArgs e)
        {
            if (rd_grafoDirigido.Checked == true)
            {
                Directorio = new List<Nodo>();
                Dirigido = true;

                //desactivamos
                btn_crearGrafo.Enabled = false;
                rd_grafoNoDirigido.Enabled = false;

                //activamos botones, etc
                panelGrafo.Visible = true;
                TSBGuardar.Enabled = true;

                //dar instruccion
                TSLOperacionEjecutandose.Text = "Status: Da click en el boton agregar Nodos";
            }
            else if (rd_grafoNoDirigido.Checked == true)
            {
                Directorio = new List<Nodo>();
                Dirigido = false;

                //desactivamos
                btn_crearGrafo.Enabled = false;
                rd_grafoDirigido.Enabled = false;

                //activar botones etc.
                panelGrafo.Visible = true;
                TSBGuardar.Enabled = true;

                //dar instruccion
                TSLOperacionEjecutandose.Text = "Status: Da click en el boton agregar Nodos";
            }
            else
            {
                MessageBox.Show("¡Selecciona El Tipo De Grafo!");
            }
        }
        #endregion

        #region BtnAgregarNodos
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            agregandoNodos = true;
            crearAdyacencia = false;
            eliminarNodo = false;
            TSLOperacionEjecutandose.Text = "Status: Insertando Nodos";
        }
        #endregion

        #region BtnAgregarAdyacencia
  
        private void tsbAgregarAdyacencia_Click(object sender, EventArgs e)
        {
            eliminarNodo = false;
            crearAdyacencia = true;
            agregandoNodos = false;
            TSLOperacionEjecutandose.Text = "Status: Insertando Adyacencias";

            // instruccion
            //MessageBox.Show("Da click en el nodo Origen y  luego click en el nodo Destino para colocar adyacencia");

            TSSLAdyacencia.Text = "Da click en el nodo Origen";
        }
        #endregion

        #region BtnEliminarNodo
        private void tsbEliminaNodo_Click(object sender, EventArgs e)
        {
            eliminarNodo = true;
            agregandoNodos = false;
            crearAdyacencia = false;
        }
        #endregion

        #region BtnEliminarAdyacencia
        private void tsbEliminarAdyacencia_Click(object sender, EventArgs e)
        {
            eliminarAdyacencia = true;
            eliminarNodo = false;
            agregandoNodos = false;
            crearAdyacencia = false;
        }
        #endregion

        # region BtnGuardar
        private void TSBGuardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog Path = new SaveFileDialog();
            if (Path.ShowDialog() != DialogResult.Cancel)
            {
                Save(Directorio, Path.FileName);
            }
        }

        public static void Save(List<Nodo> List, string FileName)
        {
            //create a backup
            string backupName = Path.ChangeExtension(FileName, ".nfa");

            using (FileStream fs = new FileStream(backupName, FileMode.Create))
            {
                System.Xml.Serialization.XmlSerializer ser = new System.Xml.Serialization.XmlSerializer(typeof(List<Nodo>));
                ser.Serialize(fs, List);
                fs.Flush();
                fs.Close();
            }
        }
        #endregion

        #region Informacion grafo
        private void ordenDelGrafoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ordenGrafo = OrdendelGrafo(Directorio);
            MessageBox.Show("El orden o el numero de nodos del grafo es: " 
                + ordenGrafo);
        }

        private void gradoDeUnNodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gradodeNodo = true;

            agregandoNodos = false;
            eliminarNodo = false;
            crearAdyacencia = false;
            eliminarAdyacencia = false;
        }

        private void esCompletoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // numero de nodos
            ordenGrafo = OrdendelGrafo(Directorio);
            int adyacencias;

            if (Dirigido)
            {
                int DigrafoCompleto = ordenGrafo * (ordenGrafo - 1);
                adyacencias = RegresaNumeroDeAdyacenciasEnDigrafo(Directorio);

                if (adyacencias == DigrafoCompleto)
                {
                    MessageBox.Show("El grafo es completo");
                }
                else
                {
                    MessageBox.Show("El grafo no es completo");
                }
            }
            else
            {
                int GrafoCompleto = (ordenGrafo * (ordenGrafo - 1)) / 2;
                adyacencias = RegresaNumeroDeAdyaenciasEnGrafo(Directorio);

                if (adyacencias == GrafoCompleto)
                {
                    MessageBox.Show("El grafo es completo");
                }
                else
                {
                    MessageBox.Show("El grafo no es completo");
                }
            }

            adyacencias = 0;
        }
        #endregion

        #endregion

        #region Metodos
        public void Pintar(List<Nodo> Directorio2)
        {
            Graphics ElDibujador = panelGrafo.CreateGraphics();
            ElDibujador.Clear(Color.Gainsboro);
            panelGrafo.Visible = true;

            if (Directorio != null)
            {
                foreach (var item in Directorio)
                {
                    if (item.Activo)
                    {
                        foreach (var adyacencia in item.ListaDeNodosAdyacentes)
                        {
                            if (adyacencia.Activo)
                            {
                                if (Dirigido) { PintarAdyacenciaDirigida(item.Posicion.Location, adyacencia.Posicion.Location, adyacencia.Ponderacion); }
                                else { PintarAdyacenciaNoDirigida(item.Posicion.Location, adyacencia.Posicion.Location); }
                            }
                        }
                    }
                }
            }
            
            
            for (int i = 0; i < Directorio2.Count; i++)
            {
                if (Directorio2[i].Activo)
                {
                    if (Directorio2[i].EstadoInicial)
                    {
                        ElDibujador.FillEllipse(Brushes.Red, Directorio2[i].Posicion);
                        ElDibujador.DrawString((i + 1).ToString(), new Font("Arial", 12), Brushes.Black, Directorio2[i].Posicion.Location.X + 10, Directorio2[i].Posicion.Location.Y + 10);
                    }
                    else if (Directorio2[i].EsAceptante)
                    {
                        ElDibujador.FillEllipse(Brushes.DarkBlue, Directorio2[i].Posicion);
                        ElDibujador.DrawString((i + 1).ToString(), new Font("Arial", 12), Brushes.Black, Directorio2[i].Posicion.Location.X + 10, Directorio2[i].Posicion.Location.Y + 10);
                    }
                    else
                    {
                        ElDibujador.FillEllipse(Brushes.Black, Directorio2[i].Posicion);
                        ElDibujador.DrawString((i + 1).ToString(), new Font("Arial", 12), Brushes.White, Directorio2[i].Posicion.Location.X + 10, Directorio2[i].Posicion.Location.Y + 10);
                    }
                }
            }
        }
        public void PintarAdyacenciaDirigida(Point PosicionNodoOrigen, Point PosicionNodoDestino, int ponderacion)
        {
            using (var PlumaDirigida = new Pen(Color.Red, 4))
            {
               PlumaDirigida.EndCap = LineCap.ArrowAnchor;
               PlumaDirigida.CustomEndCap = new AdjustableArrowCap(4, 6);
                Graphics Dibujador = panelGrafo.CreateGraphics();

                if (PosicionNodoDestino.X > PosicionNodoOrigen.X)
                {
                    if (PosicionNodoDestino.Y > PosicionNodoOrigen.Y)
                    {
                        Dibujador.DrawLine(PlumaDirigida, new Point(PosicionNodoOrigen.X + 40, PosicionNodoOrigen.Y+20), new Point(PosicionNodoDestino.X, PosicionNodoDestino.Y+20));
                        Dibujador.DrawString(ponderacion.ToString(), new Font("Arial", 12), Brushes.Black, PosicionNodoDestino.X - 20, PosicionNodoDestino.Y - 20);
                    }
                    else
                    {
                        Dibujador.DrawLine(PlumaDirigida, new Point(PosicionNodoOrigen.X + 40, PosicionNodoOrigen.Y + 20), new Point(PosicionNodoDestino.X, PosicionNodoDestino.Y+20));
                        Dibujador.DrawString(ponderacion.ToString(), new Font("Arial", 12), Brushes.Black, PosicionNodoDestino.X - 20, PosicionNodoDestino.Y - 5);
                    }
                }
                else {

                    if (PosicionNodoDestino.Y > PosicionNodoOrigen.Y)
                    {
                        Dibujador.DrawLine(PlumaDirigida, new Point(PosicionNodoOrigen.X, PosicionNodoOrigen.Y + 20), new Point(PosicionNodoDestino.X+40 , PosicionNodoDestino.Y+20));
                        Dibujador.DrawString(ponderacion.ToString(), new Font("Arial", 12), Brushes.Black, PosicionNodoDestino.X + 60, PosicionNodoDestino.Y);
                    }
                    else
                    {
                        Dibujador.DrawLine(PlumaDirigida, new Point(PosicionNodoOrigen.X, PosicionNodoOrigen.Y + 20), new Point(PosicionNodoDestino.X+40, PosicionNodoDestino.Y+20));
                        Dibujador.DrawString(ponderacion.ToString(), new Font("Arial", 12), Brushes.Black, PosicionNodoDestino.X + 40, PosicionNodoDestino.Y);
                    }
                
                }
            }
        }
        public void PintarAdyacenciaNoDirigida(Point PosicionNodoOrigen, Point PosicionNodoDestino)
        {
            Pen PlumaNoDirigida = new Pen(Color.Red, 4);
            Graphics Dibujador = panelGrafo.CreateGraphics();
            Dibujador.DrawLine(PlumaNoDirigida, new Point(PosicionNodoOrigen.X + 20, PosicionNodoOrigen.Y + 20), new Point(PosicionNodoDestino.X + 20, PosicionNodoDestino.Y + 20));
        }
        static int  OrdendelGrafo(List<Nodo> Directorio)
        {

            int ordenGrafo = 0;

            for (int i = 0; i < Directorio.Count; i++)
            {
                if (Directorio[i].Activo)
                {
                    ordenGrafo++;
                }
                
            }
            return ordenGrafo;
        }
        static int MuestraGradoSalidaDeUnNodo(List<Nodo> Directorio, int nodoOrigenEncontrado)
        {
            int gradoSalida = 0;

            for (int i = 0; i < Directorio[nodoOrigenEncontrado].ListaDeNodosAdyacentes.Count; i++)
            {
                if (Directorio[nodoOrigenEncontrado].ListaDeNodosAdyacentes[i].Activo)
                {
                    gradoSalida++;
                }                
            }

            return gradoSalida;
        }
        static int MuestraGradoEntradaDeUnNodo(List<Nodo> Directorio, int nodoSeleccionado)
        {
            int gradoEntrada = 0;

            for (int i = 0; i < Directorio.Count; i++)
            {
                for (int j = 0; j < Directorio[i].ListaDeNodosAdyacentes.Count; j++)
                {
                    if (Directorio[i].ListaDeNodosAdyacentes[j].Activo == true && Directorio[i].ListaDeNodosAdyacentes[j].identificador == nodoSeleccionado)
                    {
                        gradoEntrada++;
                    }
                }
            }
            return gradoEntrada;
        }
        static int RegresaNumeroDeAdyacenciasEnDigrafo(List<Nodo> Directorio)
        {
            int adyacencias = 0;

            for (int i = 0; i < Directorio.Count; i++)
            {
                for (int j = 0; j < Directorio[i].ListaDeNodosAdyacentes.Count; j++)
                {
                    if (Directorio[i].ListaDeNodosAdyacentes[j].Activo == true && Directorio[i].ListaDeNodosAdyacentes[j].identificador != Directorio[i].identificador )
                    {
                        adyacencias++;
                    }
                }
            }

            return adyacencias;
        }
        static int RegresaNumeroDeAdyaenciasEnGrafo(List<Nodo> Directorio)
        {
            int adyacencias = 0;

            for (int i = 0; i < Directorio.Count; i++)
            {
                for (int j = 0; j < Directorio[i].ListaDeNodosAdyacentes.Count; j++)
                {
                    if (Directorio[i].ListaDeNodosAdyacentes[j].Activo == true && Directorio[i].ListaDeNodosAdyacentes[j].identificador > Directorio[i].identificador)
                    {
                        adyacencias++;
                    }
                }   
            }

            return adyacencias;
        }
        #endregion
        
        #region Automatas
        private void btnEstadosAceptantes_Click(object sender, EventArgs e)
        {
            esAceptante = true;

            esInicial = false;
            eliminarNodo = false;
            crearAdyacencia = false;
            agregandoNodos = false;
            gradodeNodo = false;
        }    
        
        private void btnIndicarEstadoInicial_Click(object sender, EventArgs e)
        {
            esInicial = true;

            eliminarNodo = false;
            crearAdyacencia = false;
            agregandoNodos = false;
            gradodeNodo = false;
        }
        
        private void btnChecarInput_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtbInput.TextLength == 0)
                {
                    MessageBox.Show("falta insertar input :D guapo!");
                }
                else
                {
                    string cadena = txtbInput.Text;
                    for (int i = 0; i < cadena.Length; i++)
                    {
                        cadenaString.Add(Convert.ToInt32(cadena.Substring(i, 1)));
                    }
                    //pasar el directorio a otro directorio para no mover el original
                    directorioNFA = Directorio;
                    //llamar a la funciones de transicion dependiendo del automata
                    if (rbNFA.Checked)
                       txtbResulatdoAutomata.Text = FuncionTransicionNFA(directorioNFA, cadenaString, nodoQueEstaChecando);
                    else
                        txtbResulatdoAutomata.Text = FuncionTransicion(directorioNFA, cadenaString, nodoQueEstaChecando);
                    //borrar la lista de input
                    cadenaString.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,ex.GetType().ToString());
            }
        }

        //funcion de transicion
        /// <summary>
        /// Funcion de transicion
        /// </summary>
        /// <param name="Directorio">Lista de Nodos</param>
        /// <param name="input">Input a comparar</param>
        /// <param name="nodoChecando">que nodo esta activo para checar el input</param>
        /// <returns></returns>
        static string FuncionTransicion(List<Nodo> Directorio, List<int> input, int nodoChecando)
        {
            bool seRompio = false;

            //recorrer todo el input, char por char
            for (int i = 0; i < input.Count; i++)
            {
                //obtener el charinput en la posicion i
                int charInput = Convert.ToInt32(input[i]);
                //recorrer la lista de nodos
                foreach (var itemDirectorio in Directorio)
                {
                    //si el nodo esta checando y esta activo
                    if (itemDirectorio.identificador == nodoChecando && itemDirectorio.Activo == true)
                    {
                        //checar si el nodo tiene adyacentes o caminos para posibles recorridos
                        if (itemDirectorio.ListaDeNodosAdyacentes.Count != 0)
                        {
                            //recorrer cada adyacente o posible camino
                            for (int j = 0; j < itemDirectorio.ListaDeNodosAdyacentes.Count; j++)
                            {
                                if (itemDirectorio.ListaDeNodosAdyacentes[j].Activo == true && 
                                    itemDirectorio.ListaDeNodosAdyacentes[j].Ponderacion == charInput)
                                {
                                    //cambiamos el nodoChecando al nodo con ponderacion igual
                                    nodoChecando = itemDirectorio.ListaDeNodosAdyacentes[j].identificador;

                                    seRompio = true;
                                    break;
                                }
                                else
                                {
                                    if (j == itemDirectorio.ListaDeNodosAdyacentes.Count -1)
                                    {
                                        return "Se murio el automata, no hay camino";
                                    }
                                }
                            }// fin //recorrer cada adyacente o posible camino
                        }
                        else
                        {
                            //el nodo no tiene posibles caminos para recorrer.
                            return "Se murio el automata, no hay camino";
                        }
                    }//fin nodo checando encontrado       
                    if (seRompio)
                    {
                        seRompio = false;
                        break;
                    }
                }
            }// fin for input

            foreach (var item in Directorio)
            {
                if (item.identificador == nodoChecando)
                {
                    if (item.EsAceptante)
                    {
                        return string.Format("Cadena Aceptada \n Identificador del Nodo: {0}",item.identificador.ToString());
                    }                   
                }  
            }
            return string.Format("La cadena no es aceptada por el automata");
        }

        /// <summary>
        /// Funcion de transicion para el NFA
        /// </summary>
        /// <param name="Directorio">Todos los nodos</param>
        /// <param name="input">Cadena del automata</param>
        /// <returns>Si la cadena es aceptada por el automana o no</returns>
        static string FuncionTransicionNFA(List<Nodo> Directorio, List<int> input, int nodoChecando)
        {
            //declaramos una lista que mantendra los estaChecando eventualemente
            List<int> segundaLista = new List<int>();

            //recorrer todos mis char's en el input para ir cambiando de estado
            for (int k = 0; k < input.Count; k++)
            {
                //recorrer todos los elementos de mi directorio para checar transacciones
                for (int i = 0; i < Directorio.Count; i++)
                {
                    //verificar si mi nodo es aceptante o no
                    if (Directorio[i].Activo == true && Directorio[i].EstaChecando == true)
                    {
                        //si es aceptante y esta activo
                        //checar si tiene nodos adyacentes
                        if (Directorio[i].ListaDeNodosAdyacentes.Count != 0)
                        {
                            for (int j = 0; j < Directorio[i].ListaDeNodosAdyacentes.Count; j++)
                            {
                                //checar si el nodo adyacente esta activo 
                                //y si la ponderacion es igual al charInput
                                if (Directorio[i].ListaDeNodosAdyacentes[j].Activo == true &&
                                    Directorio[i].ListaDeNodosAdyacentes[j].Ponderacion == input[k])
                                {
                                    //if (k != input.Count - 1)
                                    //{
                                    //    //cambiar el nodo.estaChecando  a false
                                        CambiarEstaChecandoElNodoFalse(Directorio, Directorio[i].identificador);
                                        //agregar nodos en otra lista
                                        //para compararlos con segundo o posterior input
                                        //despues cambiar en el directorio cada nodo.estaChecando en true
                                        segundaLista.Add(Directorio[i].ListaDeNodosAdyacentes[j].identificador);
                                    //}
                                    //else
                                    //{
                                    //    //CambiarEstaChecandoElNodoFalse(Directorio, Directorio[i].identificador);
                                    //    CambiarEstaChecandoElNodoTrue(Directorio, Directorio[i].ListaDeNodosAdyacentes[j].identificador);
                                    //}
                                }
                                else
                                {
                                    //si no me muevo de ese nodo
                                    // no hay cambios en nodo.estaChecando
                                    // permanece en true;
                                    //o
                                    //si el Directorio[i].listadeadyacentes no checa con el identificador poner estachecando en false
                                    if (k == (input.Count-1))
                                    {
                                        Directorio[i].EstaChecando = false;
                                        segundaLista.Remove(Directorio[i].identificador);
                                    }
                                }
                            }// fin for recorrido de Direcotio[i].listaDeNodosAdyacentes
                        }// fin if Direcotorio[i].ListaDeNodosAdyacentes.Count != 0
                        else
                        {
                            //if (input.Count == 1)
                            //{
                            //    //dejar el nodo como esta nodo.estachecando
                            //}
                            //else //quiere decir que si hay mas input
                            //{
                                Directorio[i].EstaChecando = false;
                                segundaLista.Remove(Directorio[i].identificador);
                            //}
                        }// fin else Direcotorio[i].ListaDeNodosAdyacentes.Count != 0
                    }//fin if Directorio[i].Activo == true && Directorio[i].EstaChecando == true
                    else
                    {

                    }
                }// fin for Directorio

                if (segundaLista.Count != 0)
                {
                    //recorrer la segundaLista y pasar cada nodo en el directorio a estachecando = true
                    for (int i = 0; i < segundaLista.Count; i++)
                    {
                        CambiarEstaChecandoElNodoTrue(Directorio, segundaLista[i]);
                    }
                    segundaLista.Clear();
                }
            }// fin foreach input

            if (segundaLista.Count != 0)
            {
                //recorrer la segundaLista y pasar cada nodo en el directorio a estachecando = true
                for (int i = 0; i < segundaLista.Count; i++)
                {
                    CambiarEstaChecandoElNodoTrue(Directorio, segundaLista[i]);
                }
                segundaLista.Clear();
            }

            //variable para acumular los estados aceptantes
            string nodosEstanChecando = string.Empty;

            //Recorre el directorio
            foreach (var itemDirectorio in Directorio)
            {
                if (itemDirectorio.Activo == true && itemDirectorio.EstaChecando == true && itemDirectorio.EsAceptante == true)
                {
                    //suma los nodo.identificador que cumpla con la condicion
                    nodosEstanChecando += (itemDirectorio.identificador + 1) + ",";
                }
            }


            foreach (var item in Directorio)
            {
                if (item.identificador != nodoChecando)
                {
                    item.EstaChecando = false;
                }
                else
                    item.EstaChecando = true;
            }

            if (nodosEstanChecando == string.Empty)
                return "La cadena no es aceptada por el automata";
            else
                return "La cadena es aceptada por el automata en el nodo(s) : \n " + nodosEstanChecando;
        }

        /// <summary>
        /// Cambia a estado aceptante al nodo en el directorio y en las listas adyacentes
        /// </summary>
        /// <param name="ListaNodo"> Directorio con adyacentes</param>
        /// <param name="identificador">Identificador del nodo a cambiar estado</param>
        static void CambiarAceptanteElNodo(List<Nodo> ListaNodo, int identificador)
        {
            foreach (var item in ListaNodo)
            {
                if (item.identificador == identificador && item.Activo == true)
                {
                    item.EsAceptante = true;
                }
                else
                {
                    foreach (var X in item.ListaDeNodosAdyacentes)
                    {
                        if (X.identificador == identificador && X.Activo == true)
                        {
                            X.EsAceptante = true;
                        }
                    }
                }
            }
        }

        static void CambiarEstaChecandoElNodoTrue(List<Nodo> ListaNodo, int identificador)
        {
            foreach (var item in ListaNodo)
            {
                if (item.identificador == identificador && item.Activo == true)
                {
                    item.EstaChecando = true;
                }
            }
        }

        static void CambiarEstaChecandoElNodoFalse(List<Nodo> ListaNodo, int identificador)
        {
            foreach (var item in ListaNodo)
            {
                if (item.identificador == identificador && item.Activo == true)
                {
                    item.EstaChecando = false;
                }
            }
        }

        /// <summary>
        /// Checar si tengo aceptantes en mi directorio
        /// </summary>
        /// <param name="listaNodos">Lista de nodos</param>
        /// <returns>Regresa una lista de identificadores de nodos aceptantes</returns>
        static List<int> ChecarSiTengoAceptantesEnDirectorio(List<Nodo> listaNodos)
        {
            List<int> listaNodosAceptandes = new List<int>();

            foreach (var item in listaNodos)
            {
                if (item.EsAceptante && item.Activo == true)
                {
                    listaNodosAceptandes.Add(item.identificador);
                }
            }
            return listaNodosAceptandes;
        }
        #endregion
    }
}

   
