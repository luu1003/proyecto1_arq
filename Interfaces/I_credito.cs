using System;
using b_taller_automovil.Clases;
using b_taller_automovil.Eventos;

namespace b_taller_automovil.Interfaces
{
    public interface I_credito
    {
        Publisher_CreditoActualizado publicador2 { get; set; }
        void event_Handler();
        string Credito_Cliente(Cliente cliente, float saldo_pendiente);
        float cancelar_pago_credito(float pago, float pendiente);
    }
}
