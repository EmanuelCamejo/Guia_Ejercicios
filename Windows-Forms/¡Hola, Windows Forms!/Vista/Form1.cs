using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class frmMensaje : Form
    {
        public frmMensaje() 
        { }
        public frmMensaje(string nombre, string apellido):this()
        {
            InitializeComponent();
            lblTitulo.Text = nombre;
            lblMensaje.Text = apellido;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
