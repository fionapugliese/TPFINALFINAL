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
        List<cElectrodomesticos> lista_niall;
        List<cElectrodomesticos> lista_joshua;
        List<cElectrodomesticos> lista_dove;
        List<cElectrodomesticos> lista_luke;
        List<cElectrodomesticos> lista_isaac;
        List<cElectrodomesticos> lista_mitch;
        List<cElectrodomesticos> lista_sarah;
        List<cElectrodomesticos> lista_larry;
        List<cElectrodomesticos> lista_zayn;
        List<cElectrodomesticos> lista_david;
        List<cElectrodomesticos> lista_emma;
        List<cElectrodomesticos> lista_florence;
        List<cElectrodomesticos> lista_tom;
        List<cElectrodomesticos> lista_patrik;
        List<cElectrodomesticos> lista_jack;
        List<cElectrodomesticos> lista_alice;


        cPedido_por_Cliente pedido1;
        cPedido_por_Cliente pedido2;
        cPedido_por_Cliente pedido3;
        cPedido_por_Cliente pedido4;
        cPedido_por_Cliente pedido5;
        cPedido_por_Cliente pedido6;
        cPedido_por_Cliente pedido7;
        cPedido_por_Cliente pedido8;
        cPedido_por_Cliente pedido9;
        cPedido_por_Cliente pedido10;
        cPedido_por_Cliente pedido11;
        cPedido_por_Cliente pedido12;
        cPedido_por_Cliente pedido13;
        cPedido_por_Cliente pedido14;
        cPedido_por_Cliente pedido15;
        cPedido_por_Cliente pedido16;
        cPedido_por_Cliente pedido17;
        cPedido_por_Cliente pedido18;
        cPedido_por_Cliente pedido19;
        cPedido_por_Cliente pedido20;
        cPedido_por_Cliente pedido21;

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
            rallador = new cPequeños_electrodomesticos(10, 1, 2, objetos.rallador);
             exprimidor = new cPequeños_electrodomesticos(10, 3, 2, objetos.exprimidor);
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

            lista_niall = new List<cElectrodomesticos>();
            lista_niall.Add(rallador);
            lista_niall.Add(calefon);
            lista_niall.Add(impresora);

            lista_joshua = new List<cElectrodomesticos>();
            lista_joshua.Add(exprimidor);
            lista_joshua.Add(tostadora);
            lista_joshua.Add(secarropas);

            lista_dove = new List<cElectrodomesticos>();
            lista_dove.Add(cafetera);
            lista_dove.Add(cocina);
            lista_dove.Add(termotanque);

            lista_luke = new List<cElectrodomesticos>();
            lista_luke.Add(termotanque);

            lista_isaac = new List<cElectrodomesticos>();
            lista_isaac.Add(tostadora);
            lista_isaac.Add(accesorios);

            lista_mitch = new List<cElectrodomesticos>();
            lista_mitch.Add(exprimidor);
            lista_mitch.Add(calefon);
            lista_mitch.Add(lavarropas);

            lista_sarah = new List<cElectrodomesticos>();
            lista_sarah.Add(comptadora);
            lista_sarah.Add(tostadora);
            lista_sarah.Add(licuadora);

            lista_larry = new List<cElectrodomesticos>();
            lista_larry.Add(lavarropas);
            lista_larry.Add(cocina);
            lista_larry.Add(termotanque);

            lista_zayn = new List<cElectrodomesticos>();
            lista_zayn.Add(lavarropas);

            lista_tom = new List<cElectrodomesticos>();
            lista_tom.Add(calefon);
            lista_tom.Add(exprimidor);

            lista_patrik = new List<cElectrodomesticos>();
            lista_patrik.Add(tostadora);
            lista_patrik.Add(accesorios);

            lista_emma = new List<cElectrodomesticos>();
            lista_emma.Add(lavarropas);
            lista_emma.Add(calefon);
            lista_emma.Add(impresora);

            lista_david = new List<cElectrodomesticos>();
            lista_david.Add(exprimidor);
            lista_david.Add(comptadora);
            lista_david.Add(secarropas);

            lista_florence = new List<cElectrodomesticos>();
            lista_florence.Add(licuadora);
            lista_florence.Add(cocina);
            lista_florence.Add(tostadora);

            lista_alice = new List<cElectrodomesticos>();
            lista_alice.Add(lavarropas);

            lista_jack = new List<cElectrodomesticos>();
            lista_jack.Add(licuadora);

            pedido1 = new cPedido_por_Cliente("Taylor Swift", eLocalidad.VicenteLopez, lista_taylor, entrega.express);
            pedido2 = new cPedido_por_Cliente("Sabrina Carpenter", eLocalidad.LaBoca, lista_sabrina, entrega.express);
            pedido3 = new cPedido_por_Cliente("Olivia Rodrigo", eLocalidad.Palermo, lista_olivia, entrega.express);
            pedido4 = new cPedido_por_Cliente("Harry Styles", eLocalidad.Caballito, lista_harry, entrega.express);
            pedido5 = new cPedido_por_Cliente("Louis Tomlinson", eLocalidad.Chacarita, lista_louis, entrega.express);
            pedido6 = new cPedido_por_Cliente("Niall Horan", eLocalidad.Belgrano, lista_niall, entrega.diferido);
            pedido7 = new cPedido_por_Cliente("Joshua Basset", eLocalidad.Lanus, lista_joshua, entrega.diferido);
            pedido8 = new cPedido_por_Cliente("Dove Cameron", eLocalidad.Liniers, lista_dove, entrega.diferido);
            pedido9 = new cPedido_por_Cliente("Luke Hemings", eLocalidad.VillaLugano, lista_luke, entrega.diferido);
            pedido10 = new cPedido_por_Cliente("Isaac Anderson", eLocalidad.Versalles, lista_isaac, entrega.diferido);
            pedido11 = new cPedido_por_Cliente("Mitch Rowland", eLocalidad.VillaDevoto, lista_mitch, entrega.diferido);
            pedido12 = new cPedido_por_Cliente("Sarah Jones", eLocalidad.TresdeFebrero, lista_sarah, entrega.diferido);
            pedido13 = new cPedido_por_Cliente("Larry Stylinson", eLocalidad.Retiro, lista_larry, entrega.diferido);
            pedido14 = new cPedido_por_Cliente("Zayn Malik", eLocalidad.ParqueAvellaneda, lista_zayn, entrega.normal);
            pedido15 = new cPedido_por_Cliente("Tom Police", eLocalidad.Chacarita, lista_tom, entrega.normal);
            pedido16 = new cPedido_por_Cliente("Patrik Art", eLocalidad.Flores, lista_patrik, entrega.normal);
            pedido17 = new cPedido_por_Cliente("David Dawson", eLocalidad.VelezSarsfield, lista_david, entrega.normal);
            pedido18 = new cPedido_por_Cliente("Emma Corin", eLocalidad.Avellaneda, lista_emma, entrega.normal);
            pedido19 = new cPedido_por_Cliente("Florence Pugh", eLocalidad.LaMatanza, lista_florence, entrega.normal);
            pedido20 = new cPedido_por_Cliente("Jack Chambers", eLocalidad.MonteCastro, lista_jack, entrega.normal);
            pedido21 = new cPedido_por_Cliente("Alice Chambers", eLocalidad.Mataderos, lista_alice, entrega.normal);


            lista_pedidos = new List<cPedido_por_Cliente>();
            lista_pedidos.Add(pedido1);
            lista_pedidos.Add(pedido2);
            lista_pedidos.Add(pedido3);
            lista_pedidos.Add(pedido4);
            lista_pedidos.Add(pedido5);
            lista_pedidos.Add(pedido6);
            lista_pedidos.Add(pedido7);
            lista_pedidos.Add(pedido8);
            lista_pedidos.Add(pedido9);
            lista_pedidos.Add(pedido10);
            lista_pedidos.Add(pedido11);
            lista_pedidos.Add(pedido12);
            lista_pedidos.Add(pedido13);
            lista_pedidos.Add(pedido14);
            lista_pedidos.Add(pedido15);
            lista_pedidos.Add(pedido16);
            lista_pedidos.Add(pedido17);
            lista_pedidos.Add(pedido18);
            lista_pedidos.Add(pedido19);
            lista_pedidos.Add(pedido20);
            lista_pedidos.Add(pedido21);

            cosimundo = new cCosiMundo(lista_pedidos, lista_camiones);
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fecha = dia.Value;
            cosimundo.camiones_disponibles(fecha);

            List<cPedido_por_Cliente> pedido_a_entregar = new List<cPedido_por_Cliente>();

            int max_viajes = cosimundo.max_viajes_por_dia();
            listView1.Items.Add("Camiones");
            listView1.Items.Add("Disponibles");
            listView1.Items.Add("Hoy: ");
            listView1.Items.Add(cosimundo.camionesdisponibles.Count.ToString());
           
            camion = cosimundo.camionesdisponibleshoy.ElementAt(0); //siempre empezamos con la camioneta
             cont_camiones = 0;
        
            while (cont_camiones < max_viajes && this.lista_pedidos.Count != 0)
            {//hasta que no haya mas camiones o haya despachado todos los productos
                caminomascorto = cosimundo.despacho_de_productos(this.lista_pedidos, pedido_a_entregar, camion); //calculo el mejor camino, y despacho todos los paquetes posibles, dandole prioridad a los express
                cont_camiones++;//se lleno el camion anterior, uso el siguiente
               
                
              
                TreeNode Nodo_padre = new TreeNode(camion.ToString());

                foreach (var pedidos in pedido_a_entregar) {

                    Nodo_padre.Nodes.Add(new TreeNode(pedidos.nombre.ToString()));
                    Nodo_padre.Nodes.Add(new TreeNode(pedidos.tipo_entrega.ToString()));

                }
                treeView1.Nodes.Add(Nodo_padre);

                TreeNode Nodo_padre2 = new TreeNode(camion.ToString());

                foreach (var camino in caminomascorto)
                {
                    Nodo_padre2.Nodes.Add(new TreeNode(camino.ToString()));
                }
                treeView2.Nodes.Add(Nodo_padre2);


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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
         

        }
    }
}
