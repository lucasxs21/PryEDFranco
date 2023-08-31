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
    public partial class frmCola : Form
    {
        public frmCola()
        {
            InitializeComponent();
        }

        private void dgvCola_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        clsCola FilaDePersonas = new clsCola();
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
            FilaDePersonas.Recorrer(dgvCola);
            FilaDePersonas.Recorrer();
            FilaDePersonas.Recorrer(lstcola);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (FilaDePersonas.Primero != null)
            {
                lblCod.Text = FilaDePersonas.Primero.Codigo.ToString();
                lblNam.Text = FilaDePersonas.Primero.Nombre;
                lblTramite.Text=FilaDePersonas.Primero.Tramite;
                FilaDePersonas.Eliminar();
                FilaDePersonas.Recorrer(dgvCola);
                FilaDePersonas.Recorrer(lstcola);
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
