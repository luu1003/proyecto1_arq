using System;
using b_taller_automovil.Eventos;
using b_taller_automovil.Interfaces;

namespace b_taller_automovil.Clases
{
    public class cancelarPagoCredito : I_credito
    {
        public Publisher_CreditoActualizado publicador2 { get; set; }

        // This class may not need a publisher, but it's required by the interface.
        public cancelarPagoCredito(Publisher_CreditoActualizado publicador)
        {
            this.publicador2 = publicador;
            // We don't subscribe to the event here as this class doesn't handle credit updates.
        }

        public float cancelar_pago_credito(float pago, float pendiente)
        {
            if (pendiente <= 0)
            {
                return 0; // No pending balance
            }

            float nuevoSaldo = pendiente - pago;

            // Return the new pending balance.
            // The caller is responsible for updating the client's object.
            return Math.Max(nuevoSaldo, 0); // Do not allow negative balance
        }

        public void event_Handler()
        {
            throw new NotImplementedException("This method should be called on an instance of creditoCliente.");
        }

        public string Credito_Cliente(Cliente cliente, float saldo_pendiente)
        {
            throw new NotImplementedException("This method should be called on an instance of creditoCliente.");
        }
    }
}
