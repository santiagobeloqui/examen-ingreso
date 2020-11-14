using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenIngreso
{
    class Camisa : Prenda
    { 
        private bool esMangaCorta;
        private bool esCuelloMao;

        public bool EsMangaCorta
        {
            get
            {
                return this.esMangaCorta;
            }
        }
        public bool EsCuelloMao
        {
            get
            {
                return this.esCuelloMao;
            }
        }


        public Camisa(bool esMangaCorta, bool esCuelloMao, int unidadesEnStock)
        {
            this.esMangaCorta = esMangaCorta;
            this.esCuelloMao = esCuelloMao;
            this.unidadesEnStock = unidadesEnStock;                
        }

        public override float CalcularPrecio(float precioInicial, bool esPremium)
        {
            float precioFinal = precioInicial;
            this.esPremium = esPremium;
            this.precio = precioInicial;

            if (esMangaCorta)
            {
                precioFinal = precioFinal - (precioFinal / 100) * 10;
            }

            if (esCuelloMao)
            {
                precioFinal = precioFinal + (precioFinal / 100) * 3;
            }

            if(this.esPremium)
            {
                precioFinal = precioFinal + (precioFinal / 100) * 30;
            }

            return precioFinal;
        }
    }
}
