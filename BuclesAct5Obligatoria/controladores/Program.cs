using BuclesAct5Obligatoria.servicios;

namespace BuclesAct5Obligatoria
{
    class program
    {
        public static void Main(string[] args)
        {
            /* Se creara los objetos de los metodos
             * tambien se definira la variable string seleccion
             */
            pedidaDeDatosInterfaz pdd = new pedidaDeDatosImplementacion();
            operativaInterfaz oi = new operativaImplementacion();
            menuContinuarInterfaz mc = new menuContinuarImplementacion();
            string seleccion;
            do
            {
                int mes = pdd.pedidaDeMes();
                int anyo = pdd.pedidaDeAnyo();
                oi.operativaCalculo(mes, anyo);
                seleccion = mc.menuContinuar();
            } while (seleccion == "s"); 
        }
    }
}
