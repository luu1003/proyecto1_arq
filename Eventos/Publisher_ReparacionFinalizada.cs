using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using b_taller_automovil.Clases;

namespace b_taller_automovil.Eventos
{
    public class Publisher_ReparacionFinalizada
    {
        public delegate void delegado_reparacionFinalizada();
        public event delegado_reparacionFinalizada evt_reparacion;

        public void informar_reparacion_finalizada(bool final)
        {
            if (evt_reparacion != null)
            {
                evt_reparacion();
            }
        }
    }
}
