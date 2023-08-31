using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace PryEDFranco
{
    internal class clsCola
    {
        private clsNodo pri;
        private clsNodo ult;

        //prop
        public clsNodo Primero
        {
            get { return pri; }
            set { pri = value; }
        }
        public clsNodo Ultimo
        {
            get { return ult; }
            set { ult = value; }
        }
        //metodos
        public void Agregar(clsNodo Nuevo)
        {
            if (Primero == null)
            {
                Primero = Nuevo;
                Ultimo = Nuevo;

            }
            else
            {
                Ultimo.siguiente = Nuevo;
                Ultimo = Nuevo;

            }
            

        }
        public void Eliminar()
        {
            if (Primero == Ultimo)
            {
                Primero = null;
                Ultimo = null;
            }
            else
            {
                Primero = Primero.siguiente;
            }
        }
        public void Recorrer(DataGridView Grilla)
        {
            clsNodo aux = Primero;
            Grilla.Rows.Clear();
            while(aux != null)
            {
                Grilla.Rows.Add(aux.Codigo,aux.Nombre,aux.Tramite);
                aux = aux.siguiente;
            }

        }
        public void Recorrer (ListBox lista)
        {
            clsNodo aux = Primero;
            lista.Items.Clear();
            while (aux != null)
            {
                lista.Items.Add(aux.Codigo);
                aux = aux.siguiente;
            }
        }
        public void Recorrer()
        {
            clsNodo aux = Primero;
            StreamWriter AD = new StreamWriter("Cola.csv", false,Encoding.UTF8);
            AD.WriteLine("lista de espera\n");
            AD.WriteLine("Codigo;Nombre;tramite");
            while (aux != null)
            {
                AD.Write(aux.Codigo);
                AD.Write(";");
                AD.Write(aux.Nombre);
                AD.Write(";");
                AD.WriteLine(aux.Tramite);
                aux = aux.siguiente;

            }
            AD.Close();
        }
    }

}
