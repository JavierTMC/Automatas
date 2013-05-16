using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace csvGrafico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Variables
        //esta variable guarda  la TM Codificada
        public string output = string.Empty;
        
        //variable que guarda la TM codificada por transiciones
        List<string> TM = new List<string>();
        //variable que juega un rol temporal para ir guardando una transicion
        string M = string.Empty;

        //esta variable sirve para guardar el input
        public List<string> cinta2 = new List<string>();
        //esta variable es para almacenar el input codificado
        string inputCodifcadoTexto = string.Empty;
        
        //esta variable sirve para almacenar el estado
        string cinta3 = string.Empty;

        // variable para leer el input, en que posicion de la cinta voy
        int posicionCinta = 1;
        #endregion

        #region Eventos
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //buscar archivo para leerlo
            //"C:\\Users\\JavierTMezaC\\Desktop\\csv.txt"
            try
            {
                var reader = new StreamReader(File.OpenRead(ReturnsPathOpenFileDialog()));
                while (!reader.EndOfStream) // mientras haya lectura
                {
                    //lee una linea completa
                    var line = reader.ReadLine();

                    //regresa cada valor de la linea en un arreglo
                    var arrayValues = line.Split(',');

                    // recorrer cada elemento del arrayValues
                    for (int i = 0; i < arrayValues.Length; i++)
                    {
                        //output += AddZeros(Convert.ToInt32(arrayValues[i]));
                        AddZeros(Convert.ToInt32(arrayValues[i]));

                        if (i != (arrayValues.Length - 1))
                        {
                            //output += "1";
                            //TMCodificada.Add(1);
                            M += "1";
                            output += "1";
                        }
                        else if (!reader.EndOfStream)
                        {  
                            output += "11";
                        }                          
                    }// fin for valores linea

                    //agregar a la variable global TM la transicion M
                    TM.Add(M);
                    M = string.Empty;

                }// end while mientras haya lectura

                //mostrar el input la TM codificada
                txtbTMCodificado.Text = output;

                //activar bonotes
                ActivarDesactivarControles(1);
            }
            catch (Exception erroEX)
            {
                MessageBox.Show(erroEX.Message, erroEX.GetType().ToString());
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(GuardarString(output),"Mensajito Bonito",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception errorEx)
            {
                MessageBox.Show(errorEx.Message, errorEx.GetType().ToString(),MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void txtbInsetarInput_Leave(object sender, EventArgs e)
        {
            //variable para leer el input
            string texto = txtbInsetarInput.Text;
            //variable para almacer cada char del input insertado
            List<int> charTexto = new List<int>();

            /* ya tengo mi input
             * entonces generar la cinta 1
             * M = maquita codificada
             * 111 = separador
             * w = input NO codificado
             * compuesta por M111w
             */
            GenerarCinta1(); // M111w

            try
            {
                //dividir todo el input para insertarlo en el  la variable charTexto
                for (int i = 0; i <= texto.Length - 1; i++)
                {
                    //por cada char tel texto, se inserta en la variable charTexto
                    charTexto.Add(Convert.ToInt32(texto.Substring(i, 1)));
                }

                //codificar input, la codificacion la guardo en la variable cinta2
                CodificarInput(charTexto);
                //Se utiliza la variable global inputCodificado
                GenerarCinta2();

                //escribir el input codificado en txtbInputCodificado por unica vez
                txtbInputCodificado.Text = inputCodifcadoTexto;
        
                //Generar Cinta numero 3 por primera vez
                cinta3 = "01";
                txtbCinta3.Text = cinta3;

                //abilitar desabilitar Controles
                ActivarDesactivarControles(2);
               
            }
            catch (Exception errorEx)
            {
                MessageBox.Show(errorEx.Message, errorEx.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnNuevoTM_Click(object sender, EventArgs e)
        {
            //variables globales
            TM.Clear();
            cinta2.Clear();
            cinta3 = string.Empty;
            posicionCinta = 1;
            inputCodifcadoTexto = string.Empty;
            output = string.Empty;

            //controles
            txtbTMCodificado.Clear();
            txtbInsetarInput.Clear();
            txtbInputCodificado.Clear();
            txtbCinta1.Clear();
            txtbCinta2.Clear();
            txtbCinta3.Clear();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {      
            //buscar =  ceroi + ceroj
            string buscar = cinta3;

            //agregar input al string buscar
            try
            {
                if (cinta2[posicionCinta] != "B")
                    buscar += cinta2[posicionCinta];
                else
                    buscar += "0001";

                //variable que almacena una transicion, si es que existe
                string transicion = CorrovorarListaBuscarEnM(buscar);

                // Corrovorar si buscar esta en M
                if (transicion.Length != 0)
                {
                    //generar el nuevo ESTADO
                    int cerok = GenerarNuevoEstado(transicion, buscar);

                    //cambiar el input codificado de la cinta 2
                    int ceroEle = CambiarInputCodificadoCinta2(cerok, transicion);

                    //la direccion en la que se mueve la cinta
                    DireccionMovCinta(ceroEle, transicion);
                }
                else
                    MessageBox.Show("No encontrado", "Maquina de Turing Universal: Resultado", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            catch (ArgumentOutOfRangeException)
            {
                if (cinta3 == "001")
                {
                    MessageBox.Show("Input Aceptado", "Maquina de Turing Universal: Resultado",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception errorEx)
            {
                string mensaje = errorEx.Message + "\n" + errorEx.GetType().ToString();
                MessageBox.Show(mensaje, "Maquina de Turing Universal: Resultado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevoInput_Click(object sender, EventArgs e)
        {
            //variables
            cinta2.Clear();
            inputCodifcadoTexto = string.Empty;
            cinta3 = string.Empty;
            posicionCinta = 1;

            //controles
            txtbCinta2.Clear();
            txtbInputCodificado.Clear();
            txtbCinta1.Clear();
            txtbCinta3.Clear();
            txtbInsetarInput.Enabled = true;
            txtbInsetarInput.Clear();

        }
        #endregion

        #region Metodos Privados
        void ActivarDesactivarControles(int n)
        {
            if (n == 1)
            {
                btnGenerar.Enabled = true;
                btnNuevoTM.Enabled = true;
                txtbInsetarInput.Enabled = true;
            }
            else if (n == 2)
            {
                txtbInsetarInput.Enabled = false;
                btnSiguiente.Enabled = true;
                btnNuevoInput.Enabled = true;
            }
        }

        void GenerarCinta2()
        {
            //recorrer cada elemento de la cinta2 para generar el string del input codificado
            foreach (var item in cinta2)
            {
                inputCodifcadoTexto += item;
            }
            //escribir el input codificado en txtbCinta2
            txtbCinta2.Text = inputCodifcadoTexto;
        }
        /// <summary>
        /// TMCodificado111Input
        /// M111w
        /// </summary>
        void GenerarCinta1()
        {
            string cinta1 = string.Empty;

            for (int i = 0; i < TM.Count; i++)
            {
                if (i != (TM.Count-1))
                {
                    cinta1 += TM[i];
                    cinta1 += "11";
                }
                else
                {
                    cinta1 += TM[i];
                    cinta1 += "111";
                }
            }

            cinta1 += txtbInsetarInput.Text;
            txtbCinta1.Text = cinta1;
        }
        /// <summary>
        /// Codifica el input insertado
        /// </summary>
        /// <param name="charTexto">Recibe una lista de int (Input separado)</param>
        void CodificarInput(List<int> charTexto)
        {
            cinta2.Add("B");

            for (int i = 0; i < charTexto.Count; i++)
            {
                if (i != (charTexto.Count - 1))
                {
                    if (charTexto[i] == 1)
                    {
                        cinta2.Add("001");
                    }
                    else if (charTexto[i] == 0)
                    {
                        cinta2.Add("01");
                    }
                }
                else
                {
                    if (charTexto[i] == 1)
                    {
                        cinta2.Add("001");
                    }
                    else if (charTexto[i] == 0)
                    {
                        cinta2.Add("01");
                    }
                }
            }// fin ciclo for

            cinta2.Add("B");
        }
        /// <summary>
        /// Regresa el path file name donde esta el archivo CSV a leer
        /// </summary>
        /// <returns>Path File Name a leer</returns>
        private static string ReturnsPathOpenFileDialog()
        {
            try
            {     
                OpenFileDialog file = new OpenFileDialog();
                file.InitialDirectory = "c:\\Users\\JavierTMezaC\\Desktop";
                file.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                file.FilterIndex = 2;
                file.RestoreDirectory = true;
                file.ShowDialog();
                return file.FileName;
            }
            catch (Exception)
            {
                throw;
            }

        }
        /// <summary>
        /// Codifica la maquina de Turing, codifica el archivo CSV
        /// </summary>
        /// <param name="numero">Acepta un int , indica el numero de ceros a insertar</param>
        void AddZeros(int numero)
        {
            try
            {
                for (int i = 1; i <= numero; i++)
                {
                    //TMCodificada.Add(0);
                    M += "0";
                    output += "0";
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }
        /// <summary>
        /// Genera un archivo .txt de la maquina turing codificada
        /// </summary>
        /// <param name="cadena">Maruina turing codificado</param>
        /// <returns>Mensaje de guardado exitosamente, y la ubicacion del archivo</returns>
        private static string GuardarString(string cadena)
        {
            try
            {
                SaveFileDialog ToSave = new SaveFileDialog();
                ToSave.Title = "Save the string generated";
                ToSave.DefaultExt = "ctm";
                ToSave.AddExtension = true;
                ToSave.ShowDialog();
                File.AppendAllText(ToSave.FileName, cadena);
                return "Archivo creado checar ruta: \n" 
                    + ToSave.FileName;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private int GenerarNuevoEstado( string transicion, string buscar)
        {
            //limpiar cinta3 para agrega nuevo estado
            cinta3 = string.Empty;
            txtbCinta3.Clear();
            //estado al que se mueve                
            int cerok = 0;
            for (int i = buscar.Length; i < transicion.Length; i++)
            {
                if (transicion[i] != '1')
                    cinta3 += transicion[i];
                else
                {
                    cinta3 += transicion[i];
                    cerok = i;
                    break;
                }
            }
            txtbCinta3.Text = cinta3;

            return cerok + 1;
        }

        private int CambiarInputCodificadoCinta2( int cerok, string transicion)
        {
            //conseguir el nuevo input
            int ceroEle = 0;
            //lo que se escribe en la cinta
            //borrar de la cinta2
            cinta2.RemoveAt(posicionCinta);
            inputCodifcadoTexto = string.Empty;

            string nuevoInput = string.Empty;

            for (int i = cerok; i < transicion.Length; i++)
            {
                if (transicion[i] != '1')
                    nuevoInput += transicion[i];
                else
                {
                    nuevoInput += transicion[i];
                    ceroEle = i;
                    break;
                }
            }
            if (nuevoInput != "0001")
                cinta2.Insert(posicionCinta, nuevoInput);
            else
                cinta2.Insert(posicionCinta, "B");
            //colocar cinta en el txtbCinta2
            GenerarCinta2();

            return ceroEle + 1;
        }

        void DireccionMovCinta(int ceroEle, string transicion)
        {
            int cantidadCeros = 0;
            for (int i = ceroEle; i < transicion.Length; i++)
            {
                if (transicion[i] != '1')
                    cantidadCeros++;
                else
                    break;
            }

            if (cantidadCeros == 1)
                posicionCinta--;
            else
                posicionCinta++;
        }

        string CorrovorarListaBuscarEnM(string buscar)
        {
            string existe = string.Empty;

            for (int i = 0; i < TM.Count; i++)
            {
                string sub = TM[i].Substring(0, buscar.Length);

                if (sub == buscar)
                    existe = TM[i];
            }
            return existe;
        }
        #endregion

    }
}
