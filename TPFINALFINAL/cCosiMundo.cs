using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace TPFINALFINAL
{
    internal class cCosiMundo
    {
        public List<cVehiculo> camionesdisponibles;
        public List<cVehiculo> camionesdisponibleshoy
        {
            get { return camionesdisponibles; }
            set { }
        }
        private List<cPedido_por_Cliente> lista_pedidos;
        public List<cPedido_por_Cliente> listaPedidos
        {
            get { return lista_pedidos; }
            set { }
        }

        private List<cVehiculo> lista_camiones;
        public List<cVehiculo> listaCamiones
        {
            get { return lista_camiones; }
            set { }
        }

        public cCosiMundo(List<cPedido_por_Cliente> listpedidos, List<cVehiculo> listcamiones)
        {
            this.lista_pedidos = listpedidos;
            this.lista_camiones = listcamiones;
            this.camionesdisponibles = new List<cVehiculo>();
        }

        //FUNCIONES EXTRA DEL PROGRAMA 

        public int Cantidad_Televisores(cPedido_por_Cliente pedido_del_dia)
        {
            //retorna la cantidad de televisores que hay en el pedido, esto es para saber si el pedido tiene un televisor al que hay que cambiarle el volumen cuando
           //se llega al furgon o furgoneta, ya que como no podemos ponernada arriba del televisor, hay que contar que su volumen aumento y su altura no es la de televisor sino
           //la del alto del camion
            int cont = 0;
            for (int i = 0; i < pedido_del_dia.cantidad_objetos; i++)
            {
                if (pedido_del_dia.compra_objetos[i].GetType() == typeof(cTelevisores))//si el objeto es un televisor
                    cont++;
            }
            return cont;
        }

        public void CambiarVolumenTelevisoresFurgoneta()
        {
            //si hay un televisor en el pedido, le cambiamos el volumen por el volumen que se debe tomar de los televisores en el furgoneta
            for (int i = 0; i < this.listaPedidos.Count; i++)
            {
                if (Cantidad_Televisores(this.listaPedidos[i]) > 0)
                {
                    this.listaPedidos[i].CambiarVolumenTelevisorFurgoneta();
                }
            }
        }

        public void CambiarVolumenTelevisoresFurgon()
        {
            //si hay un televisor en el pedido, le cambiamos el volumen por el volumen que se debe tomar de los televisores en el furgon
            for (int i = 0; i < this.listaPedidos.Count; i++)
            {
                if (Cantidad_Televisores(this.listaPedidos[i]) > 0)
                {
                    this.listaPedidos[i].CambiarVolumenTelevisorFurgon();
                }

            }
        }
      
        public void EliminarLineaBlanca(List<cPedido_por_Cliente> pedido)
        {
            //Esta funcion se utiliza en el llenado dinamico, elimina a los linea blanca de la lista pasada como parametro
            //esto es para llenar la camioneta no con pedidos de linea blanca
            for (int i = 0; i < pedido.Count; i++)
            {
                for (int h = 0; h < pedido[i].compra_objetos.Count; h++)
                {
                    if (pedido[i].compra_objetos[h].GetType() == typeof(cLineaBlanca))
                    {
                        pedido.RemoveAt(i);
                        break;
                    }
                }

            }
        }

        public void Eliminarpedido(List<cPedido_por_Cliente> pedido, cPedido_por_Cliente pedidobuscado)
        {
            //cuando entregamos el pedido, lo eliminamos de la lista de pedidos
            for (int i = 0; i < pedido.Count; i++)
            {
                if (pedido[i] == pedidobuscado)
                    pedido.RemoveAt(i);
            }
        }

        public List<cPedido_por_Cliente> Filtrar_por_pedido(List<cPedido_por_Cliente> pedidos_del_dia_, entrega tipo_entrega)
        {
            //filtra a la lista de pedidos por el tipo de entrega que le pasemos como parametro
            List<cPedido_por_Cliente> aux = new List<cPedido_por_Cliente>();

            for (int i = 0; i < pedidos_del_dia_.Count; i++)
            {
                if (pedidos_del_dia_[i].tipo_entrega == tipo_entrega)
                    aux.Add(pedidos_del_dia_[i]);
            }
            return aux;
        }

        public void modificarPedidos()
        {
            //caundo pasan 24h, nos aseguramos de poner a los normales como express y a los diferidos como normales, ya que si no fueron entregados, sus prioridades cambian
            
            for (int i = 0; i < this.listaPedidos.Count; i++)
            {
                if (listaPedidos[i].tipo_entrega == entrega.normal)
                    listaPedidos[i].tipo_entrega = entrega.express;

                if (listaPedidos[i].tipo_entrega == entrega.diferido)
                    listaPedidos[i].tipo_entrega = entrega.normal;

            }
        }

        public int Barrios_en_pedido_del_dia(List<cPedido_por_Cliente> lista_pedido)
        {
            //cuenta la cantidad de barrios que hay en un pedido (sin repetir, es decir si el barrio es el mismo para 2 localidades, se suma 1 vez)
            List<eLocalidad> aux = new List<eLocalidad>();

            int cont = 0;

            for (int i = 0; i < lista_pedido.Count; i++)
            {
                cont = 0;
                if (i == 0)//al primer barrio lo agrega porque no hay ninguno para comparar
                    aux.Add(lista_pedido[i].barrio);
                else
                {
                    for (int h = 0; h < aux.Count; h++)
                    {
                        if (lista_pedido[i].barrio == aux[h])//verificamos si el barrio del pedido a analizar es igual a algun barrio de la lista de barrios que vamos llenando
                            cont++;
                    }
                    if (cont == 0)//si el barrio no se conto, es porque todavia no esta en la lista de barrios y todavia no es contado
                        aux.Add(lista_pedido[i].barrio);
                }
            }
            return aux.Count;
        }

        public int calcular_distancia_barrio_a_liniers(eLocalidad barrioo)
        {
            //distancia en kilometros del barrio de liniers a cada localidad
            int dist = 0;
            switch (barrioo)
            {
                case eLocalidad.Liniers: dist = 0; break;
                case eLocalidad.TresdeFebrero: dist = 6; break;
                case eLocalidad.SanMartin: dist = 11; break;
                case eLocalidad.VicenteLopez: dist = 17; break;
                case eLocalidad.LaMatanza: dist = 5; break;
                case eLocalidad.LomasdeZamora: dist = 18; break;
                case eLocalidad.Lanus: dist = 19; break;
                case eLocalidad.Avellaneda: dist = 21; break;
                case eLocalidad.Versalles: dist = 3; break;
                case eLocalidad.VillaLuro: dist = 2; break;
                case eLocalidad.Mataderos: dist = 4; break;
                case eLocalidad.MonteCastro: dist = 7; break;
                case eLocalidad.VelezSarsfield: dist = 8; break;
                case eLocalidad.ParqueAvellaneda: dist = 9; break;
                case eLocalidad.VillaLugano: dist = 10; break;
                case eLocalidad.VillaDevoto: dist = 12; break;
                case eLocalidad.VillaUrquiza: dist = 13; break;
                case eLocalidad.Belgrano: dist = 20; break;
                case eLocalidad.Palermo: dist = 14; break;
                case eLocalidad.Retiro: dist = 27; break;
                case eLocalidad.Caballito: dist = 15; break;
                case eLocalidad.Flores: dist = 16; break;
                case eLocalidad.PuertoMadero: dist = 18; break;
                case eLocalidad.LaBoca: dist = 25; break;
                case eLocalidad.Chacarita: dist = 23; break;
            }
            return dist;
        }

        public int chequeo_verificacion_barrios(bool[] verificacion_barrios)
        {
            //funcion que nos devuelve el estado del vector verificacion barrios
            // devuelve -> 1 si llegaste al final (todos los barrios fueron recorridos), 0 si no llegaste al final (falta mas de un barrio por recorrer) y -1 si falta un barrio (solo falta un barrio por recorrer), -2 si no se recorrio ningun barrio todavia

            int cont = 0;
            for (int i = 0; i < verificacion_barrios.Length; i++)
            {
                if (verificacion_barrios[i] == false)
                    cont++;
            }
            if (cont == 0)
                return 1; //todos los barrios fueron recorridos
            else if (cont == 1)
                return -1; //solo falta un barrio
            else if (cont == verificacion_barrios.Length)
                return -2;
            else
                return 0; //falta mas de un barrio por recorrer
        }

        public List<eLocalidad> Lista_Barrios_Ordenada(List<cPedido_por_Cliente> pedidos_del_dia_tipo_de_pedido)
        {

            List<eLocalidad> aux = new List<eLocalidad>();

            int cont = 0;

            for (int i = 0; i < pedidos_del_dia_tipo_de_pedido.Count; i++)
            {
                cont = 0;
                if (i == 0)
                    aux.Add(pedidos_del_dia_tipo_de_pedido[i].barrio);
                else
                {
                    for (int h = 0; h < aux.Count; h++)
                    {
                        if (pedidos_del_dia_tipo_de_pedido[i].barrio == aux[h])//verificamos si el barrio del pedido a analizar es igual a algun barrio de la lista de barrios que vamos llenando
                            cont++;
                    }
                    if (cont == 0)//si el barrio no se conto, es porque todavia no esta en la lista de barrios y todavia no es contado
                        aux.Add(pedidos_del_dia_tipo_de_pedido[i].barrio);
                }
            }
            

            //ahora aux tiene la lista de localidades, ahora las ordenamos por diatncia a liniers con el metodo de la burbuja

            for (int x = 0; x < aux.Count; x++)
            {

                for (int y = 0; y < aux.Count - 1; y++)
                {

                    // Si el actual es mayor que el que le sigue a la derecha...
                    if (calcular_distancia_barrio_a_liniers(aux.ElementAt(y)) > calcular_distancia_barrio_a_liniers(aux.ElementAt(y + 1)))
                    { //distancia liniers es una funcion que le pasas una localidad y te pasa la distancia de esa localidad a liniers
                        eLocalidad temporal = aux.ElementAt(y);
                        aux[y] = aux.ElementAt(y + 1);
                        aux[y + 1] = temporal;
                    }
                }
            }
            //ahora aux esta ordenado, con el barrio con la distancia minima a liniers en la primer posicion y el barrio mas alejado en la ultima posicion
            return aux;
        }

        public List<cPedido_por_Cliente> Ordenar_por_pedidio(List<eLocalidad> camino_mas_corto, List<cPedido_por_Cliente> pedido_a_entregar)
        {
            //ordena al pedido en funcion al vector caminomas corto, entonces el barrio que recorremos primero va a tener en la lista a los pedidios primero
            List<cPedido_por_Cliente> pedidos_ordenados = new List<cPedido_por_Cliente>();
            List<cPedido_por_Cliente> aux = new List<cPedido_por_Cliente>();

            for (int i = 0; i < camino_mas_corto.Count; i++)
            {
                aux.RemoveRange(0, aux.Count); //elimino lo que habia en la lista de otras operaciones

                for (int h = 0; h < pedido_a_entregar.Count; h++)
                {
                    if (pedido_a_entregar[h].barrio == camino_mas_corto[i])//si la localidad del barrio es igual a la localidad que se debe seleccionar en el momento
                        aux.Add(pedido_a_entregar[h]);
                }


                for (int n = 0; n < aux.Count; n++)
                {
                    pedidos_ordenados.Add(aux.ElementAt(n)); //agrego los pedidos de la localidad recien ordenada en la lista que vamos a devolver
                }
            }
            return pedidos_ordenados;

        }


        //FUNCIONES RECORRIDO GREEDY

        public List<eLocalidad> encontrar_camino_mas_corto_greedy(cVehiculo camion,int[,] matriz, int barrios_a_recorrer, List<eLocalidad> localidades_en_orden_matriz)
        {
            List<eLocalidad> orden_clientes = new List<eLocalidad>(); //donde vamos a guardar la lista de los barios en orden de ls barrios que tenemos que recorrer
            bool[] verificacion_barrios = new bool[barrios_a_recorrer]; //vector de bool que vamos a usar para saber si un barrio fue recorrido o no, si esta en true (ya lo recorrimos)
            int h = 0; //para ir moviendome en la lista orden a clientes
            int i = 0;
            int dist = 0;
            //ponemos a todos los barrios en false, porque no recorrimos ninguno
            for (int j = 0; j < barrios_a_recorrer; j++)
            {
                verificacion_barrios[j] = false;
            }

            //para calcular el camino -> el mejor camino ¡¡en el momento!! es decir,voy a el barrio que este a menor distancia de donde estoy siempre
            while (chequeo_verificacion_barrios(verificacion_barrios) != 1) //funcion que me devuelve si ya todos los barrios fueron recorridos o no -> 1 si llegaste al final, 0 si no llegaste al final, -1 si falta un barrio y -2 si todaviano recorriste ningun barrio, es decir partis de liniers
            {
                //sumar la distancia que hago del barrio en donde estoy a mi acumulador de dist
                dist=dist+ min_distancia(matriz, i, verificacion_barrios, barrios_a_recorrer, orden_clientes, localidades_en_orden_matriz);//la funcion me devuelve la distancia minima que va a hacer el camion para ir de un barrio a otro (con este algoritmo va a ir eligiendo siempre la dist minima entre barrio y barrio)
                  //podemos pensar al i como el barrio en donde estoy y de ahi comparo las distancias a todos los otros barrios                                                                                                                        // tambien la funcion min_distancia me llena la lista orden_clientes poniendome en la pos h el barrio a recorrer, asi ya los tenemos en orden. La primera localidad de la lista, el primer barrioa recorrer
                i = numero_de_posicion_barrio(orden_clientes.ElementAt(h), localidades_en_orden_matriz); //ahora i va a ser de donde sale el camion, es por eso que apenas entramos al while, es 0, porque siempre sale de liniers, y por eso agarra la ult pos de la lista que va guardando los barrios en orden, pero como orden cliente es eLocalidad, la funcion numero de posicion barrrio te pasa en que posicion de la matriz esta el barrio que recien se recorrio
               //es decir, como ahora tenemos que partir del barrio que recien recorridos, agarramos el numero que ese barrio esta en nuestra lista y esa es la posicion de la matriz que ahora tenemos que ir a buscar las distancias, ya que es del barrio en donde estoy parado y me tengo que ir
                h++;
            }
            dist = dist + calcular_distancia_barrio_a_liniers(orden_clientes.ElementAt(h-1)); //calculo el camino de vuelta de ese ultimo barrio a liniers
            if (camion.GetType() == typeof(cCamioneta))
            {
                //la camioneta gasta 9 litros cada 100 kilometros, calculo cuanta nafta necesito para hacer todo el recorrido
                float litros = (9 * dist) / 100; //calculo la cantidad de nafta que necesito para hacer mi recorrido
                if (litros > camion.cant_nafta) //si no tengo suficiente nafta para hacerlo, la agrego
                    camion.CargarNafta(litros);

            }
            else if(camion.GetType() == typeof(cFurgon))
             {
                //por consigna, el furgon gasta 7 litros cada 100km
                float litros = (7 * dist)/100;
                if (litros > camion.cant_nafta)
                    camion.CargarNafta(litros);
            }
            else //la furgoneta gasta 14 litros cada 100km
            {
                float litros = (14 * dist) / 100;
                if (litros > camion.cant_nafta)
                    camion.CargarNafta(litros);
            }

            return orden_clientes; //retornamos la lista ordenada de barrios a recorrer
        }

        public int min_distancia(int[,] matriz, int pos, bool[] verificacion_barrios, int barrios, List<eLocalidad> orden_clientes, List<eLocalidad> lista_localidad)
        {
            int min = Constants.max_index; //le pongo un valor muy alto, para que la primera vez que compare con la distancia de una localidad siempre entre
            int i = 0;
            //si todavia no recorri ningun barrio si o si tengo que salir de liniers a el barrio mas cercano
            if (chequeo_verificacion_barrios(verificacion_barrios) == -2)//si todavia no se recorrio ningun barrio, voy al que mas cerca este de liniers primero (ya que salgo de liniers)
            {
                for (int h = 0; h < barrios; h++)
                {
                    if (calcular_distancia_barrio_a_liniers(lista_localidad[h]) < min) //comparo que localidad tiene la menor distancia a liniers
                    {
                        i = h;//i=barrio que fui
                        min = calcular_distancia_barrio_a_liniers(lista_localidad[h]);
                    }
                }
                verificacion_barrios[i] = true; //ya recorrimos ese barrio
                orden_clientes.Add(lista_localidad[i]);//sumo el barrio a la lista
            }
            else if (chequeo_verificacion_barrios(verificacion_barrios) == -1)//solo falta un barrio, calculo la distancia de ese barrio a liniers, para que vuelva el camion
            {
                for (int h = 0; h < barrios; h++)
                {
                    if (verificacion_barrios[h] == false)//al primero que entre va a ser el unico que no recorri
                    {
                        orden_clientes.Add(lista_localidad[h]); //lo agrego a la lista, como el unico barrio que no recorri
                        min = matriz[pos,h];
                        verificacion_barrios[h] = true;
                    }
                }
            }
            else
            { //no es el primer viaje que hago, ni va a ser el ultimo

                for (int v = 0; v < barrios; v++) //voy recorriendo todos los nodos
                {
                    if (verificacion_barrios[v] == false && matriz[pos, v] <= min && matriz[pos, v] != 0)//si el barrio no fue recorrido y es la pos minima de esa fila de la matriz, es decir, del camino que tengo desde ese barrio a los demas que tengo que ir, lo cuento
                    {//comaramos la distancia del barrio en la posicion con toda la fila de localidad que estan en false (no fueron recorridas) verificando que el numero no sea 0 porque si lo es, es porque estamos en el mismo barrio
                        i = v;//i=barrio que fui
                        min = matriz[pos, v]; //distancia que recorri

                    }

                }
                verificacion_barrios[i] = true; //ya recorridomo
                orden_clientes.Add(lista_localidad[i]);//sumo el barrio a la lista
            }
            //explicacion conexion lista localidades y matriz, lista localidades esta ordenada de menor a mayor distancia con respecto a liniers. Ejemplo en la posicion 0 de la lista de localidades esta mataderos, entonces en la fila y columna 0 va a estar las distancia de mataderos con los otros barrios

            return min;
        }

        public int numero_de_posicion_barrio(eLocalidad barrio_elegido, List<eLocalidad> lista_localidad)
        {
            //le pasamos la posicion del barrio en la lista de localidades, que esta ordenada por distancia a liniers
            int pos = 0;
            for (int i = 0; i < lista_localidad.Count; i++)
            {
                if (lista_localidad[i] == barrio_elegido)
                    pos = i;
            }
            return pos;
        }

        public int num_asignado_barrio(eLocalidad localidad)
        {
            //esta funcion la usamos para obtener la fila y columna que necesitamos de la matriz de distancias, para crear al grafo
            //cada barrio tiene un numero asignado, que es el que se corresponde con el numero de posicion del enum
            switch (localidad)
            {
                case eLocalidad.Liniers: return 0;
                case eLocalidad.TresdeFebrero: return 1;
                case eLocalidad.SanMartin: return 2;
                case eLocalidad.VicenteLopez: return 3;
                case eLocalidad.LaMatanza: return 4;
                case eLocalidad.LomasdeZamora: return 5;
                case eLocalidad.Lanus: return 6;
                case eLocalidad.Avellaneda: return 7;
                case eLocalidad.Versalles: return 8;
                case eLocalidad.VillaLuro: return 9;
                case eLocalidad.Mataderos: return 10;
                case eLocalidad.MonteCastro: return 11;
                case eLocalidad.VelezSarsfield: return 12;
                case eLocalidad.ParqueAvellaneda: return 13;
                case eLocalidad.VillaLugano: return 14;
                case eLocalidad.VillaDevoto: return 15;
                case eLocalidad.VillaUrquiza: return 16;
                case eLocalidad.Belgrano: return 17;
                case eLocalidad.Palermo: return 18;
                case eLocalidad.Retiro: return 19;
                case eLocalidad.Caballito: return 20;
                case eLocalidad.Flores: return 21;
                case eLocalidad.PuertoMadero: return 22;
                case eLocalidad.LaBoca: return 23;
                case eLocalidad.Chacarita: return 24;
            }
            return -1;
        }

        public int[,] llenar_matriz_con_distancias(List<eLocalidad> lista_localidades, int barrios)
        {

            //esta es la matriz que ya esta predeterminada, tiene todas las distancias de cada localidad a localidad
            int[,] matriz_definitiva = new int[25, 25];
            List<int> list_liniers = new List<int>() { 6, 11, 17, 5, 18, 19, 21, 3, 2, 4, 7, 8, 9, 10, 12, 13, 20, 14, 27, 15, 16, 18, 25, 23 };
            List<int> list_tresfebrero = new List<int>() { 7, 14, 26, 21, 19, 23, 3, 6, 9, 5, 8, 10, 13, 4, 11, 15, 22, 23, 12, 17, 2524, 16 };
            List<int> list_sanmartin = new List<int>() { 12, 30, 26, 24, 28, 8, 13, 15, 9, 16, 17, 18, 5, 6, 14, 16, 20, 19, 12, 27, 29, 8 };
            List<int> list_vicentelopez = new List<int>() { 40, 33, 31, 20, 15, 18, 21, 16, 19, 22, 25, 12, 8, 6, 10, 12, 16, 30, 15, 24, 23 };
            List<int> list_lamatanza = new List<int>() { 31, 30, 24, 5, 22, 20, 7, 28, 8, 10, 9, 14, 23, 27, 29, 13, 11, 21, 24, 17 };
            List<int> list_lomasdezamora = new List<int>() { 9, 30, 20, 21, 15, 23, 19, 16, 13, 24, 28, 36, 25, 43, 20, 17, 27, 28, 24 };
            List<int> list_lanus = new List<int>() { 6, 17, 14, 15, 16, 1, 13, 12, 21, 26, 2, 18, 15, 18, 12, 13, 10, 20 };
            List<int> list_avellaneda = new List<int>() { 20, 17, 18, 19, 3, 16, 15, 25, 29, 37, 15, 8, 12, 16, 7, 4, 26 };
            List<int> list_versalles = new List<int>() { 2, 5, 3, 4, 8, 9, 5, 11, 18, 12, 24, 8, 11, 20, 19, 10 };
            List<int> list_villaluro = new List<int>() { 4, 3, 2, 4, 6, 8, 11, 10, 12, 27, 13, 5, 15, 16, 9 };
            List<int> list_mataderos = new List<int>() { 6, 4, 2, 3, 9, 14, 22, 13, 30, 8, 5, 17, 18, 11 };
            List<int> list_montecastro = new List<int>() { 2, 5, 10, 3, 8, 10, 9, 24, 7, 5, 18, 20, 7 };
            List<int> list_velez = new List<int>() { 2, 4, 3, 10, 11, 8, 14, 5, 3, 15, 16, 6 };
            List<int> list_parqueavellaneda = new List<int>() { 4, 6, 13, 12, 10, 16, 6, 3, 14, 15, 9 };
            List<int> list_villadevoto = new List<int>() { 12, 20, 27, 15, 35, 10, 7, 16, 17, 16 };
            List<int> list_villaurquiza = new List<int>() { 5, 8, 10, 21, 9, 8, 23, 24, 7 };
            List<int> list_belgrano = new List<int>() { 4, 7, 18, 8, 19, 27, 29, 5 };
            List<int> list_palermo = new List<int>() { 4, 8, 7, 11, 3, 16, 4 };
            List<int> list_retiro = new List<int>() { 5, 4, 10, 9, 14, 2 };
            List<int> list_caballito = new List<int>() { 8, 12, 4, 7, 8 };
            List<int> list_flores = new List<int>() { 4, 8, 10, 5 };
            List<int> list_puertomadero = new List<int>() { 10, 15, 8 };
            List<int> list_laboca = new List<int>() { 3, 13 };
            //charcarita ->14
            
            int pos = 0;

            //llenamos a la matriz definitiva
            for (int i = 0; i < 25; i++)
            {
                matriz_definitiva[i, i] = 0;//pongo a la diagonal en 0
                                            //lleno matriz
                pos = i;
                switch (i)
                {
                    case 0:

                        for (int h = 0; h < list_liniers.Count; h++)
                        {
                            pos++;
                            matriz_definitiva[i, pos] = list_liniers.ElementAt(h);
                        }
                        pos = i;
                        for (int h = 0; h < list_liniers.Count; h++)
                        {
                            pos++;
                            matriz_definitiva[pos, i] = list_liniers.ElementAt(h);
                        }
                        break;

                    case 1:

                        for (int h = 0; h < list_tresfebrero.Count; h++)
                        {
                            pos++;
                            matriz_definitiva[i, pos] = list_tresfebrero.ElementAt(h);
                        }
                        pos = i;
                        for (int h = 0; h < list_tresfebrero.Count; h++)
                        {
                            pos++;
                            matriz_definitiva[pos, i] = list_tresfebrero.ElementAt(h);
                        }
                        break;

                    case 2:

                        for (int h = 0; h < list_sanmartin.Count; h++)
                        {
                            pos++;
                            matriz_definitiva[i, pos] = list_sanmartin.ElementAt(h);
                        }
                        pos = i;
                        for (int h = 0; h < list_sanmartin.Count; h++)
                        {
                            pos++;
                            matriz_definitiva[pos, i] = list_sanmartin.ElementAt(h);
                        }

                        break;
                    case 3:

                        for (int h = 0; h < list_vicentelopez.Count; h++)
                        {
                            pos++;
                            matriz_definitiva[i, pos] = list_vicentelopez.ElementAt(h);
                        }
                        pos = i;
                        for (int h = 0; h < list_vicentelopez.Count; h++)
                        {
                            pos++;
                            matriz_definitiva[pos, i] = list_vicentelopez.ElementAt(h);
                        }
                        break;
                    case 4:
                        for (int h = 0; h < list_lamatanza.Count; h++)
                        {
                            pos++;
                            matriz_definitiva[i, pos] = list_lamatanza.ElementAt(h);
                        }
                        pos = i;
                        for (int h = 0; h < list_lamatanza.Count; h++)
                        {
                            pos++;
                            matriz_definitiva[pos, i] = list_lamatanza.ElementAt(h);
                        }
                        break;
                    case 5:
                        for (int h = 0; h < list_lomasdezamora.Count; h++)
                        {
                            pos++;
                            matriz_definitiva[i, pos] = list_lomasdezamora.ElementAt(h);
                        }
                        pos = i;
                        for (int h = 0; h < list_lomasdezamora.Count; h++)
                        {
                            pos++;
                            matriz_definitiva[pos, i] = list_lomasdezamora.ElementAt(h);
                        }
                        break;
                    case 6:

                        for (int h = 0; h < list_lanus.Count; h++)
                        {
                            pos++;
                            matriz_definitiva[i, pos] = list_lanus.ElementAt(h);
                        }
                        pos = i;
                        for (int h = 0; h < list_lanus.Count; h++)
                        {
                            pos++;
                            matriz_definitiva[pos, i] = list_lanus.ElementAt(h);
                        }
                        break;
                    case 7:
                        for (int h = 0; h < list_avellaneda.Count; h++)
                        {
                            pos++;
                            matriz_definitiva[i, pos] = list_avellaneda.ElementAt(h);
                        }
                        pos = i;
                        for (int h = 0; h < list_avellaneda.Count; h++)
                        {
                            pos++;
                            matriz_definitiva[pos, i] = list_avellaneda.ElementAt(h);
                        }
                        break;
                    case 8:
                        for (int h = 0; h < list_versalles.Count; h++)
                        {
                            pos++;
                            matriz_definitiva[i, pos] = list_versalles.ElementAt(h);
                        }
                        pos = i;
                        for (int h = 0; h < list_versalles.Count; h++)
                        {
                            pos++;
                            matriz_definitiva[pos, i] = list_versalles.ElementAt(h);
                        }
                        break;
                    case 9:
                        for (int h = 0; h < list_villaluro.Count; h++)
                        {
                            pos++;
                            matriz_definitiva[i, pos] = list_villaluro.ElementAt(h);
                        }
                        pos = i;
                        for (int h = 0; h < list_villaluro.Count; h++)
                        {
                            pos++;
                            matriz_definitiva[pos, i] = list_villaluro.ElementAt(h);
                        }
                        break;
                    case 10:
                        for (int h = 0; h < list_mataderos.Count; h++)
                        {
                            pos++;
                            matriz_definitiva[i, pos] = list_mataderos.ElementAt(h);
                        }
                        pos = i;
                        for (int h = 0; h < list_mataderos.Count; h++)
                        {
                            pos++;
                            matriz_definitiva[pos, i] = list_mataderos.ElementAt(h);
                        }
                        break;
                    case 11:
                        for (int h = 0; h < list_montecastro.Count; h++)
                        {
                            pos++;
                            matriz_definitiva[i, pos] = list_montecastro.ElementAt(h);
                        }
                        pos = i;
                        for (int h = 0; h < list_montecastro.Count; h++)
                        {
                            pos++;
                            matriz_definitiva[pos, i] = list_montecastro.ElementAt(h);
                        }
                        break;
                    case 12:
                        for (int h = 0; h < list_velez.Count; h++)
                        {
                            pos++;
                            matriz_definitiva[i, pos] = list_velez.ElementAt(h);
                        }
                        pos = i;
                        for (int h = 0; h < list_velez.Count; h++)
                        {
                            pos++;
                            matriz_definitiva[pos, i] = list_velez.ElementAt(h);
                        }
                        break;
                    case 13:
                        for (int h = 0; h < list_parqueavellaneda.Count; h++)
                        {
                            pos++;
                            matriz_definitiva[i, pos] = list_parqueavellaneda.ElementAt(h);
                        }
                        pos = i;
                        for (int h = 0; h < list_parqueavellaneda.Count; h++)
                        {
                            pos++;
                            matriz_definitiva[pos, i] = list_parqueavellaneda.ElementAt(h);
                        }
                        break;
                    case 14:
                        for (int h = 0; h < list_villadevoto.Count; h++)
                        {
                            pos++;
                            matriz_definitiva[i, pos] = list_villadevoto.ElementAt(h);
                        }
                        pos = i;
                        for (int h = 0; h < list_villadevoto.Count; h++)
                        {
                            pos++;
                            matriz_definitiva[pos, i] = list_villadevoto.ElementAt(h);
                        }
                        break;
                    case 15:
                        for (int h = 0; h < list_villaurquiza.Count; h++)
                        {
                            pos++;
                            matriz_definitiva[i, pos] = list_villaurquiza.ElementAt(h);
                        }
                        pos = i;
                        for (int h = 0; h < list_villaurquiza.Count; h++)
                        {
                            pos++;
                            matriz_definitiva[pos, i] = list_villaurquiza.ElementAt(h);
                        }
                        break;
                    case 16:
                        for (int h = 0; h < list_belgrano.Count; h++)
                        {
                            pos++;
                            matriz_definitiva[i, pos] = list_belgrano.ElementAt(h);
                        }
                        pos = i;
                        for (int h = 0; h < list_belgrano.Count; h++)
                        {
                            pos++;
                            matriz_definitiva[pos, i] = list_belgrano.ElementAt(h);
                        }
                        break;
                    case 17:
                        for (int h = 0; h < list_palermo.Count; h++)
                        {
                            pos++;
                            matriz_definitiva[i, pos] = list_palermo.ElementAt(h);
                        }
                        pos = i;
                        for (int h = 0; h < list_palermo.Count; h++)
                        {
                            pos++;
                            matriz_definitiva[pos, i] = list_palermo.ElementAt(h);
                        }
                        break;
                    case 18:
                        for (int h = 0; h < list_retiro.Count; h++)
                        {
                            pos++;
                            matriz_definitiva[i, pos] = list_retiro.ElementAt(h);
                        }
                        pos = i;
                        for (int h = 0; h < list_retiro.Count; h++)
                        {
                            pos++;
                            matriz_definitiva[pos, i] = list_retiro.ElementAt(h);
                        }
                        break;
                    case 19:
                        for (int h = 0; h < list_caballito.Count; h++)
                        {
                            pos++;
                            matriz_definitiva[i, pos] = list_caballito.ElementAt(h);
                        }
                        pos = i;
                        for (int h = 0; h < list_caballito.Count; h++)
                        {
                            pos++;
                            matriz_definitiva[pos, i] = list_caballito.ElementAt(h);
                        }
                        break;
                    case 20:
                        for (int h = 0; h < list_flores.Count; h++)
                        {
                            pos++;
                            matriz_definitiva[i, pos] = list_flores.ElementAt(h);
                        }
                        pos = i;
                        for (int h = 0; h < list_flores.Count; h++)
                        {
                            pos++;
                            matriz_definitiva[pos, i] = list_flores.ElementAt(h);
                        }
                        break;
                    case 21:
                        for (int h = 0; h < list_puertomadero.Count; h++)
                        {
                            pos++;
                            matriz_definitiva[i, pos] = list_puertomadero.ElementAt(h);
                        }
                        pos = i;
                        for (int h = 0; h < list_puertomadero.Count; h++)
                        {
                            pos++;
                            matriz_definitiva[pos, i] = list_puertomadero.ElementAt(h);
                        }
                        break;
                    case 22:
                        for (int h = 0; h < list_laboca.Count; h++)
                        {
                            pos++;
                            matriz_definitiva[i, pos] = list_laboca.ElementAt(h);
                        }
                        pos = i;
                        for (int h = 0; h < list_laboca.Count; h++)
                        {
                            pos++;
                            matriz_definitiva[pos, i] = list_laboca.ElementAt(h);
                        }
                        break;
                    case 23:
                        pos++;
                        matriz_definitiva[i, pos] = 14;
                        matriz_definitiva[pos, i] = 14;

                        break;
                }
            }
            
            //llenamos la matriz que vamos a usar como grafo
            int[] num_barrios_en_matriz = new int[barrios];
            int[,] matriz_distancias = new int[barrios, barrios];


            int barrio_fijo = 0;
            for (int i = 0; i < barrios; i++)
            {
                barrio_fijo = num_asignado_barrio(lista_localidades.ElementAt(i));
                num_barrios_en_matriz[i] = barrio_fijo;
            }
            //tengo un vector con los numeros de los barrios que necesito correspondiente a la matriz ya definida, de esta manera me voy moviendo en mi matriz definitiva lenantando los valores que necesito y copiandolos en mi matriz que voy a usar para calcular el menor camino


            for (int i = 0; i < lista_localidades.Count; i++) //voy por todas las localidades
            {
                for (int pos_barrios = 0; pos_barrios < barrios; pos_barrios++)
                {
                    matriz_distancias[i, pos_barrios] = matriz_definitiva[num_barrios_en_matriz[i], num_barrios_en_matriz[pos_barrios]];
                }
            }


            return matriz_distancias; //devuelvo la matriz con las distancias de cada barrio a cada barrio 
        }

        
       
       //FUNCIONES LLENADO DINAMICO

        public int[] ValorDeCadaPedido(List<cPedido_por_Cliente> lista)
        {
            int[] valores = new int[lista.Count];
            for (int i = 0; i < lista.Count; i++)
            {
                
                valores[i] = lista[i].volumen / lista[i].peso_pedido; //el valor de cada pedido es el indicie entre volumen y peso, para maximizar este

                if (valores[i] == 0)//por defecto, si el indicie es 0, le ponemos 10
                    valores[i] = 10;


            }
            return valores;
        }

        public void LlenadoCamion(cVehiculo camion, List<cPedido_por_Cliente> pedidos_del_dia, List<cPedido_por_Cliente> pedido_a_entregar)
        {
            //filtramos las listas por express y normal, esto es mas que nada por un tema de c# y el problema con la falta de inicializacion
            List<cPedido_por_Cliente> listaexpress = Filtrar_por_pedido(pedidos_del_dia, entrega.express);
            List<cPedido_por_Cliente> listanormal = Filtrar_por_pedido(pedidos_del_dia, entrega.normal);
            
            if (camion.GetType() == typeof(cCamioneta) && listaexpress.Count != 0)
            {//si estamos en el caso de una camioenta y hay express que entregar
                //primero eliminamos a los linea blanca
                EliminarLineaBlanca(listaexpress); //por un tema de la camioneta

                //si hay pedidos NO linea balnca que entregar, vamos con esos
                if (listaexpress.Count != 0)//primero llenamos el camion con los no linea blanca
                    LLenadoDinamicoDelCamion(camion, pedidos_del_dia, listaexpress, pedido_a_entregar);
                else //si no hay pedidos que no sean linea blanca express, mandamos a los linea blanca
                { //Nosotras priorizamos entregar primero los express, despues los normales y despues los diferidos.
                    
                    listaexpress = Filtrar_por_pedido(pedidos_del_dia, entrega.express);
                    if(listaexpress.Count!=0)//si hay pedidos, en este caso de linea blanca, en el express entregamos esos
                        RellenadoDinamico(camion,camion.peso_max,camion.volumen_max-Constants.volumen_elevador, pedidos_del_dia, listaexpress, pedido_a_entregar); //rellena el camion con los express con linea blanca
                    else if (listanormal.Count != 0) //si ya no hay express, verifico que si haya normales
                    {
                        EliminarLineaBlanca(listanormal);//intentantamos llenar con los no linea blanca
                        if (listanormal.Count != 0)
                            RellenadoDinamicoNormales(camion,camion.peso_max,camion.volumen_max, pedidos_del_dia, listanormal, pedido_a_entregar);
                        else
                        { //no hay normales que no sean linea blanca, mandamos esos y tenemos en cuenta el peso del elevador
                            listanormal = Filtrar_por_pedido(pedidos_del_dia, entrega.normal);
                            RellenadoDinamicoNormales(camion, camion.peso_max, camion.volumen_max - Constants.volumen_elevador, pedidos_del_dia, listaexpress, pedido_a_entregar);
                        }

                    }
                    else //si los express y normales ambos ya se entregaron todos, voy con los diferidos, ahora no me importa si hay linea blanca o no, porque no son prioridad
                    {
                        listanormal = Filtrar_por_pedido(pedidos_del_dia, entrega.diferido);
                        RellenadoDinamicoDiferidos(camion.peso_max, camion.volumen_max - Constants.volumen_elevador, pedidos_del_dia, listanormal, pedido_a_entregar);

                    }

                }
                

            }else //si no estamos en presencia de una camioneta, lleno el camion como: primero los express, despues los normales y despues los diferidos (esta vez sin tener en cuenta si hay linea blanca o no)
            {
                if(listaexpress.Count!=0)//si hay express que entregar, meto esos
                    LLenadoDinamicoDelCamion(camion, pedidos_del_dia, listaexpress, pedido_a_entregar);
               else if (listanormal.Count!=0)//si hay normales que entregar, meto esos
                    RellenadoDinamicoNormales(camion, camion.peso_max, camion.volumen_max, pedidos_del_dia, listanormal, pedido_a_entregar);
                else //si hay diferidos que entregar, meto esos
                {
                    listanormal = Filtrar_por_pedido(pedidos_del_dia, entrega.diferido);
                    RellenadoDinamicoDiferidos(camion.peso_max,camion.volumen_max, pedidos_del_dia, listanormal, pedido_a_entregar);

                }

            }
        }

        public void LLenadoDinamicoDelCamion(cVehiculo camion, List<cPedido_por_Cliente> pedidos_del_dia_completa, List<cPedido_por_Cliente> pedidos_del_dia, List<cPedido_por_Cliente> pedido_a_entregar)
        {
            int[] valor = ValorDeCadaPedido(pedidos_del_dia); //obtenemos los valores de cada pedido

            int i, w;
            int acumvolumen = 0;
            int[,] K = new int[pedidos_del_dia.Count + 1, camion.peso_max + 1];

            bool flag; //utilizamos el flag para que cuente solo una vez el volumen del pedido
            for (i = 0; i <= pedidos_del_dia.Count; i++)
            {
                flag = false;

                for (w = 0; w <= camion.peso_max; w++)
                {

                    if (i == 0 || w == 0)
                        K[i, w] = 0;
                    else if (pedidos_del_dia[i - 1].peso_pedido <= w && acumvolumen + pedidos_del_dia[i - 1].volumen <= camion.volumen_max) //no solo nos fijamos que entre por peso, sino tamb por volumen
                    {
                        if (flag == false)
                        {
                            acumvolumen = acumvolumen + pedidos_del_dia[i - 1].volumen;
                            flag = true;
                        }

                        K[i, w] = Math.Max(valor[i - 1] + K[i - 1, w - pedidos_del_dia[i - 1].peso_pedido], K[i - 1, w]);

                    }
                    else
                        K[i, w] = K[i - 1, w];
                }
            }

            int res = K[pedidos_del_dia.Count, camion.peso_max];
            i = pedidos_del_dia.Count;
            int j = camion.peso_max;

            //encontramos los pedidos que nos conviene meter al camion
            while (i > 0 && j > 0)
            {
                if (K[i, j] == K[i - 1, j])
                {
                    i--;
                    continue;

                }
                else
                {
                    pedido_a_entregar.Add(pedidos_del_dia[i - 1]);
                    j = j - pedidos_del_dia[i - 1].peso_pedido;
                    Eliminarpedido(pedidos_del_dia_completa, pedidos_del_dia[i - 1]);
                    pedidos_del_dia.RemoveAt(i - 1);
                    i--;
                }
            }

            //contarPesoTotal
            int acum_peso = 0;
            int acum_volumen = 0;

            //contar el peso y volumen actual del pedido que llene que voy a meter al camion
            for (int h = 0; h < pedido_a_entregar.Count; h++)
            {
                acum_peso = acum_peso + pedido_a_entregar[h].peso_pedido;
                acum_volumen = acum_volumen + pedido_a_entregar[h].volumen;
            }

            if (acum_peso < camion.peso_max && acum_volumen < camion.volumen_max) //si el pero y volumen son menores
            {
                List<cPedido_por_Cliente> lista;
                if (camion.GetType() == typeof(cCamioneta))
                {
                    //como esta es la primera funcion que entramos para llenar el camion dinamicamente, cuando estemos en el caso de una camioneta, vamos a ir con los express con linea blanca ya que queremos priorizar que estos se entreguen primero

                    lista = Filtrar_por_pedido(pedidos_del_dia_completa, entrega.express); //mando a los express que necesitaban linea blanca
                    
                    if (lista.Count == 0)//si ya no hay mas express
                    {
                        lista = Filtrar_por_pedido(pedidos_del_dia_completa, entrega.normal); //filtro los normales

                        if (lista.Count !=0) //si hay normales para mandar
                        {
                            EliminarLineaBlanca(lista); //elimino a los linea blanca

                            if (lista.Count == 0) //si no hay normales sin linea blanca, pongo a los linea blanca y pongo el elevador
                            {
                                lista = Filtrar_por_pedido(pedidos_del_dia_completa, entrega.normal);
                                RellenadoDinamicoNormales(camion, camion.peso_max - acum_peso, camion.volumen_max - acum_volumen - Constants.volumen_elevador, pedidos_del_dia_completa, lista, pedido_a_entregar);
                            }
                            else //si si hay normales sin linea blanca, intento meter a esos
                                RellenadoDinamicoNormales(camion, camion.peso_max - acum_peso, camion.volumen_max - acum_volumen , pedidos_del_dia_completa, lista, pedido_a_entregar);

                        }
                        else if (lista.Count==0) //si ya no hay mas normales (ni con ni sin linea blanca)
                        {
                            lista = Filtrar_por_pedido(pedidos_del_dia_completa, entrega.diferido); //mando a los diferidos
                            if(lista.Count!=0)
                            RellenadoDinamicoDiferidos( camion.peso_max - acum_peso, camion.volumen_max - acum_volumen, pedidos_del_dia_completa, lista, pedido_a_entregar);
                            
                        }
                    }
                    else //si si hay express con linea blanca, mando a esos
                    RellenadoDinamico(camion, camion.peso_max - acum_peso, camion.volumen_max - acum_volumen - Constants.volumen_elevador, pedidos_del_dia_completa, lista, pedido_a_entregar);
                }
                else //si no estamos en el caso de una camioneta, nunca separamos en linea blanca o no asique los express q no entraron, no entraron y punto, sigo con los normales
                {
                    lista = Filtrar_por_pedido(pedidos_del_dia_completa, entrega.normal);

                    if(lista.Count!=0)//si hay normales que entregar
                    RellenadoDinamicoNormales(camion,camion.peso_max - acum_peso, camion.volumen_max - acum_volumen, pedidos_del_dia_completa, lista, pedido_a_entregar);
                    else //si no hay normales, sigo con los diferidos
                        RellenadoDinamicoDiferidos(camion.peso_max - acum_peso, camion.volumen_max - acum_volumen, pedidos_del_dia_completa, lista, pedido_a_entregar);


                }
            }
        }

        public void RellenadoDinamico(cVehiculo camion,int peso, int volumen, List<cPedido_por_Cliente> pedidostotal, List<cPedido_por_Cliente> pedido, List<cPedido_por_Cliente> pedido_a_entregar)
        { 
            //cuando llego a rellenado es porque podia meter en la camioneta pedidos express que sean de linea blanca (en la camioneta),asique los meto
            int[] valor = ValorDeCadaPedido(pedido);
            int i, w;
            int acumvolumen = 0;
            int[,] K = new int[pedido.Count + 1, peso + 1];

            bool flag;
            for (i = 0; i <= pedido.Count; i++)
            {
                flag = false;

                for (w = 0; w <= peso; w++)
                {

                    if (i == 0 || w == 0)
                        K[i, w] = 0;
                    else if (pedido[i - 1].peso_pedido <= w && acumvolumen + pedido[i - 1].volumen <= volumen)
                    {
                        if (flag == false)
                        {
                            acumvolumen = acumvolumen + pedido[i - 1].volumen;
                            flag = true;
                        }

                        K[i, w] = Math.Max(valor[i - 1] + K[i - 1, w - pedido[i - 1].peso_pedido], K[i - 1, w]);

                    }
                    else
                        K[i, w] = K[i - 1, w];
                }
            }

            int res = K[pedido.Count, peso];
            i = pedido.Count;
            int j = peso;

            while (i > 0 && j > 0)
            {
                if (K[i, j] == K[i - 1, j])
                {
                    i--;
                    continue;

                }
                else
                {
                    pedido_a_entregar.Add(pedido[i - 1]);
                    j = j - pedido[i - 1].peso_pedido;
                    Eliminarpedido(pedidostotal, pedido[i - 1]);
                    i--;
                }
            }

            int acumpeso = 0;
            int acumvol = 0;
            for(int f = 0; f < pedido_a_entregar.Count; f++)
            {
                acumpeso = acumpeso + pedido_a_entregar[f].peso_pedido;
                acumvol = acumvol + pedido_a_entregar[f].volumen;
            }

            //si aun agregando los linea blanca express me queda lugar en el camion, sigo con los normales
            if(acumpeso < camion.peso_max && acumvol < camion.volumen_max)
            {
                List<cPedido_por_Cliente> listanormal = Filtrar_por_pedido(pedidostotal, entrega.normal);
                //si es una camioneta y hay normales para repartir, entro
                if (listanormal.Count!=0 && camion.GetType() == typeof(cCamioneta) )
                {
                   //si llegue hasta aca, es porque ya meti los express linea blanca, asique ya esta tomado en cuenta el elevador 
                    RellenadoDinamicoNormales(camion, camion.peso_max - acumpeso, camion.volumen_max - acumvol, pedidostotal, listanormal, pedido_a_entregar);

                }
                else if (listanormal.Count == 0 && camion.GetType() == typeof(cCamioneta))
                {//si no hay normales,sigo con los diferidos
                    listanormal = Filtrar_por_pedido(pedidostotal, entrega.diferido);

                    //si los diferidos tamb son 0, salgo 
                    if (listanormal.Count != 0)
                        RellenadoDinamicoDiferidos(camion.peso_max - acumpeso, camion.volumen_max - acumvol, pedidostotal, listanormal, pedido_a_entregar);
                    else
                        return;
                }
                else
                    RellenadoDinamicoNormales(camion, camion.peso_max - acumpeso, camion.volumen_max - acumvol, pedidostotal, listanormal, pedido_a_entregar);

            }

        }
        
        public void RellenadoDinamicoNormales(cVehiculo camion,int peso, int volumen, List<cPedido_por_Cliente> pedidostotal, List<cPedido_por_Cliente> pedido, List<cPedido_por_Cliente> pedido_a_entregar)
        {
            int[] valor = ValorDeCadaPedido(pedido);

            int i, w;
            int acumvolumen = 0;
            int[,] K = new int[pedido.Count + 1, peso + 1];

            bool flag;
            for (i = 0; i <= pedido.Count; i++)
            {
                flag = false;

                for (w = 0; w <= peso; w++)
                {

                    if (i == 0 || w == 0)
                        K[i, w] = 0;
                    else if (pedido[i - 1].peso_pedido <= w && acumvolumen + pedido[i - 1].volumen <= volumen)
                    {
                        if (flag == false)
                        {
                            acumvolumen = acumvolumen + pedido[i - 1].volumen;
                            flag = true;
                        }

                        K[i, w] = Math.Max(valor[i - 1] + K[i - 1, w - pedido[i - 1].peso_pedido], K[i - 1, w]);

                    }
                    else
                        K[i, w] = K[i - 1, w];
                }
            }

            int res = K[pedido.Count, peso];
            i = pedido.Count;
            int j = peso;

            while (i > 0 && j > 0)
            {
                if (K[i, j] == K[i - 1, j])
                {
                    i--;
                    continue;

                }
                else
                {
                    pedido_a_entregar.Add(pedido[i - 1]);
                    j = j - pedido[i - 1].peso_pedido;
                    Eliminarpedido(pedidostotal, pedido[i - 1]);
                    i--;
                }
            }

            int acumpeso = 0;
            int acumvol = 0;
            for (int f = 0; f < pedido_a_entregar.Count; f++)
            {
                acumpeso = acumpeso + pedido_a_entregar[f].peso_pedido;
                acumvol = acumvol + pedido_a_entregar[f].volumen;
            }

            //como acabo de meter a los normales que podia meter, ahora intento con los diferidos
            if (acumpeso < camion.peso_max && acumvol < camion.volumen_max)
            {
                List<cPedido_por_Cliente> listadif = Filtrar_por_pedido(pedidostotal, entrega.diferido);
                RellenadoDinamicoDiferidos(camion.peso_max - acumpeso, camion.volumen_max - acumvol, pedidostotal, listadif, pedido_a_entregar);


            }

        }

        public void RellenadoDinamicoDiferidos(int peso, int volumen, List<cPedido_por_Cliente> pedidostotal, List<cPedido_por_Cliente> pedido, List<cPedido_por_Cliente> pedido_a_entregar)
        {
            int[] valor = ValorDeCadaPedido(pedido);
            
            int i, w;
            int acumvolumen = 0;
            int[,] K = new int[pedido.Count + 1, peso + 1];

            bool flag;
            for (i = 0; i <= pedido.Count; i++)
            {
                flag = false;

                for (w = 0; w <= peso; w++)
                {

                    if (i == 0 || w == 0)
                        K[i, w] = 0;
                    else if (pedido[i - 1].peso_pedido <= w && acumvolumen + pedido[i - 1].volumen <= volumen)
                    {
                        if (flag == false)
                        {
                            acumvolumen = acumvolumen + pedido[i - 1].volumen;
                            flag = true;
                        }

                        K[i, w] = Math.Max(valor[i - 1] + K[i - 1, w - pedido[i - 1].peso_pedido], K[i - 1, w]);

                    }
                    else
                        K[i, w] = K[i - 1, w];
                }
            }

            int res = K[pedido.Count, peso];
            i = pedido.Count;
            int j = peso;

            while (i > 0 && j > 0)
            {
                if (K[i, j] == K[i - 1, j])
                {
                    i--;
                    continue;

                }
                else
                {
                    pedido_a_entregar.Add(pedido[i - 1]);
                    j = j - pedido[i - 1].peso_pedido;
                    Eliminarpedido(pedidostotal, pedido[i - 1]);
                    i--;
                }
            }

           
            //ya meti todos los productos que podia, tanto express como noramles y diferidos
        }


        //FUNCIONES DE DESPACHO 

        public List<eLocalidad> despacho_de_productos(List<cPedido_por_Cliente> pedidos_del_dia, List<cPedido_por_Cliente> pedido_a_entregar, cVehiculo camion)
        {

            List<eLocalidad> camino_mas_corto = new List<eLocalidad>();
           
            LlenadoCamion(camion, pedidos_del_dia, pedido_a_entregar); //lleno el camion, cuando vuelvo a esta funcion,en pedido a entregar tengo la lista de elementos a entregar

            int barrios_a_recorrer = Barrios_en_pedido_del_dia(pedido_a_entregar); //obtengo la cantidad de barrios a recorrer
            int[,] matriz = new int[barrios_a_recorrer, barrios_a_recorrer]; //me creo mi matriz de distancia, que voy a usar como "grafo"
            List<eLocalidad> lista_localidades = Lista_Barrios_Ordenada(pedido_a_entregar);//obtengo la lista de localidades en orden de menor a mayor distancia de liniers
            matriz = llenar_matriz_con_distancias(lista_localidades, barrios_a_recorrer); //me va a llenar la matriz con las distancias entre cada barrio a barrio que voy a recorrer 
            
            camino_mas_corto = encontrar_camino_mas_corto_greedy(camion,matriz, barrios_a_recorrer, lista_localidades); //encontramos el camino greedy para recorrer todos los barrios de los pedidos que entraron en el camion


            //ya tengo la lista de pedidos a entregar y la lista de barrios a recorrer en orden 
            //primero ordena por barrio, poniendo primero a los del primer barrio a recorrer y después los del último barrio. 
            pedido_a_entregar = Ordenar_por_pedidio(camino_mas_corto, pedido_a_entregar);


            return camino_mas_corto; //retorno el camino a recorrer

        }

       
        //FUNCIONES DE DEVALUACION Y DISPONIBILIDAD CAMIONES

        public void verificar_devaluacion_camiones()
        {
            //sabemos en el pos0 esta la camioneta, en la pos1 el furgon y en la pos2 la furgoneta
            for (int i = 0; i < this.listaCamiones.Count; i++)
            {
                //si el vehiculo tiene 1 año de uso, se desprecia un 25% de su precio
                if (this.listaCamiones.ElementAt(i).meses_uso == 12)//si el vehiculo se uso por un año
                {
                    this.listaCamiones[i].Devaluacion();//devaluamos su precio
                }
            }
        }

        public void camiones_disponibles(DateTime dia_hoy)
        {
            List<cVehiculo> vector_camiones = new List<cVehiculo>();
           //dependiendo el dia de la semana que sea, salen distintos camiones
           //a veces salen solo las camionetas y a veces los 3 camiones

            switch (dia_hoy.DayOfWeek)
            {
                case (DayOfWeek)1: //lunes
                    vector_camiones.Add(this.listaCamiones.ElementAt(0)); //la camioneta
                    vector_camiones.Add(this.listaCamiones.ElementAt(1)); //el furgon
                    vector_camiones.Add(this.listaCamiones.ElementAt(2)); //la furgoneta
                    break;
                case (DayOfWeek)2: //martes
                    vector_camiones.Add(this.listaCamiones.ElementAt(0));
                    vector_camiones.Add(this.listaCamiones.ElementAt(1));
                    break;
                case (DayOfWeek)3: //miercoles
                    vector_camiones.Add(this.listaCamiones.ElementAt(0));
                    vector_camiones.Add(this.listaCamiones.ElementAt(1));
                    vector_camiones.Add(this.listaCamiones.ElementAt(2));
                    break;
                case (DayOfWeek)4: //jueves
                    vector_camiones.Add(this.listaCamiones.ElementAt(0));
                    vector_camiones.Add(this.listaCamiones.ElementAt(1));
                    break;
                case (DayOfWeek)5: //viernes
                    vector_camiones.Add(this.listaCamiones.ElementAt(0));
                    vector_camiones.Add(this.listaCamiones.ElementAt(1));
                    vector_camiones.Add(this.listaCamiones.ElementAt(2));
                    break;
                case (DayOfWeek)6: //sabado
                    vector_camiones.Add(this.listaCamiones.ElementAt(0));
                    break;
                case (DayOfWeek)0: //domingo
                    vector_camiones.Add(this.listaCamiones.ElementAt(0));
                    vector_camiones.Add(this.listaCamiones.ElementAt(1));
                    vector_camiones.Add(this.listaCamiones.ElementAt(2));
                    break;
            }
            //cosimundo tiene una lista tanto de camiones definitivos y camiones disponibles
            //los camiones disponibles son los que se pueden usar ese dia, y los definitivos son los que tiene disponibles para usar
            for(int i = 0; i < vector_camiones.Count; i++)
            {
                //cargamos en la lista de camiones disponibles para usar hoy, la lista que se definio segun el dia que se podia usar
                this.camionesdisponibleshoy.Add(vector_camiones[i]);
            }
        }

        public int max_viajes_por_dia()
        {
            //dependiendo el camion que este disponible y la cantidad de camiones, vamos a tener una distinta cantidad de viajes max por dia
            int viajes = 4;  //la camioneta siemrpe sale por lo que siempre voy a tener 4 viajes minimo
            if (this.camionesdisponibles.Count == 2) //si solo sale el furgon o la furgoneta mas la camioneta
                viajes++;
            if (this.camionesdisponibles.Count == 3) //si salen los 3 vehiculos
                viajes = viajes + 2;
            return viajes;
        }

        public void sumar_mes_camiones()
        {
            //si el dia ingresado por windowsforms es un 1, entonces le suma un mes a los meses de uso de los camiones
            for (int i = 0; i < 3; i++)
            {
                this.listaCamiones[i].sumarmesdeuso();
            }
            //se fijan si tiene q devaluar al camion, es decir si ya llego al año de uso
            verificar_devaluacion_camiones();
        }

     
    }
}
