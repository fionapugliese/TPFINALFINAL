using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFINALFINAL
{
    internal class cPedido_por_Cliente
    {

        //atributos
        string nombre_cliente;
        public string nombre
        {
            get { return nombre_cliente; }
        }

        List<cElectrodomesticos> compra;
        public List<cElectrodomesticos> compra_objetos
        {
            get { return compra; }
            set { }
        }

        int cant_de_objetos;
        public int cantidad_objetos
        {
            get { return cant_de_objetos; }
            set { }
        }
        eLocalidad barrio_a_entregar;
        public eLocalidad barrio
        {
            get { return barrio_a_entregar; }
        }

        int peso_total;
        public int peso_pedido
        {
            get { return peso_total; }
        }
        public int peso_pedido_set
        {
            set { }
        }
        int volumen_total;
        public int volumen
        {
            get { return volumen_total; }
        }
        public int volumen_pedido_set
        {
            set { }
        }



        entrega entrega_compra;
        public entrega tipo_entrega
        {
            get { return entrega_compra; }
            set { }
        }
        //metodos
        public cPedido_por_Cliente(string nombre_, eLocalidad barrio_, List<cElectrodomesticos> obj, entrega entrega_compra_)//ver del cuaderno de progra1 cmo era lo de id
        {
            nombre_cliente = nombre_;
            barrio_a_entregar = barrio_;
            compra = obj;
            cant_de_objetos = obj.Count;
            volumen_total = calculo_volumen_total(compra);
            peso_total = calculo_peso_total(compra);
            entrega_compra = entrega_compra_;


        }

        public void CambiarVolumenTelevisorFurgoneta()
        {
            for (int i = 0; i < compra_objetos.Count; i++)
            {
                if (compra[i].GetType() == typeof(cTelevisores))
                {
                    compra[i].volumenobjeto = compra[i].volumenobjeto - Constants.televisores; //le restamos el volumen del televisor al volumen total del pedido
                    int nuevo_volumen = 2 * 1 * 3; //ancho y profundidad del televisor pero alto del furgoneta
                    compra[i].volumenobjeto = compra[i].volumenobjeto + nuevo_volumen;
                    //una vez que ya esta actualizado el nuevo volumen, sigo como el resto de los pedidos sin televisor

                }
            }
        }

        public void CambiarVolumenTelevisorFurgon()
        {
            for (int i = 0; i < compra_objetos.Count; i++)
            {
                if (compra[i].GetType() == typeof(cTelevisores))
                {
                    compra[i].volumenobjeto = compra[i].volumenobjeto - Constants.televisores; //le restamos el volumen del televisor al volumen total del pedido
                    int nuevo_volumen = 2 * 1 * 5; //ancho y profundidad del televisor pero alto del furgon
                    compra[i].volumenobjeto = compra[i].volumenobjeto + nuevo_volumen;
                    //una vez que ya esta actualizado el nuevo volumen, sigo como el resto de los pedidos sin televisor

                }
            }
        }

        public bool Verificar_electro_pequeño()
        {
            int cont = 0;
            for (int i = 0; i < this.cantidad_objetos; i++)
            {
                //si es un electrodomestico pequeño
                if (this.compra_objetos[i].GetType() == typeof(cPequeños_electrodomesticos))
                    cont++;
            }
            if (cont > 0)
                return true;
            else
                return false;
        }

        int calculo_volumen_total(List<cElectrodomesticos> compra)
        {
            int suma = 0;
            for (int i = 0; i < compra.Count; i++)
            {
                suma = suma + compra[i].volumenobjeto; //peso elemento(objeto) le paso un objeto y me devuelve su volumen

            }
            return suma;
        }

        int calculo_peso_total(List<cElectrodomesticos> compra)
        {
            int suma = 0;
            for (int i = 0; i < compra.Count; i++)
            {
                suma = suma + compra[i].pesoobjeto; //peso elemento(objeto) le paso un objeto y me devuelve cuanto pesa
            }
            return suma;
        }


        ~cPedido_por_Cliente() { }
    }
}
