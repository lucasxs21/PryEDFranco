using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows;
using System.Windows.Forms;

namespace PryEDFranco
{
    class clsArbolBinario
    {
        //Creo el campo inicial del arbol. Lo llamamos raiz
        private clsNodo PrimerNodo;
        //Creo la unica propiedad que necesito.
        public clsNodo Raiz
        {
            get { return PrimerNodo; }
            set { PrimerNodo = value; }
        }
        public clsNodo BuscarCodigo(Int32 cod)
        {
            clsNodo Aux = Raiz;
            while (Aux != null)
            {
                if (cod == Aux.Codigo) break;
                if (cod < Aux.Codigo) Aux = Aux.Izquierdo;
                else Aux = Aux.Derecho;
            }
            return Aux;
        }
        public void Agregar(clsNodo Nvo)
        {
            Nvo.Izquierdo = null;
            Nvo.Derecho = null;
            if (Raiz == null)
            {
                Raiz = Nvo;
            }
            else
            {
                clsNodo NodoPadre = Raiz; //ant
                clsNodo Aux = Raiz;
                while (Aux != null)
                {
                    NodoPadre = Aux;
                    if (Nvo.Codigo < Aux.Codigo)
                    {
                        Aux = Aux.Izquierdo;
                    }
                    else
                    {
                        Aux = Aux.Derecho;
                    }
                }
                //Afuera del whil
                if (Nvo.Codigo < NodoPadre.Codigo)
                {
                    NodoPadre.Izquierdo = Nvo;
                }
                else
                {
                    NodoPadre.Derecho = Nvo;
                }
            }
        }
        private clsNodo[] Vector = new clsNodo[100];
        private Int32 i = 0;
        public void Equilibrar()
        {
            i = 0;
            GrabarVectorInOrden(Raiz);
            Raiz = null;
            EquilibrarArbol(0, i-1);
        }
        public void Eliminar(Int32 codigo)
        {
            i = 0;
            GrabarVectorInOrden(Raiz, codigo);
            Raiz = null;
            EquilibrarArbol(0, i-1);
        }
        private void EquilibrarArbol(Int32 ini, Int32 fin)
        {
            Int32 m = (ini + fin) / 2;
            if (ini <= fin)
            {
                Agregar(Vector[m]);
                EquilibrarArbol(ini, m-1);
                EquilibrarArbol(m + 1, fin);
            }
        }
        private void GrabarVectorInOrden(clsNodo NodoPadre)
        {
            if (NodoPadre.Izquierdo != null)
            {
                GrabarVectorInOrden(NodoPadre.Izquierdo);
            }
            Vector[i] = NodoPadre;
            i = i + 1;
            if (NodoPadre.Derecho != null)
            {
                GrabarVectorInOrden(NodoPadre.Derecho);
            }
        }
        private void GrabarVectorInOrden(clsNodo NodoPadre, Int32 Codigo)
        {
            if (NodoPadre.Izquierdo != null)
            {
                GrabarVectorInOrden(NodoPadre.Izquierdo, Codigo);
            }
            if (NodoPadre.Codigo != Codigo)
            {
                Vector[i] = NodoPadre;
                i = i + 1;
            }
            if (NodoPadre.Derecho != null)
            {
                GrabarVectorInOrden(NodoPadre.Derecho, Codigo);
            }
        }
        public void Recorrer(ComboBox Lista)
        {
            Lista.Items.Clear();
            InOrdenAsc(Lista, Raiz);
        }
        private void InOrdenAsc(ComboBox Lst, clsNodo R)
        {
            if (R.Izquierdo != null)
            {
                InOrdenAsc(Lst, R.Izquierdo);
            }
            Lst.Items.Add(R.Codigo);
            if (R.Derecho != null)
            {
                InOrdenAsc(Lst, R.Derecho);
            }
        }
        public void Recorrer(ListBox Lista)
        {
            Lista.Items.Clear();
            InOrdenAsc(Lista, Raiz);
        }
        public void InOrdenAsc(ListBox Lst, clsNodo R)
        {
            if (R.Izquierdo != null)
            {
                InOrdenAsc(Lst, R.Izquierdo);
            }
            Lst.Items.Add(R.Codigo);
            if (R.Derecho != null)
            {
                InOrdenAsc(Lst, R.Derecho);
            }
        }
        public void Recorrer(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            InOrdenAsc(Grilla, Raiz);
        }
        private void InOrdenAsc(DataGridView Dgv, clsNodo R)
        {
            if (R.Izquierdo != null) InOrdenAsc(Dgv, R.Izquierdo);
            Dgv.Rows.Add(R.Codigo);
            if (R.Derecho != null) InOrdenAsc(Dgv, R.Derecho);
        }
        public void InOrdenDesc(ListBox Lst, clsNodo R)
        {
            if (R.Derecho != null
            )
            {
                InOrdenDesc(Lst, R.Derecho);
            }
            Lst.Items.Add(R.Codigo);
            if (R.Izquierdo != null
            )
            {
                InOrdenDesc(Lst, R.Izquierdo);
            }
        }
        public void PreOrden(ListBox Lst, clsNodo R)
        {
            Lst.Items.Add(R.Codigo);
            if (R.Izquierdo != null
            )
            {
                PreOrden(Lst, R.Izquierdo);
            }
            if (R.Derecho != null
            )
            {
                PreOrden(Lst, R.Derecho);
            }
        }
        public void PostOrden(ListBox Lst, clsNodo R)
        {
            if (R.Izquierdo != null
            )
            {
                PostOrden(Lst, R.Izquierdo);
            }
            if (R.Derecho != null
            )
            {
                PostOrden(Lst, R.Derecho);
            }
            Lst.Items.Add(R.Codigo);
        }



        public void ExportarIn(DataGridView Grilla)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("arbolInOrden.txt", false))
                {
                    foreach (DataGridViewRow row in Grilla.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            // Escribe el valor de la celda en el archivo de texto
                            writer.Write(cell.Value.ToString() + "\t");
                        }
                        writer.WriteLine(); // Salta a la siguiente línea
                    }
                }
                MessageBox.Show("Datos guardados en el archivo de texto correctamente.");










            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los datos: " + ex.Message);
            }

        }

        public void ExportarPre(DataGridView Grilla)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("arbolPreOrden.txt", false))
                {
                    foreach (DataGridViewRow row in Grilla.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            // Escribe el valor de la celda en el archivo de texto
                            writer.Write(cell.Value.ToString() + "\t");
                        }
                        writer.WriteLine(); // Salta a la siguiente línea
                    }
                }
                MessageBox.Show("Datos guardados en el archivo de texto correctamente.");










            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los datos: " + ex.Message);
            }

        }

        public void ExportarPost(DataGridView Grilla)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("arbolPostOrden.txt", false))
                {
                    foreach (DataGridViewRow row in Grilla.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            // Escribe el valor de la celda en el archivo de texto
                            writer.Write(cell.Value.ToString() + "\t");
                        }
                        writer.WriteLine(); // Salta a la siguiente línea
                    }
                }
                MessageBox.Show("Datos guardados en el archivo de texto correctamente.");










            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los datos: " + ex.Message);
            }

        }





    }
}
