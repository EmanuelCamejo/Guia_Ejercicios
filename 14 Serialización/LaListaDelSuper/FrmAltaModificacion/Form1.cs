using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario
{
    public partial class FrmAltaModificacion : Form
    {
        //public FrmAltaModificacion()
        //{
        //    InitializeComponent();
        //}
        public FrmAltaModificacion() { }
        public FrmAltaModificacion(string titulo, string contenidoTextBox, string textBotonConfirmar)
        {
            Text = titulo;
            txtObjeto.Text = contenidoTextBox;
            btnConfirmar.Text = textBotonConfirmar;
           
        }

        public string Objeto
        {
            get { return txtObjeto.Text; }
         }

        private void Confirmar()
        {
            if (string.IsNullOrWhiteSpace(txtObjeto.Text))
            {
                MessageBox.Show("El texto no puede estar vacio", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void Cancelar()
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Confirmar();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Confirmar();
            }
            else if (e.KeyChar == (char)27)
            {
                Cancelar();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar();         
        }

    }
}
