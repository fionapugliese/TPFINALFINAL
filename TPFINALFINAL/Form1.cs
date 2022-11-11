using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPFINALFINAL
{
    public partial class Form1 : Form
    {
        cVehiculo camioneta;
        cVehiculo furgon ;
        cVehiculo furgoneta ;

        List<cVehiculo> lista_camiones;
        DateTime fecha;

        

        cElectrodomesticos licuadora ;
        cElectrodomesticos rallador ;
        cElectrodomesticos exprimidor ;
        cElectrodomesticos cafetera ;
        cElectrodomesticos tostadora ;
        cElectrodomesticos cocina ;
        cElectrodomesticos calefon ;
        cElectrodomesticos termotanque ;
        cElectrodomesticos lavarropas;
        cElectrodomesticos secarropas;
        cElectrodomesticos comptadora ;
        cElectrodomesticos impresora ;
        cElectrodomesticos accesorios ;
        cElectrodomesticos televisor;

        List<cElectrodomesticos> lista_taylor;
        List<cElectrodomesticos> lista_sabrina;
        List<cElectrodomesticos> lista_olivia;
        List<cElectrodomesticos> lista_harry;
        List<cElectrodomesticos> lista_louis;

        cPedido_por_Cliente pedido1;
        cPedido_por_Cliente pedido2;
        cPedido_por_Cliente pedido3;
        cPedido_por_Cliente pedido4;
        cPedido_por_Cliente pedido5;
     
        List<cPedido_por_Cliente> lista_pedidos;

        cCosiMundo cosimundo ;

       

        public Form1()
        {
             camioneta = new cCamioneta(2, 80, 5770000);
             furgon = new cFurgon(4, 90, 3950000);
             furgoneta = new cFurgoneta(9, 60, 2800000);

             lista_camiones = new List<cVehiculo>() { camioneta, furgon, furgoneta };

             licuadora = new cPequeños_electrodomesticos(30, 4, 2, objetos.licuadora);
           rallador = new cPequeños_electrodomesticos(10, 1, 2, objetos.rallador);
             exprimidor = new cPequeños_electrodomesticos(10, 3, 2, objetos.exprimidor);
            cafetera = new cPequeños_electrodomesticos(50, 4, 2, objetos.cafetera);
             tostadora = new cPequeños_electrodomesticos(60, 5, 2, objetos.tostadora);
             cocina = new cLineaBlanca(70, 40, 4, objetos.cocinas);
             calefon = new cLineaBlanca(90, 30, 2, objetos.calefon);
             termotanque = new cLineaBlanca(80, 20, 3, objetos.termotanque);
             lavarropas = new cLineaBlanca(40, 60, 1, objetos.lavarropas);
             secarropas = new cLineaBlanca(30, 60, 2, objetos.lavarropas);
             comptadora = new cElectronicos(10, 10, 2, objetos.computadoras);
             impresora = new cElectronicos(20, 20, 3, objetos.impresoras);
             accesorios = new cElectronicos(10, 5, 1, objetos.accesorios);
             televisor = new cTelevisores(10, 30, 2, objetos.telvisores);

             lista_taylor = new List<cElectrodomesticos>();
            lista_taylor.Add(licuadora);
            lista_taylor.Add(televisor);
            lista_taylor.Add(exprimidor);
             lista_sabrina = new List<cElectrodomesticos>();
            lista_sabrina.Add(rallador);
            lista_sabrina.Add(cafetera);
             lista_olivia = new List<cElectrodomesticos>();
            lista_olivia.Add(cocina);
            lista_olivia.Add(termotanque);
            lista_olivia.Add(comptadora);
            lista_olivia.Add(impresora);
            lista_harry = new List<cElectrodomesticos>();
            lista_harry.Add(calefon);
            lista_harry.Add(lavarropas);
             lista_louis = new List<cElectrodomesticos>();
            lista_louis.Add(secarropas);
            lista_louis.Add(accesorios);

         pedido1 = new cPedido_por_Cliente("Taylor Swift", eLocalidad.VicenteLopez, lista_taylor, entrega.express);
             pedido2 = new cPedido_por_Cliente("Sabrina Carpenter", eLocalidad.LaBoca, lista_sabrina, entrega.express);
             pedido3 = new cPedido_por_Cliente("Olivia Rodrigo", eLocalidad.Palermo, lista_olivia, entrega.express);
             pedido4 = new cPedido_por_Cliente("Harry Styles", eLocalidad.Caballito, lista_harry, entrega.express);
            pedido5 = new cPedido_por_Cliente("Louis Tomlinson", eLocalidad.Chacarita, lista_louis, entrega.normal);

           lista_pedidos = new List<cPedido_por_Cliente>();
            lista_pedidos.Add(pedido1);
            lista_pedidos.Add(pedido2);
            lista_pedidos.Add(pedido3);
            lista_pedidos.Add(pedido4);
            lista_pedidos.Add(pedido5);

             cosimundo = new cCosiMundo(lista_pedidos, lista_camiones);
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fecha = dia.Value;
            cosimundo.camiones_disponibles(fecha);
            cosimundo.preparo_y_desapacho_de_productos();

        }

        private void dia_ValueChanged(object sender, EventArgs e)
        {
            fecha = dia.Value;

            if(fecha.Day==1)
            {
                cosimundo.sumar_mes_camiones();
            }
        }
    }
}
