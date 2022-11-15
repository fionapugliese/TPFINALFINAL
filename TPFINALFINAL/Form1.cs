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
        cVehiculo furgon;
        cVehiculo furgoneta;

        List<cVehiculo> lista_camiones;
        DateTime fecha;

        cElectrodomesticos licuadora;
        cElectrodomesticos licuadora2;
        cElectrodomesticos rallador;
        cElectrodomesticos exprimidor;
        cElectrodomesticos cafetera;
        cElectrodomesticos tostadora;
        cElectrodomesticos cocina;
        cElectrodomesticos calefon;
        cElectrodomesticos termotanque;
        cElectrodomesticos termotanque2;
        cElectrodomesticos termotanque3;
        cElectrodomesticos lavarropas;
        cElectrodomesticos secarropas;
        cElectrodomesticos comptadora;
        cElectrodomesticos impresora;
        cElectrodomesticos impresora2;
        cElectrodomesticos impresora3;
        cElectrodomesticos accesorios;
        cElectrodomesticos accesorios2;
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
        List<cElectrodomesticos> lista_kit;
        List<cElectrodomesticos> lista_joe;
        List<cElectrodomesticos> lista_nick;
        List<cElectrodomesticos> lista_charlie;
        List<cElectrodomesticos> lista_omar;
        List<cElectrodomesticos> lista_edvin;
        List<cElectrodomesticos> lista_alicek;
        List<cElectrodomesticos> lista_aliceo;
        List<cElectrodomesticos> lista_marisa;
        List<cElectrodomesticos> lista_jenn;
        List<cElectrodomesticos> lista_elena;
        List<cElectrodomesticos> lista_damon;
        List<cElectrodomesticos> lista_stefan;
        List<cElectrodomesticos> lista_jeremy;
        List<cElectrodomesticos> lista_bonnie;
        List<cElectrodomesticos> lista_caroline;
        List<cElectrodomesticos> lista_katherine;
        List<cElectrodomesticos> lista_klauss;
        List<cElectrodomesticos> lista_alarik;
        List<cElectrodomesticos> lista_matt;
        List<cElectrodomesticos> lista_ricky;
        List<cElectrodomesticos> lista_pachano;
        List<cElectrodomesticos> lista_moria;
        List<cElectrodomesticos> lista_susana;
        List<cElectrodomesticos> lista_conrad;
        List<cElectrodomesticos> lista_jeremia;
        List<cElectrodomesticos> lista_dardo;
        List<cElectrodomesticos> lista_pepe;
        List<cElectrodomesticos> lista_moni;
        List<cElectrodomesticos> lista_coqui;
        List<cElectrodomesticos> lista_paola;
        List<cElectrodomesticos> lista_mariaelena;
        List<cElectrodomesticos> lista_Simon;
        List<cElectrodomesticos> lista_jace;
        List<cElectrodomesticos> lista_clary;
        List<cElectrodomesticos> lista_alec;
        List<cElectrodomesticos> lista_izzy;
        List<cElectrodomesticos> lista_tessa;
        List<cElectrodomesticos> lista_will;
        List<cElectrodomesticos> lista_james;
        List<cElectrodomesticos> lista_emmacas;
        List<cElectrodomesticos> lista_elsa;
        List<cElectrodomesticos> lista_blanca;
        List<cElectrodomesticos> lista_cenicienta;
        List<cElectrodomesticos> lista_rapunzel;
        List<cElectrodomesticos> lista_tiana;
        List<cElectrodomesticos> lista_bellad;
        List<cElectrodomesticos> lista_byb;
        List<cElectrodomesticos> lista_ariel;
        List<cElectrodomesticos> lista_mulan;
        List<cElectrodomesticos> lista_shrek;
        List<cElectrodomesticos> lista_fiona;
        List<cElectrodomesticos> lista_burro;
        List<cElectrodomesticos> lista_bellahadid;
        List<cElectrodomesticos> lista_gigihadid;
        List<cElectrodomesticos> lista_jesus;
        List<cElectrodomesticos> lista_maria;
        List<cElectrodomesticos> lista_jose;
        List<cElectrodomesticos> lista_selena;
        List<cElectrodomesticos> lista_justin;
        List<cElectrodomesticos> lista_hailey;
        List<cElectrodomesticos> lista_calloom;
        List<cElectrodomesticos> lista_ashton;
        List<cElectrodomesticos> lista_michael;
        List<cElectrodomesticos> lista_lorelai ;
        List<cElectrodomesticos> lista_rory ;
        List<cElectrodomesticos> lista_dean ;
        List<cElectrodomesticos> lista_jess ;
        List<cElectrodomesticos> lista_logan ;



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
        cPedido_por_Cliente pedido51;
        cPedido_por_Cliente pedido52;
        cPedido_por_Cliente pedido53;
        cPedido_por_Cliente pedido54;
        cPedido_por_Cliente pedido55;
        cPedido_por_Cliente pedido56;
        cPedido_por_Cliente pedido57;
        cPedido_por_Cliente pedido58;
        cPedido_por_Cliente pedido59;
        cPedido_por_Cliente pedido60;
        cPedido_por_Cliente pedido61;
        cPedido_por_Cliente pedido62;
        cPedido_por_Cliente pedido63;
        cPedido_por_Cliente pedido64;
        cPedido_por_Cliente pedido65;
        cPedido_por_Cliente pedido66;
        cPedido_por_Cliente pedido67;
        cPedido_por_Cliente pedido68;
        cPedido_por_Cliente pedido69;
        cPedido_por_Cliente pedido70;
        cPedido_por_Cliente pedido71;
        cPedido_por_Cliente pedido72;
        cPedido_por_Cliente pedido73;
        cPedido_por_Cliente pedido74;
        cPedido_por_Cliente pedido75;
        cPedido_por_Cliente pedido76;
        cPedido_por_Cliente pedido77;
        cPedido_por_Cliente pedido78;
        cPedido_por_Cliente pedido79;
        cPedido_por_Cliente pedido80;
        cPedido_por_Cliente pedido81;
        cPedido_por_Cliente pedido82;
        cPedido_por_Cliente pedido83;
        cPedido_por_Cliente pedido84;
        cPedido_por_Cliente pedido85;
        cPedido_por_Cliente pedido86;
        cPedido_por_Cliente pedido87;
        cPedido_por_Cliente pedido88;
        cPedido_por_Cliente pedido89;
        cPedido_por_Cliente pedido90;
        cPedido_por_Cliente pedido91;
        cPedido_por_Cliente pedido92;
        cPedido_por_Cliente pedido93;
        cPedido_por_Cliente pedido94;
        cPedido_por_Cliente pedido95;
        cPedido_por_Cliente pedido96;
        cPedido_por_Cliente pedido97;
        cPedido_por_Cliente pedido98;
        cPedido_por_Cliente pedido99;
        cPedido_por_Cliente pedido100;
        cPedido_por_Cliente pedido101;
        cPedido_por_Cliente pedido102;
        cPedido_por_Cliente pedido103;
        cPedido_por_Cliente pedido104;
        cPedido_por_Cliente pedido105;
        cPedido_por_Cliente pedido106;
        cPedido_por_Cliente pedido107;
        cPedido_por_Cliente pedido108;
        cPedido_por_Cliente pedido109;
        cPedido_por_Cliente pedido110;
        cPedido_por_Cliente pedido111;
        cPedido_por_Cliente pedido112;
        cPedido_por_Cliente pedido113;
        cPedido_por_Cliente pedido114;
        cPedido_por_Cliente pedido115;
        cPedido_por_Cliente pedido116;
        cPedido_por_Cliente pedido117;
        cPedido_por_Cliente pedido118;
      

        List<cPedido_por_Cliente> lista_pedidos;

        cCosiMundo cosimundo;
        int cont_camiones;
        cVehiculo camion;
        List<eLocalidad> caminomascorto;
        List<cPedido_por_Cliente> pedido_a_entregar;

        public Form1()
        {

            camioneta = new cCamioneta(2, 80, 5770000);
            furgon = new cFurgon(4, 90, 3950000);
            furgoneta = new cFurgoneta(9, 60, 2800000);


            lista_camiones = new List<cVehiculo>() { camioneta, furgon, furgoneta };

            licuadora = new cPequeños_electrodomesticos(30, 20, 2, objetos.licuadora);
            licuadora2 = new cPequeños_electrodomesticos(10, 4, 2, objetos.licuadora);
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
            impresora2 = new cElectronicos(10, 3, 3, objetos.impresoras);
            impresora3 = new cElectronicos(30, 9, 3, objetos.impresoras);
            accesorios = new cElectronicos(10, 20, 1, objetos.accesorios);
            accesorios2 = new cElectronicos(50, 3, 1, objetos.accesorios);
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

            lista_niall = new List<cElectrodomesticos>();
            lista_niall.Add(rallador);
            lista_niall.Add(impresora);

            lista_joshua = new List<cElectrodomesticos>();
            lista_joshua.Add(exprimidor);
            lista_joshua.Add(tostadora);
            lista_joshua.Add(secarropas);

            lista_dove = new List<cElectrodomesticos>();
            lista_dove.Add(cafetera);
            lista_dove.Add(termotanque);

            lista_luke = new List<cElectrodomesticos>();
            lista_luke.Add(termotanque);
            lista_dove.Add(cocina);

            lista_isaac = new List<cElectrodomesticos>();
            lista_isaac.Add(tostadora);
            lista_isaac.Add(accesorios);
            lista_isaac.Add(termotanque);

            lista_mitch = new List<cElectrodomesticos>();
            lista_mitch.Add(exprimidor);
            lista_mitch.Add(calefon);

            lista_sarah = new List<cElectrodomesticos>();
            lista_sarah.Add(tostadora);
            lista_sarah.Add(licuadora);

            lista_larry = new List<cElectrodomesticos>();
            lista_larry.Add(lavarropas);
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
            lista_ron.Add(tostadora);
            lista_ron.Add(lavarropas);

            lista_dobby = new List<cElectrodomesticos>();
            lista_dobby.Add(lavarropas);
            lista_dobby.Add(calefon);
            lista_dobby.Add(impresora);

            lista_Homero = new List<cElectrodomesticos>();
            lista_Homero.Add(cocina);
            lista_Homero.Add(comptadora);

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

            lista_marge = new List<cElectrodomesticos>();
            lista_marge.Add(rallador);
            lista_marge.Add(cafetera);

            lista_meredith = new List<cElectrodomesticos>();
            lista_meredith.Add(rallador);
            lista_meredith.Add(lavarropas);

            lista_derek = new List<cElectrodomesticos>();
            lista_derek.Add(licuadora);
            lista_marge.Add(cafetera);
            lista_meredith.Add(rallador);

            lista_cristina = new List<cElectrodomesticos>();
            lista_cristina.Add(cocina);
            lista_cristina.Add(accesorios);

            lista_izzie = new List<cElectrodomesticos>();
            lista_izzie.Add(termotanque);
            lista_izzie.Add(secarropas);
            lista_izzie.Add(lavarropas);

            lista_jackson = new List<cElectrodomesticos>();
            lista_jackson.Add(comptadora);
            lista_jackson.Add(accesorios);
            lista_jackson.Add(lavarropas);

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
            lista_lottie.Add(impresora);
            lista_lottie.Add(lavarropas);

            lista_lucky = new List<cElectrodomesticos>();
            lista_lucky.Add(lavarropas);
            lista_lucky.Add(secarropas);

            lista_gemma = new List<cElectrodomesticos>();
            lista_gemma.Add(cocina);
            lista_gemma.Add(calefon);

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

            lista_phoebe = new List<cElectrodomesticos>();
            lista_phoebe.Add(lavarropas);
            lista_phoebe.Add(secarropas);

            lista_ross = new List<cElectrodomesticos>();
            lista_ross.Add(calefon);
            lista_ross.Add(licuadora);

            lista_chandler = new List<cElectrodomesticos>();
            lista_chandler.Add(lavarropas);
            lista_chandler.Add(cocina);
            lista_chandler.Add(secarropas);

            lista_monica = new List<cElectrodomesticos>();
            lista_monica.Add(secarropas);
            lista_monica.Add(cocina);
            lista_monica.Add(lavarropas);

            lista_kit = new List<cElectrodomesticos>();
            lista_kit.Add(licuadora);
            lista_kit.Add(rallador);
            lista_kit.Add(accesorios);

            lista_joe = new List<cElectrodomesticos>();
            lista_joe.Add(impresora);
            lista_joe.Add(accesorios);

            lista_nick = new List<cElectrodomesticos>();
            lista_nick.Add(exprimidor);
            lista_nick.Add(comptadora);
            lista_nick.Add(impresora);

            lista_charlie = new List<cElectrodomesticos>();
            lista_charlie.Add(licuadora);
            lista_charlie.Add(rallador);
            lista_charlie.Add(tostadora);

            lista_omar = new List<cElectrodomesticos>();
            lista_omar.Add(accesorios);
            lista_omar.Add(accesorios);
            lista_omar.Add(accesorios);

            lista_edvin = new List<cElectrodomesticos>();
            lista_edvin.Add(accesorios);
            lista_edvin.Add(impresora);
            // lista_edvin.Add(exprimidor);
            // lista_edvin.Add(accesorios);


            lista_jenn = new List<cElectrodomesticos>();
            lista_jenn.Add(licuadora);
            lista_jenn.Add(rallador);
            lista_jenn.Add(tostadora);

            lista_marisa = new List<cElectrodomesticos>();
            lista_marisa.Add(accesorios);
            // lista_marisa.Add(accesorios);
            lista_marisa.Add(accesorios);

            lista_alicek = new List<cElectrodomesticos>();
            lista_alicek.Add(accesorios);
            //lista_alicek.Add(licuadora);
            //lista_alicek.Add(exprimidor);
            //lista_alicek.Add(accesorios);

            lista_aliceo = new List<cElectrodomesticos>();
            lista_aliceo.Add(accesorios);
            // lista_aliceo.Add(impresora);
            // lista_aliceo.Add(rallador);
            // lista_aliceo.Add(licuadora)

            //
            lista_elena = new List<cElectrodomesticos>();
            lista_elena.Add(licuadora);
            lista_elena.Add(rallador);
            lista_elena.Add(accesorios);

            lista_stefan = new List<cElectrodomesticos>();
            lista_stefan.Add(impresora);
            lista_stefan.Add(accesorios);

            lista_damon = new List<cElectrodomesticos>();
            lista_damon.Add(exprimidor);
            lista_damon.Add(comptadora);
            lista_damon.Add(impresora);

            lista_katherine = new List<cElectrodomesticos>();
            lista_katherine.Add(licuadora);
            lista_katherine.Add(rallador);
            lista_katherine.Add(tostadora);

            lista_klauss = new List<cElectrodomesticos>();
            lista_klauss.Add(accesorios);
            lista_klauss.Add(accesorios);
            lista_klauss.Add(accesorios);

            lista_matt = new List<cElectrodomesticos>();
            lista_matt.Add(accesorios);

            lista_bonnie = new List<cElectrodomesticos>();
            lista_bonnie.Add(licuadora);
            lista_bonnie.Add(rallador);
            lista_bonnie.Add(tostadora);

            lista_caroline = new List<cElectrodomesticos>();
            lista_caroline.Add(accesorios);
            lista_caroline.Add(accesorios);

            lista_jeremy = new List<cElectrodomesticos>();
            lista_jeremy.Add(accesorios);

            lista_alarik = new List<cElectrodomesticos>();
            lista_alarik.Add(accesorios);


            lista_ricky = new List<cElectrodomesticos>();
            lista_ricky.Add(licuadora);

            lista_moria = new List<cElectrodomesticos>();
            lista_moria.Add(exprimidor);
            lista_moria.Add(exprimidor);
            lista_moria.Add(comptadora);

            lista_susana = new List<cElectrodomesticos>();
            lista_susana.Add(impresora2);

            lista_conrad = new List<cElectrodomesticos>();
            lista_conrad.Add(licuadora);

            lista_jeremia = new List<cElectrodomesticos>();
            lista_jeremia.Add(licuadora);

            lista_pachano = new List<cElectrodomesticos>();
            lista_pachano.Add(accesorios2);


            lista_pepe = new List<cElectrodomesticos>();
            lista_pepe.Add(impresora2);

            lista_coqui = new List<cElectrodomesticos>();
            lista_coqui.Add(licuadora2);

            lista_paola = new List<cElectrodomesticos>();
            lista_paola.Add(licuadora2);

            lista_moni = new List<cElectrodomesticos>();
            lista_moni.Add(accesorios2);

            lista_mariaelena = new List<cElectrodomesticos>();
            lista_mariaelena.Add(licuadora2);

            lista_dardo = new List<cElectrodomesticos>();
            lista_dardo.Add(accesorios2);



            lista_Simon = new List<cElectrodomesticos>();
            lista_Simon.Add(licuadora);

            lista_jace = new List<cElectrodomesticos>();
            lista_jace.Add(exprimidor);

            lista_clary = new List<cElectrodomesticos>();
            lista_clary.Add(impresora);

            lista_alec = new List<cElectrodomesticos>();
            lista_alec.Add(licuadora);

            lista_izzy = new List<cElectrodomesticos>();
            lista_izzy.Add(licuadora);

            lista_tessa = new List<cElectrodomesticos>();
            lista_tessa.Add(accesorios);


            lista_will = new List<cElectrodomesticos>();
            lista_will.Add(impresora);
            lista_will.Add(tostadora);

            lista_james = new List<cElectrodomesticos>();
            lista_james.Add(licuadora);

            lista_emmacas = new List<cElectrodomesticos>();
            lista_emmacas.Add(licuadora);
            lista_emmacas.Add(impresora);

            lista_cenicienta = new List<cElectrodomesticos>();
            lista_cenicienta.Add(accesorios);
            lista_cenicienta.Add(exprimidor);


            lista_rapunzel = new List<cElectrodomesticos>();
            lista_rapunzel.Add(licuadora);
            lista_rapunzel.Add(rallador);
            lista_rapunzel.Add(tostadora);

            lista_tiana = new List<cElectrodomesticos>();
            lista_tiana.Add(accesorios);
            lista_tiana.Add(accesorios);
            lista_tiana.Add(accesorios);

            lista_blanca = new List<cElectrodomesticos>();
            lista_blanca.Add(accesorios);
            lista_blanca.Add(licuadora);
            lista_blanca.Add(exprimidor);
            lista_blanca.Add(accesorios);

            lista_elsa = new List<cElectrodomesticos>();
            lista_elsa.Add(accesorios);
            lista_elsa.Add(impresora);
            lista_elsa.Add(licuadora);
            lista_elsa.Add(exprimidor);

            //
            lista_bellad = new List<cElectrodomesticos>();
            lista_bellad.Add(licuadora);
            lista_bellad.Add(rallador);
            lista_bellad.Add(accesorios);

            lista_byb = new List<cElectrodomesticos>();
            lista_byb.Add(impresora);
            lista_byb.Add(accesorios);

            lista_mulan = new List<cElectrodomesticos>();
            lista_mulan.Add(exprimidor);
            lista_mulan.Add(comptadora);
            lista_mulan.Add(accesorios);

            lista_ariel = new List<cElectrodomesticos>();
            lista_ariel.Add(licuadora);

            lista_shrek = new List<cElectrodomesticos>();
            lista_shrek.Add(cocina);
            lista_shrek.Add(comptadora);

            lista_fiona = new List<cElectrodomesticos>();
            lista_fiona.Add(cocina);
            lista_fiona.Add(comptadora);

            lista_burro = new List<cElectrodomesticos>();
            lista_burro.Add(cocina);
            lista_burro.Add(comptadora);

            lista_bellahadid = new List<cElectrodomesticos>();
            lista_bellahadid.Add(cocina);
            lista_bellahadid.Add(comptadora);

            lista_gigihadid = new List<cElectrodomesticos>();
            lista_gigihadid.Add(cocina);
            lista_gigihadid.Add(comptadora);
            lista_gigihadid.Add(impresora);
            lista_gigihadid.Add(licuadora);

            lista_jesus = new List<cElectrodomesticos>();
            lista_jesus.Add(exprimidor);

            lista_maria = new List<cElectrodomesticos>();
            lista_maria.Add(impresora2);
            lista_maria.Add(licuadora);

            lista_jose = new List<cElectrodomesticos>();
            lista_jose.Add(licuadora);
            lista_jose.Add(comptadora);

            lista_selena = new List<cElectrodomesticos>();
            lista_selena.Add(licuadora);
            lista_selena.Add(comptadora);

            lista_justin = new List<cElectrodomesticos>();
            lista_justin.Add(cocina);
            lista_justin.Add(comptadora);

            lista_hailey = new List<cElectrodomesticos>();
            lista_hailey.Add(exprimidor);
            lista_hailey.Add(exprimidor);
            lista_hailey.Add(comptadora);

            lista_calloom = new List<cElectrodomesticos>();
            lista_calloom.Add(impresora2);

            lista_ashton = new List<cElectrodomesticos>();
            lista_ashton.Add(licuadora);
            lista_ashton.Add(comptadora);

            lista_michael = new List<cElectrodomesticos>();
            lista_michael.Add(licuadora);
            lista_michael.Add(exprimidor);
            lista_michael.Add(comptadora);


            lista_lorelai = new List<cElectrodomesticos>();
            lista_lorelai.Add(cocina);
            lista_lorelai.Add(comptadora);

            lista_rory = new List<cElectrodomesticos>();
            lista_rory.Add(exprimidor);
            lista_rory.Add(exprimidor);
            lista_rory.Add(comptadora);
            lista_rory.Add(cocina);

            lista_dean = new List<cElectrodomesticos>();
            lista_dean.Add(impresora2);

            lista_jess = new List<cElectrodomesticos>();
            lista_jess.Add(licuadora);
            lista_jess.Add(comptadora);
            lista_jess.Add(impresora2);

            lista_logan = new List<cElectrodomesticos>();
            lista_logan.Add(licuadora);
            lista_logan.Add(impresora2);
            lista_logan.Add(exprimidor);
            lista_logan.Add(comptadora);
            lista_logan.Add(comptadora);













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
            pedido51 = new cPedido_por_Cliente("Kit Connor", eLocalidad.Chacarita, lista_kit, entrega.express);
            pedido52 = new cPedido_por_Cliente("Joe Locke", eLocalidad.TresdeFebrero, lista_joe, entrega.express);
            pedido53 = new cPedido_por_Cliente("Nick Nelson", eLocalidad.Retiro, lista_nick, entrega.express);
            pedido54 = new cPedido_por_Cliente("Charlie Spring", eLocalidad.ParqueAvellaneda, lista_charlie, entrega.express);
            pedido55 = new cPedido_por_Cliente("Omar Rudberg", eLocalidad.Chacarita, lista_omar, entrega.express);
            pedido56 = new cPedido_por_Cliente("Evdin Ryding", eLocalidad.Flores, lista_edvin, entrega.express);
            pedido57 = new cPedido_por_Cliente("Alice Kellen", eLocalidad.VelezSarsfield, lista_alicek, entrega.express);
            pedido58 = new cPedido_por_Cliente("Jenn Benett", eLocalidad.Avellaneda, lista_jenn, entrega.express);
            pedido59 = new cPedido_por_Cliente("Marisa Mayer ", eLocalidad.Palermo, lista_marisa, entrega.express);
            pedido60 = new cPedido_por_Cliente("Alice Olsman", eLocalidad.MonteCastro, lista_aliceo, entrega.express);
            pedido61 = new cPedido_por_Cliente("Elena Gilbert", eLocalidad.Chacarita, lista_elena, entrega.normal);
            pedido62 = new cPedido_por_Cliente("Damon Salvatore", eLocalidad.LomasdeZamora, lista_damon, entrega.normal);
            pedido63 = new cPedido_por_Cliente("Stefan Salvatore", eLocalidad.Mataderos, lista_stefan, entrega.diferido);
            pedido64 = new cPedido_por_Cliente("Jeremy Gilbert", eLocalidad.VillaDevoto, lista_jeremy, entrega.normal);
            pedido65 = new cPedido_por_Cliente("Katherine Pice", eLocalidad.Versalles, lista_katherine, entrega.normal);
            pedido66 = new cPedido_por_Cliente("Bonnie Benett", eLocalidad.Chacarita, lista_bonnie, entrega.diferido);
            pedido67 = new cPedido_por_Cliente("Caroline Forbes", eLocalidad.ParqueAvellaneda, lista_caroline, entrega.normal);
            pedido68 = new cPedido_por_Cliente("Klauss Mickelson", eLocalidad.Palermo, lista_klauss, entrega.diferido);
            pedido69 = new cPedido_por_Cliente("Alarik Saltzman", eLocalidad.LomasdeZamora, lista_alarik, entrega.diferido);
            pedido70 = new cPedido_por_Cliente("Matt Donovan", eLocalidad.MonteCastro, lista_matt, entrega.diferido);
            pedido71 = new cPedido_por_Cliente("Ricardo Fort", eLocalidad.PuertoMadero, lista_ricky, entrega.express);
            pedido72 = new cPedido_por_Cliente("Moria Casan", eLocalidad.Retiro, lista_moria, entrega.normal);
            pedido73 = new cPedido_por_Cliente("Anibal Pachano", eLocalidad.VelezSarsfield, lista_pachano, entrega.express);
            pedido74 = new cPedido_por_Cliente("Susana Gimenez", eLocalidad.TresdeFebrero, lista_susana, entrega.normal);
            pedido75 = new cPedido_por_Cliente("Conrad Fisher", eLocalidad.LomasdeZamora, lista_conrad, entrega.normal);
            pedido76 = new cPedido_por_Cliente("Jeremhia Fisher", eLocalidad.MonteCastro, lista_jeremia, entrega.normal);
            pedido77 = new cPedido_por_Cliente("Pepe Argento", eLocalidad.Belgrano, lista_pepe, entrega.normal);
            pedido78 = new cPedido_por_Cliente("Moni Argento", eLocalidad.Avellaneda, lista_moni, entrega.normal);
            pedido79 = new cPedido_por_Cliente("Mariaelena Fuseneca", eLocalidad.Liniers, lista_mariaelena, entrega.normal);
            pedido80 = new cPedido_por_Cliente("Dardo Fuseneco", eLocalidad.LaBoca, lista_dardo, entrega.diferido);
            pedido81 = new cPedido_por_Cliente("Paola Argento", eLocalidad.Flores, lista_paola, entrega.normal);
            pedido82 = new cPedido_por_Cliente("Coqui Argento", eLocalidad.Chacarita, lista_coqui, entrega.normal);
            pedido83 = new cPedido_por_Cliente("Simon Lewis", eLocalidad.PuertoMadero, lista_Simon, entrega.diferido);
            pedido84 = new cPedido_por_Cliente("Jace Herondale", eLocalidad.Mataderos, lista_jace, entrega.diferido);
            pedido85 = new cPedido_por_Cliente("Alec Lightwood", eLocalidad.Palermo, lista_alec, entrega.diferido);
            pedido86 = new cPedido_por_Cliente("Izzy Lightwood", eLocalidad.Belgrano, lista_izzy, entrega.diferido);
            pedido87 = new cPedido_por_Cliente("Clary Fairchild", eLocalidad.SanMartin, lista_clary, entrega.normal);
            pedido88 = new cPedido_por_Cliente("Emma Castairs", eLocalidad.VillaLuro, lista_emmacas, entrega.normal);
            pedido89 = new cPedido_por_Cliente("James Castairs", eLocalidad.VillaUrquiza, lista_james, entrega.normal);
            pedido90 = new cPedido_por_Cliente("Will Herondale", eLocalidad.VillaDevoto, lista_will, entrega.diferido);
            pedido91 = new cPedido_por_Cliente("Tessa Gray", eLocalidad.Caballito, lista_tessa, entrega.diferido);
            pedido92 = new cPedido_por_Cliente("Rapunzel", eLocalidad.Retiro, lista_rapunzel, entrega.express);
            pedido93 = new cPedido_por_Cliente("Cenicienta", eLocalidad.Mataderos, lista_cenicienta, entrega.express);
            pedido94 = new cPedido_por_Cliente("Bella Durmiente", eLocalidad.VillaDevoto, lista_bellad, entrega.normal);
            pedido95 = new cPedido_por_Cliente("Bella y Bestia", eLocalidad.Versalles, lista_byb, entrega.normal);
            pedido96 = new cPedido_por_Cliente("Ariel", eLocalidad.Chacarita, lista_ariel, entrega.normal);
            pedido97 = new cPedido_por_Cliente("Tiana", eLocalidad.ParqueAvellaneda, lista_tiana, entrega.express);
            pedido98 = new cPedido_por_Cliente("Blanca Nieves", eLocalidad.Palermo, lista_blanca, entrega.express);
            pedido99 = new cPedido_por_Cliente("Mulan", eLocalidad.LaBoca, lista_mulan, entrega.normal);
            pedido100 = new cPedido_por_Cliente("Elsa", eLocalidad.Avellaneda, lista_elsa, entrega.normal);
            pedido101 = new cPedido_por_Cliente("Shrek", eLocalidad.Liniers, lista_shrek, entrega.express);
            pedido102 = new cPedido_por_Cliente("Fiona", eLocalidad.ParqueAvellaneda, lista_fiona, entrega.express);
            pedido103 = new cPedido_por_Cliente("Burro", eLocalidad.MonteCastro, lista_burro, entrega.express);
            pedido104 = new cPedido_por_Cliente("Bella Hadid", eLocalidad.Palermo, lista_bellahadid, entrega.express);
            pedido105 = new cPedido_por_Cliente("Jesus", eLocalidad.PuertoMadero, lista_jesus, entrega.normal);
            pedido106 = new cPedido_por_Cliente("Maria", eLocalidad.VillaUrquiza, lista_maria, entrega.normal);
            pedido107 = new cPedido_por_Cliente("Jose", eLocalidad.Palermo, lista_jose, entrega.normal);
            pedido108 = new cPedido_por_Cliente("Selena Gomez", eLocalidad.VicenteLopez, lista_selena, entrega.express);
            pedido109 = new cPedido_por_Cliente("Justin Bieber", eLocalidad.VelezSarsfield, lista_justin, entrega.normal);
            pedido110 = new cPedido_por_Cliente("Hailey Bieber", eLocalidad.Liniers, lista_hailey, entrega.express);
            pedido111 = new cPedido_por_Cliente("Caloom Hood", eLocalidad.PuertoMadero, lista_calloom, entrega.normal);
            pedido112 = new cPedido_por_Cliente("Ashton Irwin", eLocalidad.Chacarita, lista_ashton, entrega.express);
            pedido113 = new cPedido_por_Cliente("Michael Clifford", eLocalidad.Belgrano, lista_michael, entrega.normal);
            pedido114 = new cPedido_por_Cliente("Lorelai Gilmore", eLocalidad.VicenteLopez, lista_lorelai, entrega.normal);
            pedido115 = new cPedido_por_Cliente("Rory Gilmore", eLocalidad.Caballito, lista_rory, entrega.normal);
            pedido116 = new cPedido_por_Cliente("Dean", eLocalidad.LaMatanza, lista_dean, entrega.normal);
            pedido117 = new cPedido_por_Cliente("Jess", eLocalidad.LaBoca, lista_jess, entrega.normal);
            pedido118 = new cPedido_por_Cliente("Logan", eLocalidad.Belgrano, lista_logan, entrega.normal);
           
            {

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
                lista_pedidos.Add(pedido51);
                lista_pedidos.Add(pedido52);
                lista_pedidos.Add(pedido53);
                lista_pedidos.Add(pedido54);
                lista_pedidos.Add(pedido55);
                lista_pedidos.Add(pedido56);
                lista_pedidos.Add(pedido57);
                lista_pedidos.Add(pedido58);
                lista_pedidos.Add(pedido59);
                lista_pedidos.Add(pedido60);
                lista_pedidos.Add(pedido61);
                lista_pedidos.Add(pedido62);
                lista_pedidos.Add(pedido63);
                lista_pedidos.Add(pedido64);
                lista_pedidos.Add(pedido65);
                lista_pedidos.Add(pedido66);
                lista_pedidos.Add(pedido67);
                lista_pedidos.Add(pedido68);
                lista_pedidos.Add(pedido69);
                lista_pedidos.Add(pedido70);
                lista_pedidos.Add(pedido71);
                lista_pedidos.Add(pedido72);
                lista_pedidos.Add(pedido73);
                lista_pedidos.Add(pedido74);
                lista_pedidos.Add(pedido75);
                lista_pedidos.Add(pedido76);
                lista_pedidos.Add(pedido77);
                lista_pedidos.Add(pedido78);
                lista_pedidos.Add(pedido79);
                lista_pedidos.Add(pedido80);
                lista_pedidos.Add(pedido81);
                lista_pedidos.Add(pedido82);
                lista_pedidos.Add(pedido83);
                lista_pedidos.Add(pedido84);
                lista_pedidos.Add(pedido85);
                lista_pedidos.Add(pedido86);
                lista_pedidos.Add(pedido87);
                lista_pedidos.Add(pedido88);
                lista_pedidos.Add(pedido89);
                lista_pedidos.Add(pedido90);
                lista_pedidos.Add(pedido91);
                lista_pedidos.Add(pedido92);
                lista_pedidos.Add(pedido93);
                lista_pedidos.Add(pedido94);
                lista_pedidos.Add(pedido95);
                lista_pedidos.Add(pedido96);
                lista_pedidos.Add(pedido97);
                lista_pedidos.Add(pedido98);
                lista_pedidos.Add(pedido99);
                lista_pedidos.Add(pedido100);
                lista_pedidos.Add(pedido101);
                lista_pedidos.Add(pedido102);
                lista_pedidos.Add(pedido103);
                lista_pedidos.Add(pedido104);
                lista_pedidos.Add(pedido105);
                lista_pedidos.Add(pedido106);
                lista_pedidos.Add(pedido107);
                lista_pedidos.Add(pedido108);
                lista_pedidos.Add(pedido109);
                lista_pedidos.Add(pedido110);
                lista_pedidos.Add(pedido111);
                lista_pedidos.Add(pedido112);
                lista_pedidos.Add(pedido113);
                lista_pedidos.Add(pedido114);
                lista_pedidos.Add(pedido115);
                lista_pedidos.Add(pedido116);
                lista_pedidos.Add(pedido117);
                lista_pedidos.Add(pedido118);

                cosimundo = new cCosiMundo(lista_pedidos, lista_camiones);
                pedido_a_entregar = new List<cPedido_por_Cliente>();

                InitializeComponent();
            }
        }
            private void button1_Click(object sender, EventArgs e)
            {
                fecha = dia.Value; //obtenemos la fecha de hoy
                cosimundo.camiones_disponibles(fecha); //obtenemos los camiones que van a estar disponibles
                int max_viajes = cosimundo.max_viajes_por_dia(); //obtenemosla cantidad de viajes que podemos hacer en el dia
                cont_camiones = 0; //contador para ir fijandonos que camion usar
               int cantvolumen = 0;
                int cantpeso = 0;

            //imprimimos la cantidad de camiones que tenemos disponibles
                listView1.Items.Add("Camiones");
                listView1.Items.Add("Disponibles");
                listView1.Items.Add("Hoy: ");
                listView1.Items.Add(cosimundo.camionesdisponibles.Count.ToString());

                camion = cosimundo.camionesdisponibleshoy.ElementAt(0); //siempre empezamos con la camioneta
               
                while (cont_camiones < max_viajes && this.lista_pedidos.Count != 0) //mientras que no hayamos hecho todos los viajes y queden pedidos que entregar
                {
                    cantvolumen = 0;
                    cantpeso = 0;
                      //lleno el camion y obtengo el camino a recorrer -> obteniendo la lista de localidades a recorrer y la lista de pedidos a entregar
                    caminomascorto = cosimundo.despacho_de_productos(this.lista_pedidos, pedido_a_entregar, camion); //calculo el mejor camino, y despacho todos los paquetes posibles, dandole prioridad a los express
                    
                    cont_camiones++;//se lleno el camion anterior, uso el siguiente

                     //cuento el peso y el volumen de la lista de pedidos a entregar
                    for (int i = 0; i < pedido_a_entregar.Count; i++)
                    {
                    cantvolumen = cantvolumen + pedido_a_entregar[i].volumen;
                    cantpeso = cantpeso + pedido_a_entregar[i].peso_pedido;
                      }

                    //imprimo la informacion
                    TreeNode Nodo_padre = new TreeNode(camion.ToString());
                    Nodo_padre.Nodes.Add("Volumen Maximo Camion: ");
                    Nodo_padre.Nodes.Add(camion.volumen_max.ToString());
                    Nodo_padre.Nodes.Add("Volumen De Cargado: ");
                    Nodo_padre.Nodes.Add(cantvolumen.ToString());

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



                      //me fijo si tengo que cambiar de camion o sigo con la camioneta
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

                if (fecha.Day == 1) //si el dia del mes es 1, le sumo 1 a la cantidad de meses de uso delos vehiculos
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
                cosimundo.modificarPedidos(); //cambio los pedidos de normal a express y de normalesa diferidos
            }

            private void textBox1_TextChanged(object sender, EventArgs e)
            {
            }

            private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
            {


            }
        } }
    
