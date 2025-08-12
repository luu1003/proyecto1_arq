using System;
using System.Collections.Generic;
using System.Linq;
using b_taller_automovil.Eventos;
using b_taller_automovil.Interfaces;

namespace b_taller_automovil.Clases
{
    public class Taller
    {
        // Lists to hold the main data of the workshop
        private List<ListaReparacion> reparacionesEnProceso;
        private List<Cliente> clientes;
        private List<Mecanico> mecanicos;

        // Logic components (strategies)
        private vehiculoIngresado gestorIngreso;
        private reparacionFinalizada gestorFinalizacion;
        private cancelarPago gestorPago;
        private creditoCliente gestorCredito;
        private cancelarPagoCredito gestorPagoCredito;

        public Taller()
        {
            // Initialize data lists
            reparacionesEnProceso = new List<ListaReparacion>();
            clientes = new List<Cliente>();
            mecanicos = new List<Mecanico>();

            // Initialize publishers
            var pubIngreso = new Publisher_VehiculoIngresado();
            var pubFinalizacion = new Publisher_ReparacionFinalizada();
            var pubFactura = new Publisher_FacturaCanceladaSalida();
            var pubCredito = new Publisher_CreditoActualizado();

            // Initialize logic components with their publishers
            gestorIngreso = new vehiculoIngresado(pubIngreso);
            gestorFinalizacion = new reparacionFinalizada(pubFinalizacion);
            gestorPago = new cancelarPago(pubFactura);
            gestorCredito = new creditoCliente(pubCredito);
            gestorPagoCredito = new cancelarPagoCredito(pubCredito);
        }

        // --- Public methods for the main menu ---

        public void RegistrarVehiculo()
        {
            Console.WriteLine("--- Registrar Nuevo Vehiculo ---");
            // This is a simplified version. In a real app, we would get this data from user input.
            Cliente nuevoCliente = new Cliente(1, "Juan Perez", 1234567, true);
            clientes.Add(nuevoCliente);

            Carro nuevoCarro = new Gasolina("XYZ-123", "Toyota", "Corolla", 2020, nuevoCliente, 4);

            Reparacion nuevaReparacion = new Reparacion(gestorFinalizacion, null); // Container is null for now
            ListaReparacion nuevaListaReparacion = new ListaReparacion(nuevoCarro, new List<Repuestos>(), new List<Mecanico>(), nuevaReparacion);

            // Now set the container for the new Reparacion object using the public method
            nuevaReparacion.SetContainer(nuevaListaReparacion);

            reparacionesEnProceso.Add(nuevaListaReparacion);

            // Use the gestor de ingreso to process it
            gestorIngreso.Procesar(nuevaListaReparacion);

            Console.WriteLine("Vehiculo registrado exitosamente.");
        }

        public void FinalizarReparacion()
        {
            Console.WriteLine("--- Finalizar una Reparacion ---");
            // Find a repair to finalize
            if (reparacionesEnProceso.Any())
            {
                var reparacionAFinalizar = reparacionesEnProceso.First(); // Simplification
                reparacionAFinalizar.L_reparaciones.Finalizar_Reparacion();
                Console.WriteLine($"Reparacion para {reparacionAFinalizar.Carro.Placa} finalizada.");
            }
            else
            {
                Console.WriteLine("No hay reparaciones en proceso.");
            }
        }

        public void ProcesarPago()
        {
            Console.WriteLine("--- Procesar un Pago ---");
            if (reparacionesEnProceso.Any())
            {
                var reparacionAPagar = reparacionesEnProceso.First(); // Simplification
                float costoTotal = reparacionAPagar.Valor; // Simplified cost
                float pago = costoTotal; // Assume full payment

                string resultado = gestorPago.Cancelar_pago(pago, reparacionAPagar.Carro.Dueño, costoTotal);
                Console.WriteLine(resultado);
            }
            else
            {
                Console.WriteLine("No hay reparaciones para pagar.");
            }
        }

        public void GestionarCredito()
        {
            Console.WriteLine("--- Gestionar Credito de Cliente ---");
            if (clientes.Any())
            {
                var cliente = clientes.First(); // Simplification
                // Example: add a pending amount to credit
                string resultado = gestorCredito.Credito_Cliente(cliente, 500);
                Console.WriteLine(resultado);

                // Example: pay off some credit
                float nuevoSaldo = gestorPagoCredito.cancelar_pago_credito(200, cliente.saldopendiente);
                cliente.saldopendiente = nuevoSaldo;
                Console.WriteLine($"Se ha pagado parte del credito. Nuevo saldo pendiente: {cliente.saldopendiente}");
            }
             else
            {
                Console.WriteLine("No hay clientes registrados.");
            }
        }
    }
}
