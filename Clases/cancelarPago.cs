using System;
using b_taller_automovil.Eventos;
using b_taller_automovil.Interfaces;

namespace b_taller_automovil.Clases
{
    public class cancelarPago : I_pago
    {
        public Publisher_FacturaCanceladaSalida publicador { get; set; }

        public cancelarPago(Publisher_FacturaCanceladaSalida publicador)
        {
            this.publicador = publicador;
            this.publicador.evt_factura += Event_Handler;
        }

        public void Event_Handler()
        {
            Console.WriteLine("EVENTO: Factura procesada.");
        }

        public string Cancelar_pago(float pago, Cliente cliente, float costo_total)
        {
            string message;
            if (pago < costo_total)
            {
                cliente.saldopendiente = costo_total - pago;
                message = $"Pago incompleto. Saldo pendiente: {cliente.saldopendiente}";
            }
            else
            {
                cliente.saldopendiente = 0;
                message = "Pago realizado con exito.";

                // Disparar el evento
                if (publicador != null)
                {
                    publicador.informar_cancelamiento_factura_salida(pago);
                }
            }
            return message;
        }

        public float Cancelar_pago_float(float pago, Cliente cliente, float costo_total)
        {
            if (pago < costo_total)
            {
                cliente.saldopendiente = costo_total - pago;
            }
            else
            {
                cliente.saldopendiente = 0;

                // Disparar el evento
                if (publicador != null)
                {
                    publicador.informar_cancelamiento_factura_salida(pago);
                }
            }
            return cliente.saldopendiente;
        }
    }
}
