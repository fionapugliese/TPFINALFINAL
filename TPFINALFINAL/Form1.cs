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
        List<cElectrodomesticos> lista_hermione;
        List<cElectrodomesticos> lista_draco;
        List<cElectrodomesticos> lista_harrypotter;
        List<cElectrodomesticos> lista_ron;
        List<cElectrodomesticos> lista_dobby;
        List<cElectrodomesticos> lista_Homero;
        List<cElectrodomesticos> lista_bart;
        List<cElectrodomesticos> lista_lisa;
        List<cElectrodomesticos> lista_magui;
        List<cElectrodomesticos> lista_marge;
        List<cElectrodomesticos> lista_meredith;
        List<cElectrodomesticos> lista_derek;
        List<cElectrodomesticos> lista_cristina;
        List<cElectrodomesticos> lista_izzie;
        List<cElectrodomesticos> lista_jackson;
        List<cElectrodomesticos> lista_alex;
        List<cElectrodomesticos> lista_miranda;
        List<cElectrodomesticos> lista_richard;
        List<cElectrodomesticos> lista_amelia;
        List<cElectrodomesticos> lista_gemma;
        List<cElectrodomesticos> lista_anne;
        List<cElectrodomesticos> lista_sheldon;
        List<cElectrodomesticos> lista_lottie;
        List<cElectrodomesticos> lista_lucky;
        List<cElectrodomesticos> lista_rachel;
        List<cElectrodomesticos> lista_phoebe;
        List<cElectrodomesticos> lista_ross;
        List<cElectrodomesticos> lista_chandler;
        List<cElectrodomesticos> lista_monica;
       





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
        cPedido_por_Cliente pedido22;
        cPedido_por_Cliente pedido23;
        cPedido_por_Cliente pedido24;
        cPedido_por_Cliente pedido25;
        cPedido_por_Cliente pedido26;
        cPedido_por_Cliente pedido27;
        cPedido_por_Cliente pedido28;
        cPedido_por_Cliente pedido29;
        cPedido_por_Cliente pedido30;
        cPedido_por_Cliente pedido31;
        cPedido_por_Cliente pedido32;
        cPedido_por_Cliente pedido33;
        cPedido_por_Cliente pedido34;
        cPedido_por_Cliente pedido35;
        cPedido_por_Cliente pedido36;
        cPedido_por_Cliente pedido37;
        cPedido_por_Cliente pedido38;
        cPedido_por_Cliente pedido39;
        cPedido_por_Cliente pedido40;
        cPedido_por_Cliente pedido41;
        cPedido_por_Cliente pedido42;
        cPedido_por_Cliente pedido43;
        cPedido_por_Cliente pedido44;
        cPedido_por_Cliente pedido45;
        cPedido_por_Cliente pedido46;
        cPedido_por_Cliente pedido47;
        cPedido_por_Cliente pedido48;
        cPedido_por_Cliente pedido49;
        cPedido_por_Cliente pedido50;





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

             licuadora = new cPequeños_electrodomesticos(30, 20, 2, objetos.licuadora);
            rallador = new cPequeños_electrodomesticos(10, 30, 2, objetos.rallador);
             exprimidor = new cPequeños_electrodomesticos(10, 10, 2, objetos.exprimidor);
            cafetera = new cPequeños_electrodomesticos(50, 50, 2, objetos.cafetera);
             tostadora = new cPequeños_electrodomesticos(60, 20, 2, objetos.tostadora);
             cocina = new cLineaBlanca(70, 80, 4, objetos.cocinas);
             calefon = new cLineaBlanca(90, 50, 2, objetos.calefon);
             termotanque = new cLineaBlanca(80, 100, 3, objetos.termotanque);
            termotanque2 = new cLineaBlanca(80, 70, 3, objetos.termotanque);
            termotanque3 = new cLineaBlanca(80, 80, 3, objetos.termotanque);
            lavarropas = new cLineaBlanca(40, 60, 1, objetos.lavarropas);
             secarropas = new cLineaBlanca(30, 90, 2, objetos.lavarropas);
             comptadora = new cElectronicos(10, 20, 2, objetos.computadoras);
             impresora = new cElectronicos(20, 60, 3, objetos.impresoras);
            impresora2 = new cElectronicos(20, 30, 3, objetos.impresoras);
            impresora3 = new cElectronicos(20, 40, 3, objetos.impresoras);
            accesorios = new cElectronicos(10, 20, 1, objetos.accesorios);
             televisor = new cTelevisores(10, 60, 2, objetos.telvisores);

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

            lista_hermione = new List<cElectrodomesticos>();
            lista_hermione.Add(licuadora);
            lista_hermione.Add(televisor);
            lista_hermione.Add(exprimidor);

            lista_draco = new List<cElectrodomesticos>();
            lista_draco.Add(rallador);
            lista_draco.Add(cafetera);

            lista_harrypotter = new List<cElectrodomesticos>();
            lista_harrypotter.Add(exprimidor);
            lista_harrypotter.Add(comptadora);
            lista_harrypotter.Add(secarropas);

            lista_ron = new List<cElectrodomesticos>();
            lista_ron.Add(licuadora);
            lista_ron.Add(cocina);
            lista_ron.Add(tostadora);

            lista_dobby = new List<cElectrodomesticos>();
            lista_dobby.Add(lavarropas);
            lista_dobby.Add(calefon);
            lista_dobby.Add(impresora);

            lista_Homero = new List<cElectrodomesticos>();
            lista_Homero.Add(cocina);
            lista_Homero.Add(termotanque);
            lista_Homero.Add(comptadora);
            lista_Homero.Add(impresora);
            lista_Homero.Add(calefon);
            lista_Homero.Add(lavarropas);

            lista_bart = new List<cElectrodomesticos>();
            lista_bart.Add(secarropas);
            lista_bart.Add(accesorios);

            lista_lisa = new List<cElectrodomesticos>();
            lista_lisa.Add(rallador);
            lista_lisa.Add(calefon);
            lista_lisa.Add(impresora);
            lista_lisa.Add(cocina);
            lista_lisa.Add(tostadora);

            lista_magui = new List<cElectrodomesticos>();
            lista_magui.Add(exprimidor);
            lista_magui.Add(comptadora);
            lista_magui.Add(secarropas);
            lista_magui.Add(licuadora);
            lista_magui.Add(cocina);
            lista_magui.Add(tostadora);

            lista_marge = new List<cElectrodomesticos>();
            lista_marge.Add(rallador);
            lista_marge.Add(cafetera);




            lista_meredith = new List<cElectrodomesticos>();
            lista_meredith.Add(rallador);
            lista_meredith.Add(cocina);
            lista_meredith.Add(lavarropas);

            lista_derek = new List<cElectrodomesticos>();
            lista_derek.Add(licuadora);

            lista_cristina = new List<cElectrodomesticos>();
            lista_cristina.Add(cocina);
            lista_cristina.Add(accesorios);

            lista_izzie = new List<cElectrodomesticos>();
            lista_izzie.Add(termotanque);
            lista_izzie.Add(secarropas);
            lista_izzie.Add(lavarropas);

            lista_jackson = new List<cElectrodomesticos>();
            lista_jackson.Add(comptadora);
            lista_jackson.Add(termotanque);
            lista_jackson.Add(accesorios);

            lista_alex = new List<cElectrodomesticos>();
            lista_alex.Add(lavarropas);
            lista_alex.Add(cocina);
            lista_alex.Add(termotanque);

            lista_miranda = new List<cElectrodomesticos>();
            lista_miranda.Add(accesorios);


            lista_richard = new List<cElectrodomesticos>();
            lista_richard.Add(impresora);
            lista_richard.Add(tostadora);

            lista_amelia = new List<cElectrodomesticos>();
            lista_amelia.Add(rallador);
            lista_amelia.Add(licuadora);
            lista_amelia.Add(impresora);
            lista_amelia.Add(accesorios);



            lista_lottie = new List<cElectrodomesticos>();
            lista_lottie.Add(calefon);
            lista_lottie.Add(lavarropas);

            lista_lucky = new List<cElectrodomesticos>();
            lista_lucky.Add(lavarropas);
            lista_lucky.Add(secarropas);

            lista_gemma = new List<cElectrodomesticos>();
            lista_gemma.Add(cocina);
            lista_gemma.Add(calefon);
            lista_gemma.Add(termotanque);

            lista_anne = new List<cElectrodomesticos>();
            lista_anne.Add(lavarropas);
            lista_anne.Add(cocina);
            lista_anne.Add(secarropas);

            lista_sheldon = new List<cElectrodomesticos>();
            lista_sheldon.Add(secarropas);
            lista_sheldon.Add(cocina);
            lista_sheldon.Add(lavarropas);



            lista_rachel = new List<cElectrodomesticos>();
            lista_rachel.Add(calefon);
            lista_rachel.Add(lavarropas);

            lista_phoebe = new List<cElectrodomesticos>();
            lista_phoebe.Add(lavarropas);
            lista_phoebe.Add(secarropas);

            lista_ross = new List<cElectrodomesticos>();
            lista_ross.Add(cocina);
            lista_ross.Add(calefon);
            lista_ross.Add(termotanque);

            lista_chandler = new List<cElectrodomesticos>();
            lista_chandler.Add(lavarropas);
            lista_chandler.Add(cocina);
            lista_chandler.Add(secarropas);

            lista_monica = new List<cElectrodomesticos>();
            lista_monica.Add(secarropas);
            lista_monica.Add(cocina);
            lista_monica.Add(lavarropas);





            pedido1 = new cPedido_por_Cliente("Taylor Swift", eLocalidad.VicenteLopez, lista_taylor, entrega.express);
            pedido2 = new cPedido_por_Cliente("Sabrina Carpenter", eLocalidad.LaBoca, lista_sabrina, entrega.express);
            pedido3 = new cPedido_por_Cliente("Olivia Rodrigo", eLocalidad.Palermo, lista_olivia, entrega.express);
            pedido4 = new cPedido_por_Cliente("Harry Styles", eLocalidad.Caballito, lista_harry, entrega.express);
            pedido5 = new cPedido_por_Cliente("Louis Tomlinson", eLocalidad.Chacarita, lista_louis, entrega.express);
            pedido6 = new cPedido_por_Cliente("Niall Horan", eLocalidad.Belgrano, lista_niall, entrega.diferido);
            pedido7 = new cPedido_por_Cliente("Joshua Basset", eLocalidad.Lanus, lista_joshua, entrega.diferido);
            pedido8 = new cPedido_por_Cliente("Dove Cameron", eLocalidad.Liniers, lista_dove, entrega.diferido);
            pedido9 = new cPedido_por_Cliente("Luke Hemmings", eLocalidad.VillaLugano, lista_luke, entrega.diferido);
            pedido10 = new cPedido_por_Cliente("Isaac Anderson", eLocalidad.Versalles, lista_isaac, entrega.diferido);
            pedido11 = new cPedido_por_Cliente("Mitch Rowland", eLocalidad.VillaDevoto, lista_mitch, entrega.diferido);
            pedido12 = new cPedido_por_Cliente("Sarah Jones", eLocalidad.TresdeFebrero, lista_sarah, entrega.diferido);
            pedido13 = new cPedido_por_Cliente("Larry Stylinson", eLocalidad.Retiro, lista_larry, entrega.diferido);
            pedido14 = new cPedido_por_Cliente("Zayn Malik", eLocalidad.ParqueAvellaneda, lista_zayn, entrega.normal);
            pedido15 = new cPedido_por_Cliente("Tom Burguess", eLocalidad.Chacarita, lista_tom, entrega.normal);
            pedido16 = new cPedido_por_Cliente("Patrik Hazelwood", eLocalidad.Flores, lista_patrik, entrega.normal);
            pedido17 = new cPedido_por_Cliente("David Dawson", eLocalidad.VelezSarsfield, lista_david, entrega.normal);
            pedido18 = new cPedido_por_Cliente("Emma Corin", eLocalidad.Avellaneda, lista_emma, entrega.normal);
            pedido19 = new cPedido_por_Cliente("Florence Pugh", eLocalidad.Palermo, lista_florence, entrega.normal);
            pedido20 = new cPedido_por_Cliente("Jack Chambers", eLocalidad.MonteCastro, lista_jack, entrega.normal);
            pedido21 = new cPedido_por_Cliente("Alice Chambers", eLocalidad.Mataderos, lista_alice, entrega.normal);
            pedido22 = new cPedido_por_Cliente("Hermione Granger", eLocalidad.VelezSarsfield, lista_hermione, entrega.express);
            pedido23 = new cPedido_por_Cliente("Draco Malfoy", eLocalidad.Avellaneda, lista_draco, entrega.express);
            pedido24 = new cPedido_por_Cliente("Harry Potter", eLocalidad.LaMatanza, lista_harrypotter, entrega.normal);
            pedido25 = new cPedido_por_Cliente("Ron Weasley", eLocalidad.MonteCastro, lista_ron, entrega.express);
            pedido26 = new cPedido_por_Cliente("Dobby", eLocalidad.Mataderos, lista_dobby, entrega.express);
            pedido27 = new cPedido_por_Cliente("Homero Simpson", eLocalidad.VelezSarsfield, lista_Homero, entrega.express);
            pedido28 = new cPedido_por_Cliente("Bart Simpson", eLocalidad.Avellaneda, lista_lisa, entrega.express);
            pedido29 = new cPedido_por_Cliente("Lisa Simpson", eLocalidad.MonteCastro, lista_bart, entrega.normal);
            pedido30 = new cPedido_por_Cliente("Magui Simpson", eLocalidad.MonteCastro, lista_magui, entrega.express);
            pedido31 = new cPedido_por_Cliente("Marge Simpson", eLocalidad.Mataderos, lista_marge, entrega.express);
            pedido32 = new cPedido_por_Cliente("Meredith Grey", eLocalidad.ParqueAvellaneda, lista_meredith, entrega.diferido);
            pedido33 = new cPedido_por_Cliente("Derek Shephard", eLocalidad.TresdeFebrero, lista_derek, entrega.diferido);
            pedido34 = new cPedido_por_Cliente("Cristina Yang", eLocalidad.ParqueAvellaneda, lista_cristina, entrega.normal);
            pedido35 = new cPedido_por_Cliente("Izzie Stevens", eLocalidad.VicenteLopez, lista_izzie, entrega.normal);
            pedido36 = new cPedido_por_Cliente("Jackson Avery", eLocalidad.Chacarita, lista_jackson, entrega.express);
            pedido37 = new cPedido_por_Cliente("Alex Karev", eLocalidad.ParqueAvellaneda, lista_alex, entrega.normal);
            pedido38 = new cPedido_por_Cliente("Miranda Bailey", eLocalidad.Palermo, lista_miranda, entrega.normal);
            pedido39 = new cPedido_por_Cliente("Richard Webber", eLocalidad.LomasdeZamora, lista_richard, entrega.normal);
            pedido40 = new cPedido_por_Cliente("Amelia Shephard", eLocalidad.Avellaneda, lista_amelia, entrega.express);
            pedido41 = new cPedido_por_Cliente("Gemma Styles", eLocalidad.Chacarita, lista_gemma, entrega.express);
            pedido42 = new cPedido_por_Cliente("Anne Cox", eLocalidad.LomasdeZamora, lista_anne, entrega.diferido);
            pedido43 = new cPedido_por_Cliente("Lottie Tomlinson", eLocalidad.Mataderos, lista_lottie, entrega.diferido);
            pedido44 = new cPedido_por_Cliente("Lucky Tolinson", eLocalidad.VillaDevoto, lista_lucky, entrega.normal);
            pedido45 = new cPedido_por_Cliente("Sheldon Cooper", eLocalidad.Versalles, lista_sheldon, entrega.normal);
            pedido46 = new cPedido_por_Cliente("Rachel Green", eLocalidad.Chacarita, lista_rachel, entrega.diferido);
            pedido47 = new cPedido_por_Cliente("Phoebe Buffay ", eLocalidad.ParqueAvellaneda, lista_phoebe, entrega.express);
            pedido48 = new cPedido_por_Cliente("Ross Geller", eLocalidad.Palermo, lista_ross, entrega.diferido);
            pedido49 = new cPedido_por_Cliente("Chandler Bing", eLocalidad.LomasdeZamora, lista_chandler, entrega.diferido);
            pedido50 = new cPedido_por_Cliente("Monica Geller", eLocalidad.Avellaneda, lista_monica, entrega.diferido);


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
            lista_pedidos.Add(pedido22);
            lista_pedidos.Add(pedido23);
            lista_pedidos.Add(pedido24);
            lista_pedidos.Add(pedido25);
            lista_pedidos.Add(pedido26);
            lista_pedidos.Add(pedido27);
            lista_pedidos.Add(pedido28);
            lista_pedidos.Add(pedido29);
            lista_pedidos.Add(pedido30);
            lista_pedidos.Add(pedido31);
            lista_pedidos.Add(pedido32);
            lista_pedidos.Add(pedido33);
            lista_pedidos.Add(pedido34);
            lista_pedidos.Add(pedido35);
            lista_pedidos.Add(pedido36);
            lista_pedidos.Add(pedido37);
            lista_pedidos.Add(pedido38);
            lista_pedidos.Add(pedido39);
            lista_pedidos.Add(pedido40);
            lista_pedidos.Add(pedido41);
            lista_pedidos.Add(pedido42);
            lista_pedidos.Add(pedido43);
            lista_pedidos.Add(pedido44);
            lista_pedidos.Add(pedido45);
            lista_pedidos.Add(pedido46);
            lista_pedidos.Add(pedido47);
            lista_pedidos.Add(pedido48);
            lista_pedidos.Add(pedido49);
            lista_pedidos.Add(pedido50);

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
            int cantvolumen = 0;
            int cantpeso = 0;
            while (cont_camiones < max_viajes && this.lista_pedidos.Count != 0)
            {//hasta que no haya mas camiones o haya despachado todos los productos
                if(camion.GetType()==typeof(cCamioneta))
                camion.elevador = false;

                cantvolumen = 0;
                cantpeso = 0;
                caminomascorto = cosimundo.despacho_de_productos(this.lista_pedidos, pedido_a_entregar, camion); //calculo el mejor camino, y despacho todos los paquetes posibles, dandole prioridad a los express
                cont_camiones++;//se lleno el camion anterior, uso el siguiente
               
                for(int i = 0; i < pedido_a_entregar.Count; i++)
                {
                    cantvolumen = cantvolumen + pedido_a_entregar[i].volumen;
                }
              
                TreeNode Nodo_padre = new TreeNode(camion.ToString());
                Nodo_padre.Nodes.Add("Volumen Maximo Camion: ");
                Nodo_padre.Nodes.Add( camion.volumen_max.ToString());
                Nodo_padre.Nodes.Add("Volumen De Cargado: ");
                Nodo_padre.Nodes.Add(cantvolumen.ToString());

                for (int i = 0; i < pedido_a_entregar.Count; i++)
                {
                    cantpeso = cantpeso + pedido_a_entregar[i].peso_pedido;
                }

                Nodo_padre.Nodes.Add("Peso Maximo Camion: ");
                Nodo_padre.Nodes.Add(camion.peso_max.ToString());
                Nodo_padre.Nodes.Add("Peso De Cargado: ");
                Nodo_padre.Nodes.Add(cantpeso.ToString());

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
