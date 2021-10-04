using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        private Dictionary<string, int> diccionario; //declaro
        public Form1()
        {
            InitializeComponent();
            diccionario = new Dictionary<string, int>();//Inicializo
        }

        public void ContarPalabras(string tex) 
        {
            char[] separacionDePalabras = new char[] { ' ', ',', '.', ':', '\t' };
            List<string> palabras = new List<string>();
            palabras.AddRange(tex.Split(separacionDePalabras,StringSplitOptions.RemoveEmptyEntries));
            foreach (string i in palabras)
            {
                if (!diccionario.ContainsKey(i)&& i!=" ")
                {
                    diccionario.Add(i, 1);
                }
                else
                {
                    diccionario[i] += 1;
                }
            }
        }

        public string Mostrar()
        {
            string texto="apa";
            return texto;
        }

        

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{Mostrar()}");
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {           

        }
    }
}
