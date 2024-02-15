using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazGrafica_Ejercicio13
{
    public partial class Form1 : Form
    {
        string nombre;
        string correo;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            nombre = txtNombre.Text;
            correo = txtCorreo.Text;

            if (txtNombre.Text == "" || txtCorreo.Text == "")
            {
                MessageBox.Show("Por favor, rellene todos los campos", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            { 
                dgvDatos.Rows.Add(nombre, correo);

                txtNombre.Clear();
                txtCorreo.Clear();
            }

            txtNombre.Focus();


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (dgvDatos.SelectedRows.Count < 0) 
            {
                MessageBox.Show("No hay datos para eliminar", "Tabla vacía", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

                int aa = dgvDatos.CurrentRow.Index;
            dgvDatos.Rows.RemoveAt(aa);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtCorreo.Clear();

            dgvDatos.Rows.Clear();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Desea salir de la aplicación?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (respuesta == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
