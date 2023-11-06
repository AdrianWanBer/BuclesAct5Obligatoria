using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuclesAct5Obligatoria.servicios
{
    internal class pedidaDeDatosImplementacion : pedidaDeDatosInterfaz
    {
        public int pedidaDeMes()
        {
            Console.WriteLine("Escribe un mes");
            int mes = Convert.ToInt32(Console.ReadLine());
            return mes;
        }
        public int pedidaDeAnyo()
        {
            Console.WriteLine("Escribe un año");
            int anyo = Convert.ToInt32(Console.ReadLine());
            return anyo;
        }
    }
}
