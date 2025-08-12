using System;
using b_taller_automovil.Eventos;
using b_taller_automovil.Interfaces;

namespace b_taller_automovil.Clases
{
    public class creditoCliente : I_credito
    {
        public Publisher_CreditoActualizado publicador2 { get; set; }

        public creditoCliente(Publisher_CreditoActualizado publicador)
        {
            this.publicador2 = publicador;
            this.publicador2.evt_credito += event_Handler;
        }

        public void event_Handler()
        {
            Console.WriteLine("EVENTO: Credito actualizado.");
        }

        public string Credito_Cliente(Cliente cliente, float saldo_pendiente)
        {
            if (!cliente.credito)
            {
                return "El cliente no tiene crédito disponible.";
            }

            if (saldo_pendiente > 0)
            {
                cliente.saldopendiente += saldo_pendiente;

                if (publicador2 != null)
                {
                    publicador2.informar_credito_actualizado(true);
                }

                return $"Crédito actualizado. Monto pendiente total: {cliente.saldopendiente}.";
            }

            return "No hay saldo pendiente para agregar al crédito.";
        }

        public float cancelar_pago_credito(float pago, float pendiente)
        {
            // This logic belongs in the cancelarPagoCredito class according to the diagram
            throw new NotImplementedException("This method should be called on an instance of cancelarPagoCredito.");
        }
    }
}
