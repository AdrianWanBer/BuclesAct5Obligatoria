﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace BuclesAct5Obligatoria.servicios
{

    internal class operativaImplementacion : operativaInterfaz
    {
        /// <summary>
        /// Metodo de la operacion para saber cuantos dias tiene el mes
        /// <author>06112023 - awb</author>
        /// </summary>


        public void operativaCalculo(int mes, int anyo)
        {
            switch (mes)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine("El mes tiene 31 dias");
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("El mes tiene 30 dias");
                    break;
                case 2:
                    if ((anyo % 4 == 0 && anyo % 100 != 0) || (anyo % 400 == 0))
                    {
                        Console.WriteLine("El año mes tiene 29 dias");
                    } else
                    {
                        Console.WriteLine("El mes tiene 28 dias");
                    }
                    break;
            }
        }
    }
}
