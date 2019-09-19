using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace _31Biblio
{
    public class PuestoAtencion
    {
        
        static int numeroActual;

        static int NumeroActual
        {
            get
            {
                PuestoAtencion.numeroActual++;
                return numeroActual;
            }
            
        }


        private Puestos puesto;
        public Puestos Puesto
        {
            get { return puesto; }
        }


        static PuestoAtencion()
        {
            PuestoAtencion.numeroActual = 0;
        }
        
        public PuestoAtencion(Puestos puest)
        {
            this.puesto = puest;
        }
        public bool Atender(Cliente cli)
        {
            Thread.Sleep(1000);
            return true;
        }


        public enum Puestos{Caja1,Caja2}
    }
}
