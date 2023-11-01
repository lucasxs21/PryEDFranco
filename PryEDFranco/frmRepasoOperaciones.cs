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
    public partial class frmRepasoOperaciones : Form
    {
        public frmRepasoOperaciones()
        {
            InitializeComponent();
        }
        clsBaseDatos ObjBaseDatos = new clsBaseDatos();
        String varSQL = "SELECT * FROM LIBRO";

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblCod_Click(object sender, EventArgs e)
        {

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            switch (cmbConsulta.SelectedIndex)
            {
                case 0:
                    lblCod.Text = cmbConsulta.Text + ": " + "Paises que no tienen libros";
                    varSQL = "SELECT * FROM PAIS WHERE IDPAIS NOT IN (SELECT IDPAIS FROM LIBRO)";
                    break;
                case 1:
                    lblCod.Text = cmbConsulta.Text + ": " + "Libros con ID menores a 20 y con un precio menor a 600";
                    varSQL = "SELECT * FROM LIBRO WHERE IDLIBRO < 20 " +
                        "INTERSECT " +
                        "SELECT * FROM LIBRO WHERE PRECIO < 600";
                    break;
                case 2:
                    varSQL = "SELECT * FROM LIBRO WHERE IDIDIOMA = 4 " +
                        "UNION " +
                        "SELECT * FROM LIBRO WHERE PRECIO < 600";
                    break;

            }

            ObjBaseDatos.Listar(dgvConsulta, varSQL);
        }
    }
}
