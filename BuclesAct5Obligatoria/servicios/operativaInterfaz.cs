using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuclesAct5Obligatoria.servicios
{
    /// <summary>
    /// Interfaz que se encarga de la operativa de la aplicacion
    /// </summary>
    internal interface operativaInterfaz
    {
        /// <summary>
        /// Metodo con las operaciones y la muestra en consola del resultado
        /// </summary>
        /// <param name="mes">Mes que le pasamos</param>
        /// <param name="anyo">Anyo que le pasamos</param>
        public void operativaCalculo(int mes, int anyo);
    }
}
