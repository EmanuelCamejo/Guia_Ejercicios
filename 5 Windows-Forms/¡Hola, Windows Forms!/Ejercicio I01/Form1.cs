using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista;

namespace Ejercicio_I01
{
    public partial class frmVista : Form
    {
        public frmVista()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            string titulo = "Hola, Windows Forms!";
            string mensaje = $"Soy {txtNombre.Text} {txtApellido.Text} y mi materia favorita es: {cmbMateria.SelectedItem}";


            if (Validar())
            {
                frmMensaje frmMensaje = new frmMensaje(titulo, mensaje);
                frmMensaje.ShowDialog();
            }

            //MessageBox.Show($"{titulo} \nSoy {txtNombre.Text} {txtApellido.Text}");
        }
        private bool Validar()
        {
            bool resultado=true;
            StringBuilder st = new StringBuilder();

            st.AppendLine("Se debe completar los siguientes campos: ");

            if (String.IsNullOrWhiteSpace(txtNombre.Text))
            {
                resultado = false;
                st.AppendLine("Nombre");
            }
            if (String.IsNullOrWhiteSpace(txtApellido.Text))
            {
                resultado = false;
                st.AppendLine("Apellido");
            }

            if (!resultado)
            {
                MessageBox.Show(st.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return resultado;
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
            cmbMateria.Items.Add("Programación I");
            cmbMateria.Items.Add("Laboratorio de Computación I");
            cmbMateria.Items.Add("Sistema de procesamiento de datos");
            cmbMateria.Items.Add("Inglés I");
            cmbMateria.Items.Add("Matemática");
            cmbMateria.Items.Add("Programación II");
            cmbMateria.Items.Add("Laboratorio de Computación II");
            cmbMateria.Items.Add("Inglés II");
            cmbMateria.Items.Add("Metodología de la investigación");
            cmbMateria.Items.Add("Arquitectura y sistemas operativos");
            cmbMateria.Items.Add("Estadística");
            cmbMateria.SelectedIndex = 0;
        }
    }
}
