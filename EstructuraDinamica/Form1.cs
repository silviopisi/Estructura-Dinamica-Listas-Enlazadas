using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstructuraDinamica
{
    /*
        - Estructura de Datos Dinámica
        - Listas Enlazadas
        - Recursividad
     */
    public partial class Form1 : Form
    {
        ListaEnlazada list = new ListaEnlazada();
        public Form1()
        {
            InitializeComponent();
        }     
        public void AgregarItemLista(Nodo nodo)
        {
            if (nodo!=null)
            {
                listaEnlazada.Items.Add(nodo.Nombre);
                AgregarItemLista(nodo.Siguiente);
            }

        }
        public void MostrarLista()
        {
            listaEnlazada.Items.Clear();
            if(list.Inicio != null)
            {
                AgregarItemLista(list.Inicio);
            }
            
        }
        public void AgregarElemento(bool Inicio)
        {
            if (!string.IsNullOrEmpty(txtnombre.Text))
                return;
            Nodo nodo = new Nodo();
            nodo.Nombre = txtnombre.Text;
            if (Inicio)
            { 
                list.AgregarAlPrincipio(nodo); 
            }
            else
            {
                list.AgregarFinal(nodo);
            }
           MostrarLista();  

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAddStar_Click(object sender, EventArgs e)
        {
            AgregarElemento(true);                                                 
        }

        private void btnAddEnd_Click(object sender, EventArgs e)
        {
            AgregarElemento(false);  
        }
    }
}
