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
        public string output = string.Empty;
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
                        output += AddZeros(Convert.ToInt32(arrayValues[i]));
                        if (i != (arrayValues.Length - 1))
                            output += "1";
                        else if (!reader.EndOfStream)
                            output += "11";
                    }
                }// end while mientras haya lectura
                lblString.Text = output;
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
                if (GuardarString(output))
                    lblGuardado.Visible = true;
            }
            catch (Exception errorEx)
            {
                MessageBox.Show(errorEx.Message, errorEx.GetType().ToString());
            }
        }
        #endregion

        #region Metodos Privados
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

        private static string AddZeros(int number)
        {
            string output = string.Empty;
            switch (number)
            {
                case 1:
                    output = "0";
                    break;
                case 2 :
                    output = "00";
                    break;
                case 3:
                    output = "000";
                    break;
                case 4:
                    output =  "0000";
                    break;
                case 5:
                    output =  "00000";
                    break;
                case 6:
                    output = "000000";
                    break;
                case 7:
                    output = "0000000";
                    break;
                case 8:
                    output = "00000000";
                    break;
                case 9:
                    output = "000000000";
                    break;
                default:
                    break;
            }
            return output;
        }

        private static bool GuardarString(string cadena)
        {
            try
            {
                SaveFileDialog ToSave = new SaveFileDialog();
                ToSave.Title = "Save the string generated";
                ToSave.DefaultExt = "ctm";
                ToSave.AddExtension = true;
                ToSave.ShowDialog();
                File.AppendAllText(ToSave.FileName, cadena);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
    }
}
