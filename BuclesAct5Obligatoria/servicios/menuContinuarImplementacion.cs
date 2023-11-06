using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuclesAct5Obligatoria.servicios
{
    internal class menuContinuarImplementacion : menuContinuarInterfaz
    {
        /// <summary>
        /// Metodo para pedir al usuario si quiere continuar con la aplicación
        /// <author>06112023 - awb</author>
        /// </summary>
        /// <returns>String</returns>
        public string menuContinuar()
        {
            Console.WriteLine("Si quiere hacer otra peticion pulse la tecla ( s )");
            string decision = Console.ReadLine();
            return decision;
        }
    }
}
