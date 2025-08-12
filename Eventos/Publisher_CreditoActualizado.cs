using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using b_taller_automovil.Clases;

namespace b_taller_automovil.Eventos
{
    public class Publisher_CreditoActualizado
    {
        public delegate void delegado_credito();
        public event delegado_credito evt_credito;

        public void informar_credito_actualizado(bool aprobado)
        {
            if (evt_credito != null)
            {
                evt_credito();
            }
        }
    }
}
