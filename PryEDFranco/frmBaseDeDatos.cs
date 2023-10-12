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
            string Sql = "SELECT * FROM Libro WHERE idIdioma = 2 " +
                 " and in " +
                 "(SELECT * FROM Libro WHERE idIdioma = 7)";  

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

        private void btnJuntar_Click(object sender, EventArgs e)
        {
            string Sql = "SELECT Titulo, Nombre FROM libro, Pais  Where Libro.idlibro = Pais.IdPais ";

            

            objBaseDatos.Listar(dgvConsulta, Sql);
        }

        private void btnSelecMulti_Click(object sender, EventArgs e)
        {
            string Sql = "SELECT * FROM Libro WHERE idIdioma = 2 And idAutor = 2";
            objBaseDatos.Listar(dgvConsulta, Sql);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Sql = "SELECT * FROM (select * from libro Where idautor = 4 ) as x Where ididioma = 1 ";
            objBaseDatos.Listar(dgvConsulta, Sql);
        }

        private void btnUnion_Click(object sender, EventArgs e)
        {
            string Sql = "SELECT * FROM Libro WHERE idIdioma = 2" +
                " Union " +
                "SELECT * FROM Libro WHERE idIdioma = 7";
            objBaseDatos.Listar(dgvConsulta, Sql);
        }

        private void btnDiferencia_Click(object sender, EventArgs e)
        {
            string Sql = "SELECT * FROM Libro WHERE idIdioma = 2" +
                " and idLibro not in " +
                "(SELECT idLibro FROM Libro WHERE idpais = 3)";
            objBaseDatos.Listar(dgvConsulta, Sql);
        }
    }
}
