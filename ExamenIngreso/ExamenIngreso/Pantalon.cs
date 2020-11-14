using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenIngreso
{
    class Pantalon: Prenda
    {
        private bool esChupin;

        public bool EsChupin
        {
            get{
                return this.esChupin;
            }
        }

        public Pantalon(bool esChupin, int unidadesEnStock)
        {
            this.esChupin = esChupin;
            this.unidadesEnStock = unidadesEnStock;
        }

        public override float CalcularPrecio(float precioInicial, bool esPremium)
        {
            float precioFinal = precioInicial;
            this.esPremium = esPremium;
            this.precio = precioInicial;

            if (esChupin)
            {
                precioFinal = precioFinal - (precioFinal / 100) * 12;
            }

            if (this.esPremium)
            {
                precioFinal = precioFinal + (precioFinal / 100) * 30;
            }

            return precioFinal;
        }
    }
}
