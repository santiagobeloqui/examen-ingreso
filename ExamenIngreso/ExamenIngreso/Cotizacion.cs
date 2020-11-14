using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenIngreso
{
    class Cotizacion
    {
        private int numeroIdentificacion;
        private DateTime fechaHora;
        private int codigoVendedor;
        private Prenda prenda;
        private int cantidadUnidades;
        private float resultadoCotizacion;

        public Cotizacion(int numeroIdentificacion, DateTime fechaHora, int codigoVendedor, Prenda prenda, int cantidadUnidades, float resultadoCotizacion)
        {
            this.numeroIdentificacion = numeroIdentificacion;
            this.fechaHora = fechaHora;
            this.codigoVendedor = codigoVendedor;
            this.prenda = prenda;
            this.cantidadUnidades = cantidadUnidades;
            this.resultadoCotizacion = resultadoCotizacion;
    }

        public int NumeroIdentificacion {
            get {
                return this.numeroIdentificacion;
            }
        }
        public DateTime FechaHora {
            get
            {
                return this.fechaHora;
            } 
        }
        public int CodigoVendedor
        {
            get
            {
                return this.codigoVendedor;
            }
        }
        public Prenda Prenda
        {
            get
            {
                return this.prenda;
            }
        }
        public int CantidadUnidades 
        {
            get
            {
                return this.cantidadUnidades;
            }
        }
        public float ResultadoCotizacion 
        {
            get
            {
                return this.resultadoCotizacion;
            }
        }


    }
}
