using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenIngreso
{
    class Vendedor
    {
        private String nombre;
        private String apellido;
        private int codigoVendedor;
        private List<Cotizacion> historial;

        public String Nombre
        {
            get
            {
                return this.nombre;
            }
        }
        
        public String Apellido
        {
            get
            {
                return this.apellido;
            }
        }

        public int CodigoVendedor
        {
            get
            {
                return this.codigoVendedor;
            }
        }
        public List<Cotizacion> Historial {

            get
            {
                return historial;
            }
        }

        public Vendedor(String nombre, String apellido, int codigoVendedor)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.codigoVendedor = codigoVendedor;
            this.historial = new List<Cotizacion>();
        }
    }
}
