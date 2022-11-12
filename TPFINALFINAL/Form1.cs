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
        cElectrodomesticos licuadora2;
        cElectrodomesticos licuadora3;
        cElectrodomesticos rallador ;
        cElectrodomesticos exprimidor ;
        cElectrodomesticos exprimidor2;
        cElectrodomesticos cafetera ;
        cElectrodomesticos tostadora ;
        cElectrodomesticos cocina ;
        cElectrodomesticos calefon ;
        cElectrodomesticos termotanque ;
        cElectrodomesticos termotanque2;
        cElectrodomesticos termotanque3;
        cElectrodomesticos lavarropas;
        cElectrodomesticos secarropas;
        cElectrodomesticos comptadora ;
        cElectrodomesticos impresora ;
        cElectrodomesticos impresora2;
        cElectrodomesticos impresora3;
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
        int cont_camiones;
        cVehiculo camion;
        List<eLocalidad> caminomascorto;

        public Form1()
        {
           
             camioneta = new cCamioneta(2, 80, 5770000);
             furgon = new cFurgon(4, 90, 3950000);
             furgoneta = new cFurgoneta(9, 60, 2800000);

            
             lista_camiones = new List<cVehiculo>() { camioneta, furgon, furgoneta };

             licuadora = new cPequeños_electrodomesticos(30, 4, 2, objetos.licuadora);
            licuadora2 = new cPequeños_electrodomesticos(30, 4, 2, objetos.licuadora);
            licuadora3 = new cPequeños_electrodomesticos(30, 4, 2, objetos.licuadora);
            rallador = new cPequeños_electrodomesticos(10, 1, 2, objetos.rallador);
             exprimidor = new cPequeños_electrodomesticos(10, 3, 2, objetos.exprimidor);
            exprimidor2 = new cPequeños_electrodomesticos(10, 3, 2, objetos.exprimidor);
            cafetera = new cPequeños_electrodomesticos(50, 4, 2, objetos.cafetera);
             tostadora = new cPequeños_electrodomesticos(60, 5, 2, objetos.tostadora);
             cocina = new cLineaBlanca(70, 40, 4, objetos.cocinas);
             calefon = new cLineaBlanca(90, 30, 2, objetos.calefon);
             termotanque = new cLineaBlanca(80, 20, 3, objetos.termotanque);
            termotanque2 = new cLineaBlanca(80, 20, 3, objetos.termotanque);
            termotanque3 = new cLineaBlanca(80, 20, 3, objetos.termotanque);
            lavarropas = new cLineaBlanca(40, 60, 1, objetos.lavarropas);
             secarropas = new cLineaBlanca(30, 60, 2, objetos.lavarropas);
             comptadora = new cElectronicos(10, 10, 2, objetos.computadoras);
             impresora = new cElectronicos(20, 20, 3, objetos.impresoras);
            impresora2 = new cElectronicos(20, 20, 3, objetos.impresoras);
            impresora3 = new cElectronicos(20, 20, 3, objetos.impresoras);
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
            
            cosimundo.camiones_disponibles(fecha); List<cPedido_por_Cliente> pedido_a_entregar = new List<cPedido_por_Cliente>();


            camion = this.lista_camiones.ElementAt(0); //siempre empezamos con la camioneta
             cont_camiones = 0;
            int max_viajes = cosimundo.max_viajes_por_dia();
            while (cont_camiones < max_viajes && this.lista_pedidos.Count != 0)
            {//hasta que no haya mas camiones o haya despachado todos los productos
                caminomascorto = cosimundo.despacho_de_productos(this.lista_pedidos, pedido_a_entregar, camion); //calculo el mejor camino, y despacho todos los paquetes posibles, dandole prioridad a los express
                cont_camiones++;//se lleno el camion anterior, uso el siguiente
                if (cont_camiones == 4) //seguimos con el furgon
                {
                    camion = this.lista_camiones.ElementAt(1);
                    cosimundo.CambiarVolumenTelevisoresFurgon();
                }
                if (cont_camiones == 5)//seguimos con la furgoneta
                {
                    camion = this.lista_camiones.ElementAt(2);
                    cosimundo.CambiarVolumenTelevisoresFurgoneta();
                }

                
               
                TreeNode Nodo_padre = new TreeNode(camion.ToString());

                foreach (var pedidos in pedido_a_entregar) {

                    Nodo_padre.Nodes.Add(new TreeNode(pedidos.nombre.ToString()));
 
                }
                treeView1.Nodes.Add(Nodo_padre);

                TreeNode Nodo_padre2 = new TreeNode(camion.ToString());

                foreach (var camino in caminomascorto)
                {
                    Nodo_padre2.Nodes.Add(new TreeNode(camino.ToString()));
                }
                treeView2.Nodes.Add(Nodo_padre2);
                
                pedido_a_entregar.RemoveRange(0, pedido_a_entregar.Count); //como los vamos entregando, borro la lista porque ya salio el camion

            }

            
        }

        private void dia_ValueChanged(object sender, EventArgs e)
        {
            fecha = dia.Value;

            if(fecha.Day==1)
            {
                cosimundo.sumar_mes_camiones();
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void treeView2_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cosimundo.modificarPedidos();
        }
    }
}
