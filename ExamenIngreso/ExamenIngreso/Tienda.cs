using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenIngreso
{
    class Tienda
    {
        private String nombre;
        private String direccion;
        private List<Prenda> prendasEnVenta;

        public String Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        public String Direccion
        {
            get
            {
                return this.direccion;
            }
        }

        public List<Prenda> PrendasEnVenta{
            get{
                return this.prendasEnVenta;
            }
        }

        public Tienda(String nombre, String direccion)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.prendasEnVenta = new List<Prenda>();
        }
    }
}
