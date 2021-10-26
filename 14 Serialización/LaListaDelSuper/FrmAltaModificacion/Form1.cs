using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmAltaModificacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public Form1(string titulo, string botonConfirmar, string botonCancelar)
        {
            Text = titulo;
            btnConfirmar.Text = botonConfirmar;
            btnCancelar.Text = botonCancelar;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            //try
            //{
                if (txtObjeto.Text == "")
                {
                //throw e;
                ////break;
                MessageBox.Show("No ingresaste nada");
                }
                else
                {
                    DialogResult dialogResult = DialogResult.OK;
                    MessageBox.Show(dialogResult.ToString());
                }



            //}
            //catch (Exception e)
            //{

            //    throw;
            //}
            

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == (char)13) 
            //{
            //    btnConfirmar_Click(sender,e);
            //}
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = DialogResult.Cancel;            
        }

    }
}
