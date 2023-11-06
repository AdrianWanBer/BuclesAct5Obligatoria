using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuclesAct5Obligatoria.servicios
{
    /// <summary>
    /// Interfaz encargada de pedir los datos
    /// <author>06112023 - awb</author>
    /// </summary>
    internal interface pedidaDeDatosInterfaz
    {
        /// <summary>
        /// Metodo para pedir el mes
        /// <author>06112023 - awb</author>
        /// </summary>
        /// <returns>Numero entero</returns>
        public int pedidaDeMes();
        /// <summary>
        /// Metodo para pedir el mes
        /// <author>06112023 - awb</author>
        /// </summary>
        /// <returns>Numero entero</returns>
        public int pedidaDeAnyo();
    }
}
