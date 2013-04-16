using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Grafo
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void btn_crearGrafo_Click(object sender, EventArgs e)
        {
            Grafo LaForma = new Grafo();
            LaForma.Show();
            this.Hide();
        }

        private void btn_abrirGrafo_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdBuscarXML = new OpenFileDialog();
            ofdBuscarXML.Title = "Automatas";
            ofdBuscarXML.FileName = " xml a leer";
            ofdBuscarXML.InitialDirectory = "c:\\";

            if (ofdBuscarXML.ShowDialog() == DialogResult.OK)
            {
                 List<Nodo> directorio = new List<Nodo>();
                 directorio = xmlMetodos.LoadXML(ofdBuscarXML.FileName);
                Grafo metodos = new Grafo();
                metodos.Show();
                metodos.Pintar(directorio);
            }
        }
    }
}
