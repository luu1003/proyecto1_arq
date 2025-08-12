using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b_taller_automovil.Clases
{
    public abstract class Persona
    {
        public int id;
        public string nombre;
        public int telefono;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Telefono { get => telefono; set => telefono = value; }

        public Persona(int id, string nombre, int telefono)
        {
            Id = id;
            Nombre = nombre;
            Telefono = telefono;
        }
    }
}
