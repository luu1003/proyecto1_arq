using System;
using b_taller_automovil.Eventos;
using b_taller_automovil.Interfaces;

namespace b_taller_automovil.Clases
{
    public class reparacionFinalizada : I_GestionReparacion
    {
        public Publisher_ReparacionFinalizada publicador { get; set; }

        public reparacionFinalizada(Publisher_ReparacionFinalizada publicador)
        {
            this.publicador = publicador;
            this.publicador.evt_reparacion += Event_Handler;
        }

        public void Event_Handler()
        {
            Console.WriteLine("EVENTO: La reparacion del vehiculo ha finalizado.");
        }

        public void Procesar(ListaReparacion reparacion)
        {
            Console.WriteLine($"Procesando finalizacion de la reparacion para el vehiculo: {reparacion.Carro.Placa}");

            if (publicador != null)
            {
                publicador.informar_reparacion_finalizada(true);
            }
        }
    }
}
