using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario
{
    public partial class FrmListaSuper : Form
    {
       
        private static string rutaArchivo;
        private List<string> listaSupermercado;

        static FrmListaSuper()
        {
            string rutaApplicationData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            const string nombreArchivo = "listaSupermercado.xml";
            rutaArchivo = Path.Combine(rutaApplicationData, nombreArchivo);
        }

        public FrmListaSuper()
        {
            InitializeComponent();
            listaSupermercado = new List<string>();
        }

        private void AgregarElemento()
        {
            FrmAltaModificacion frmAltaModificacion = new FrmAltaModificacion("Agregar Elemento", " ", "Agregar");
            frmAltaModificacion.ShowDialog();
            if (frmAltaModificacion.DialogResult == DialogResult.OK)
            {
                listaSupermercado.Add(frmAltaModificacion.Objeto);
                //AlmacenarCambios();
                //RefrescarLista();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un elemento de la lista.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void EliminarElemento()
        {
            string objetoSeleccionado = lstObjeto.SelectedItem as string;

            if (objetoSeleccionado is not null)
            {
                listaSupermercado.Remove(objetoSeleccionado);
                //AlmacenarCambios();
                //RefrescarLista();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un elemento de la lista.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ModificarElemento()
        {
            string objetoSeleccionado = lstObjeto.SelectedItem as string;
            FrmAltaModificacion frmAltaModificacion = new FrmAltaModificacion("Modificar objeto", objetoSeleccionado, "Agregar");
            frmAltaModificacion.ShowDialog();

            if (frmAltaModificacion.DialogResult == DialogResult.OK)
            {
                int indice = listaSupermercado.IndexOf(objetoSeleccionado);
                listaSupermercado[indice] = frmAltaModificacion.Objeto;
                //AlmacenarCambios();
                //RefrescarLista();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un elemento de la lista.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FrmListaSuper_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarElemento();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarElemento();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarElemento();
        }
    }
}
