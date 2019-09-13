using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _29Bibl;
namespace _29Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Jugador j1 = new Jugador(40, "ele",10,10);
            j1.GetPromedioGoles();
            Jugador j2 = new Jugador(30, "efe");
            Jugador j3 = new Jugador(20, "equis");
            Jugador j4 = new Jugador(40, "igual");

            Equipo eq = new Equipo(5, "mancos");
            
            if (eq + j1)
                Console.Write("agrego1"+j1.MostrarDatos());
            Console.ReadKey();
            if (eq + j2)
                Console.Write("agrego1");
            Console.ReadKey();
            if (eq + j3)
                Console.Write("agrego1");
            Console.ReadKey();
            if (eq + j4)
                Console.Write("agrego1");
            Console.ReadKey();
            
        }
    }
}
