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

namespace AtrapameSiPuedes
{
    public partial class frmAtrapameSiPuedes : Form
    {
        public frmAtrapameSiPuedes()
        {
            InitializeComponent();
        }

        private void frmAtrapameSiPuedes_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtKilometros.Text == "" || txtLitros.Text == "")
                {
                    throw new ParametrosVaciosException("Ocurrio un error, no ingreso ningun número");
                }
                else
                {
                    rtbCalculador.Text = $" Kilometros / Litros: { Calculador.Calcular(int.Parse(txtKilometros.Text), int.Parse(txtLitros.Text))}";
                }
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("No se puede dividir por cero");
            }
            catch (ParametrosVaciosException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (FormatException)
            {
                MessageBox.Show("Solo se pueden ingresar números");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
