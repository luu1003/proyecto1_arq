using System;
using b_taller_automovil.Eventos;
using b_taller_automovil.Interfaces;

namespace b_taller_automovil.Clases
{
    public class vehiculoIngresado : I_GestionReparacion
    {
        public Publisher_VehiculoIngresado publicador_2 { get; set; }

        public vehiculoIngresado(Publisher_VehiculoIngresado publicador)
        {
            this.publicador_2 = publicador;
            this.publicador_2.evt_ingreso += Event_Handler;
        }

        public void Event_Handler()
        {
            Console.WriteLine("EVENTO: Vehiculo ingresado al taller.");
        }

        public void Procesar(ListaReparacion reparacion)
        {
            Console.WriteLine($"Procesando ingreso del vehiculo con placa: {reparacion.Carro.Placa}");

            if (publicador_2 != null)
            {
                publicador_2.informar_ingreso_vehiculo(true);
            }
        }
    }
}
