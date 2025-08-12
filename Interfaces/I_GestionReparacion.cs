using System;
using b_taller_automovil.Clases;

namespace b_taller_automovil.Interfaces
{
    public interface I_GestionReparacion
    {
        void Event_Handler();
        void Procesar(ListaReparacion reparacion);
    }
}
