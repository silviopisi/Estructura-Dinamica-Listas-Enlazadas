using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDinamica
{
    public  class ListaEnlazada
    {
        public Nodo Inicio;
        public void AgregarAlPrincipio(Nodo nodo)
        {
            if (Inicio == null)
            {
                Inicio = nodo;
            }
            else
            {
                Nodo Aux = Inicio;
                Inicio = nodo;
                Inicio.Siguiente = Aux;
            }

        }
        public void AgregarFinal(Nodo nodo)
        {
            if (Inicio == null)
            {
                Inicio = nodo;
            }
            else
            {
                Nodo Final = BuscarNodo(Inicio.Siguiente);
                Final.Siguiente = nodo;
            }

        }
        public Nodo BuscarNodo(Nodo nodo)
        {
            if(nodo.Siguiente == null)
            {
                return nodo;
            }
            else
            {
                return BuscarNodo(nodo.Siguiente);
            }
        }

    }
}
