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
    public partial class frmBaseDeDatos : Form
    {
        public frmBaseDeDatos()
        {
            InitializeComponent();
        }
        clsBaseDatos objBaseDatos = new clsBaseDatos(); 
        private void btnProyecSimple_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT titulo FROM libro ORDER BY 1 DESC";
            objBaseDatos.Listar(dgvConsulta, varSQL);
        }

        private void btnInterseccion_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT * FROM libro WHERE idIdioma = 2   AND idlibro IN (SELECT idlibro FROM libro WHERE Idpais = 3) ORDER BY 1 ASC";

            objBaseDatos.Listar(dgvConsulta, varSQL);
        }

        private void btnProyecMulti_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT titulo, autor FROM libro";

            objBaseDatos.Listar(dgvConsulta, varSQL);
        }

        private void btnSelecSimple_Click(object sender, EventArgs e)
        {
            

            String varSQL = "SELECT * FROM libro WHERE idAutor = 2 ";

            objBaseDatos.Listar(dgvConsulta, varSQL);
        }
    }
}
