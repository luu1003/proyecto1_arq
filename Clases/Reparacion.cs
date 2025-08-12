using System;
using b_taller_automovil.Interfaces;

namespace b_taller_automovil.Clases
{
    public class Reparacion
    {
        private bool ingreso = false;
        private I_GestionReparacion gestionReparacion;
        private ListaReparacion listaReparacionContainer;

        public Reparacion(I_GestionReparacion gestionReparacion, ListaReparacion container)
        {
            this.gestionReparacion = gestionReparacion;
            this.listaReparacionContainer = container;
            this.ingreso = true;
        }

        public void SetContainer(ListaReparacion container)
        {
            this.listaReparacionContainer = container;
        }

        public void Finalizar_Reparacion()
        {
            Console.WriteLine("Iniciando el proceso de finalizacion de reparacion...");
            if (gestionReparacion != null && listaReparacionContainer != null)
            {
                gestionReparacion.Procesar(this.listaReparacionContainer);
            }
            else
            {
                Console.WriteLine("Error: La reparacion no esta correctamente inicializada.");
            }
        }
    }
}
