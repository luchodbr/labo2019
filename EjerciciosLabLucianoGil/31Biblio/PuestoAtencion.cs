using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31Biblio
{
    public class PuestoAtencion
    {
        static int numeroActual;

        private Puestos puesto;
        public Puestos Puesto
        {
            get { return puesto; }
        }


        static PuestoAtencion()
        {

        }





        public enum Puestos{Caja1,Caja2}
    }
}
