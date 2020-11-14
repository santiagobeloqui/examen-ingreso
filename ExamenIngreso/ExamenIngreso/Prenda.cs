using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenIngreso
{
    abstract class Prenda
    {

        protected bool esPremium;
        protected float precio;
        protected int unidadesEnStock;

        public int UnidadesEnStock
        {
            get
            {
                return this.unidadesEnStock;
            }
        }

        public abstract float CalcularPrecio(float precioInicial, bool esPremium);
    }
}
