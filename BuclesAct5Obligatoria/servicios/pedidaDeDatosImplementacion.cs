using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuclesAct5Obligatoria.servicios
{
    /// <summary>
    /// Creamos los metodos para pedir los datos al usuario
    /// <author>06112023 - awb</author>
    /// </summary>
    internal class pedidaDeDatosImplementacion : pedidaDeDatosInterfaz
    {
        /// <summary>
        /// Metodo de pedida del mes
        /// <author>06112023 - awb</author>
        /// </summary>
        /// <returns>Numero entero</returns>
        public int pedidaDeMes()
        {
            Console.WriteLine("Escribe un mes");
            int mes = Convert.ToInt32(Console.ReadLine());
            return mes;
        }
        /// <summary>
        /// Metodo de pedida de anyo
        /// <author>06112023 - awb</author>
        /// </summary>
        /// <returns>Numero entero</returns>
        public int pedidaDeAnyo()
        {
            Console.WriteLine("Escribe un año");
            int anyo = Convert.ToInt32(Console.ReadLine());
            return anyo;
        }
    }
}
