using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaEnlazadaS
{
    class Locomotora
    {
        Vagon Primero {  get; set; }
        public void AgregarPrimero(int valor)
        {
            Vagon nuevo = new Vagon(valor);

            if (Primero == null)
            {
                this.Primero = nuevo;
            }
            else
            {
                nuevo.Sig = this.Primero;
                this.Primero = nuevo;
                
            }

        }
        
        public void AgregaFinal(int valor)
        {
            Vagon nuevo = new Vagon(valor);
    
            if (Primero == null)
            {
                this.Primero = nuevo;
            }
            else
            {
                Vagon tmp = this.Primero;
                while (tmp.Sig != null)
                {
                    tmp = tmp.Sig;
                }
                tmp.Sig = nuevo;
            }


        }
        public void EliminarUltimo()
        {
            Vagon vagon = this.Primero;
            while (vagon.Sig.Sig != null)
            {
                vagon = vagon.Sig;
            }
            vagon.Sig = null;
        }
        public void EliminarPrimero()
        {
            this.Primero = this.Primero.Sig;
        }
        public string VerVagones()
        {
            string ListaVag = "";
            Vagon tmp = this.Primero;
            while (tmp != null)
            {
                ListaVag += tmp.Dato + ", ";
                tmp = tmp.Sig;
            }
            return ListaVag;
        }
    }

}
