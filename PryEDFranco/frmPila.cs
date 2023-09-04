using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryEDFranco
{
    public partial class frmPila : Form
    {
        public frmPila()
        {
            InitializeComponent();
        }

        private void dgvpila_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        clsPila FilaDePersonas = new clsPila();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo objNodo = new clsNodo();
            objNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            objNodo.Nombre = txtNombre.Text;
            objNodo.Tramite = txtTramite.Text;
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";


            FilaDePersonas.Agregar(objNodo);
            FilaDePersonas.Recorrer(dgvpila);
            FilaDePersonas.Recorrer();
            FilaDePersonas.Recorrer(lstpila);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (FilaDePersonas.Primero != null)
            {
                lblCod.Text = FilaDePersonas.Primero.Codigo.ToString();
                lblNam.Text = FilaDePersonas.Primero.Nombre;
                lblTramite.Text = FilaDePersonas.Primero.Tramite;
                FilaDePersonas.Eliminar();
                FilaDePersonas.Recorrer(dgvpila);
                FilaDePersonas.Recorrer(lstpila);
                FilaDePersonas.Recorrer();
            }
            else
            {
                lblCod.Text = "";
                lblNam.Text = "";
                lblTramite.Text = "";
            }
        }
    }
}
