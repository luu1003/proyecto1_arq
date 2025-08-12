using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using b_taller_automovil.Clases;

namespace b_taller_automovil.Eventos
{
    public class Publisher_FacturaCanceladaSalida
    {
        public delegate void delegado_cancelacion_salida();
        public event delegado_cancelacion_salida evt_factura;

        public void informar_cancelamiento_factura_salida(float pago)
        {
            if (evt_factura != null)
            {
                evt_factura();
            }
        }
    }
}
