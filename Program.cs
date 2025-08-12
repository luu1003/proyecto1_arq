using System;
using b_taller_automovil.Clases;

namespace b_taller_automovil
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the main Taller class
            Taller taller = new Taller();

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("---- Taller Automovil Menu ----");
                Console.WriteLine("1. Register a new vehicle for repair");
                Console.WriteLine("2. Finalize a repair");
                Console.WriteLine("3. Process a payment");
                Console.WriteLine("4. Manage client credit");
                Console.WriteLine("5. Exit");
                Console.Write("Select an option: ");

                string input = Console.ReadLine();
                Console.WriteLine();

                switch (input)
                {
                    case "1":
                        taller.RegistrarVehiculo();
                        break;
                    case "2":
                        taller.FinalizarReparacion();
                        break;
                    case "3":
                        taller.ProcesarPago();
                        break;
                    case "4":
                        taller.GestionarCredito();
                        break;
                    case "5":
                        exit = true;
                        Console.WriteLine("Exiting application...");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
