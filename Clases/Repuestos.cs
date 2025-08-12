using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b_taller_automovil.Clases
{
    public class Repuestos
    {
        private string nombre;
        private string proveedor;
        private DateTime fecha_compra;
        private decimal precio;

        public Repuestos(string nombre, string proveedor, DateTime fecha_compra)
        {
            this.Nombre = nombre;
            this.Proveedor = proveedor;
            this.Fecha_compra = fecha_compra;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Proveedor { get => proveedor; set => proveedor = value; }
        public DateTime Fecha_compra { get => fecha_compra; set => fecha_compra = value; }
        public decimal Precio { get => precio; set => precio = value; }
    }
}
