using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuclesAct5Obligatoria.servicios
{
    internal class menuContinuarImplementacion : menuContinuarInterfaz
    {
        public string menuContinuar()
        {
            Console.WriteLine("Si quiere hacer otra peticion pulse la tecla ( s )");
            string decision = Console.ReadLine();
            return decision;
        }
    }
}
