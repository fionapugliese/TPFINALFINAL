using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFINALFINAL
{
    internal class cVehiculo
    {
        protected int peso;
        public int peso_max
        {
            get { return peso; }
            set { }

        }

        protected int volumen;
        public int volumen_max
        {
            get { return volumen; }
            set { }
        }

        protected float precio_actualventa;
        public float precio_vehiculo
        {
            get { return precio_actualventa; }
            set { }
        }

        protected float nafta;
        public float cant_nafta
        {
            get { return nafta; }
            set { }
        }

        protected int cant_meses_uso;
        public int meses_uso
        {
            get { return cant_meses_uso; }
            set { }
        }

        private bool elevador_;
        public bool elevador
        {
            get { return elevador_; }
            set { }
        }

        public cVehiculo(int meses_, float nafta, float precio)
        {
            this.nafta = nafta;
            this.cant_meses_uso = meses_;
            this.precio_actualventa = precio;
            elevador_ = false;

        }

        public void sumarmesdeuso()
        {
            this.meses_uso = this.meses_uso + 1;
        }
        public void setelevador(bool estado)
        {
            this.elevador = estado;
        }
        public void Devaluacion()
        {
            if (this.precio_actualventa > 0)
                this.precio_actualventa = (float)(this.precio_actualventa * 0.75);

            this.meses_uso = 0;
        }
        public void CargarNafta(float litros)
        {
            this.nafta = this.nafta + litros;
        }

        ~cVehiculo() { }
    }
}
