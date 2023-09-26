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
    public partial class frmArbolBinario : Form
    {
        public frmArbolBinario()
        {
            InitializeComponent();
        }
        clsArbolBinario ObjArbol = new clsArbolBinario();

        private void Arbol_Binario_Load(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void cmbEliminar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void optIn_CheckedChanged(object sender, EventArgs e)
        {
            ObjArbol.RecorrerIn(dgvLista);
        }

        private void optPre_CheckedChanged(object sender, EventArgs e)
        {
            ObjArbol.RecorrerPre(dgvLista);
        }

        private void optPost_CheckedChanged(object sender, EventArgs e)
        {
            ObjArbol.RecorrerPost(dgvLista);

        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (optIn.Checked)
            {
                ObjArbol.ExportarIn(dgvLista);
            }
            else
            {
                if (optPre.Checked)
                {
                    ObjArbol.ExportarPre(dgvLista);
                }
                else
                {
                    if (optPost.Checked)
                    {
                        ObjArbol.ExportarPost(dgvLista);
                    }
                    else
                    {
                        MessageBox.Show("Seleccione una opcion de ordenamiento", "", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void txtTramite_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigo.Text != null && txtNombre.Text != null && txtTramite.Text != null)
            {
                btnAgregar.Enabled = true;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo Persona = new clsNodo();
            Persona.Codigo = Convert.ToInt32(txtCodigo.Text);
            Persona.Nombre = txtNombre.Text;
            Persona.Tramite = txtTramite.Text;

            ObjArbol.Agregar(Persona);
            ObjArbol.RecorrerIn(dgvLista);
            ObjArbol.Recorrer(treeView1);

            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
            btnAgregar.Enabled = false;
        }
    }
    }
}
