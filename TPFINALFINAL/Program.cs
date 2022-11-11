using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPFINALFINAL
{
    static class Constants
    {
        public const int max_index = 10000;
        public const int volumen_electro_pequeños = 50; //cambiar volumen real
        public const int televisores = 2 * 1 * 2; //cambiar volumen real
        public const int volumen_elevador = 50; //cambiar volumen real
        public const int peso_elevador = 50; //cambiar volumen real

    }

    //enums 
    public enum eLocalidad { Liniers, TresdeFebrero, SanMartin, VicenteLopez, LaMatanza, LomasdeZamora, Lanus, Avellaneda, Versalles, VillaLuro, Mataderos, MonteCastro, VelezSarsfield, ParqueAvellaneda, VillaLugano, VillaDevoto, VillaUrquiza, Belgrano, Palermo, Retiro, Caballito, Flores, PuertoMadero, LaBoca, Chacarita };
    public enum eOpcion { se_lleno_completo_, se_lleno_pero_quedaron_cosas_de_la_localidad, no_se_lleno };
    public enum entrega { express, normal, diferido };
    public enum objetos { licuadora, exprimidor, rallador, tostadora, cafetera, molinillos, cocinas, calefon, termotanque, lavarropas, secarropas, heladera, microondas, freezer, computadoras, impresoras, accesorios, telvisores };
    public enum eTipoProducto { linea_blanca, pequeños_electrodomesticos, electronicos, televisores }

    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
