using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;

namespace Ejercicio_I02
{
    public partial class FrmCalculador : Form
    {
        public FrmCalculador()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.textBox1.Text == "" || this.textBox2.Text == "")
                {
                    throw new ParametrosVaciosException("Campo Vacio") ;
                }
            }
            catch(IndexOutOfRangeException ex)
            {
                MessageBox.Show(ex);
            }
            }


        }
    }
}
