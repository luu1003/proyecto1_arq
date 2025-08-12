using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using b_taller_automovil.Clases;

namespace b_taller_automovil.Eventos
{
    public class Publisher_VehiculoIngresado
    {
        public delegate void delegado_vehiculo_ingresado();
        public event delegado_vehiculo_ingresado evt_ingreso;

        public void informar_ingreso_vehiculo(bool carro)
        {
            if (evt_ingreso != null)
            {
                evt_ingreso();
            }
        }
    }
}
