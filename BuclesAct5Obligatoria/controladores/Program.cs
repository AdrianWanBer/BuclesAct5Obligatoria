using BuclesAct5Obligatoria.servicios;

namespace BuclesAct5Obligatoria
{
    class program
    {
        public static void Main(string[] args)
        {
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
