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
    public partial class frmListaSimple : Form
    {
        public frmListaSimple()
        {
            InitializeComponent();
        }

        private void frmListaSimple_Load(object sender, EventArgs e)
        {

        }
        clsListaSimple FilaDePersonas = new clsListaSimple();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            clsNodo objNodo = new clsNodo();
            objNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            objNodo.Nombre = txtNombre.Text;
            objNodo.Tramite = txtTramite.Text;
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";


            FilaDePersonas.Agregar(objNodo);
            FilaDePersonas.Recorrer(dgvLista);
            FilaDePersonas.Recorrer();
            FilaDePersonas.Recorrer(cmbEliminar);
            FilaDePersonas.Recorrer(lstLista);
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            Int32 code = Convert.ToInt32(cmbEliminar.Text);
            if (FilaDePersonas.Primero != null)
            {

                FilaDePersonas.Eliminar1(code);
                FilaDePersonas.Recorrer(dgvLista);
                FilaDePersonas.Recorrer(lstLista);
                FilaDePersonas.Recorrer();
            }
            else
            {

            }
        }
    }
}
