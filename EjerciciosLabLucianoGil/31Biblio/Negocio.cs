using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31Biblio
{
    public class Negocio
    {
        PuestoAtencion caja;
        Queue<Cliente> clientes;
        public Cliente Cliente
        {
            get{ return clientes.Dequeue(); }

            set {  bool a = (this + value); }
        }
        public int ClientesPendientes { get{ return this.clientes.Count; } }
        private Negocio()
        {
            this.caja = new PuestoAtencion(PuestoAtencion.Puestos.Caja1);
            this.clientes = new Queue<Cliente>();
        }

        public static bool operator +(Negocio nego, Cliente clien)
        {
            List<Cliente> l = nego.clientes.ToList();
            foreach (Cliente c in l)
            {
                if (clien == c)
                    return false;
            }
            nego.clientes.Enqueue(clien);
            return true;
        }

        public static bool operator ==(Negocio nego, Cliente clien)
        {
            foreach (Cliente c in nego.clientes)
            {
                if (clien == c)
                    return true;
            }
            return false;
        }
        public static bool operator !=(Negocio nego, Cliente clien)
        {
            return !(nego == clien);
        }
        public static bool operator ~(Negocio n)
        {
            Cliente c = n.clientes.Dequeue();
            bool b = n.caja.Atender(c);
            return true;

        }
    }
}
