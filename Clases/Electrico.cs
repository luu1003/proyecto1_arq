using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using b_taller_automovil.Interfaces;

namespace b_taller_automovil.Clases
{
    public class Electrico : Carro
    {
        private ushort autonomia;

        public Electrico(string placa, string marca, string modelo, int año, Cliente dueño, ushort autonomia)
            : base(placa, marca, modelo, año, dueño)
        {
            this.Autonomia = autonomia;
        }

        public Electrico(string placa, string marca, string modelo, int año, Cliente dueño)
            : base(placa, marca, modelo, año, dueño)
        {
        }
        public ushort Autonomia { get => autonomia; set => autonomia = value; }
        public override string reparacion_puesta_punto()
        {
            return $"Se comprobo el estado de la batería, se cambiaron los lubricantes, se examino el desgaste de las llantas, se examino la amortiguación y se cambia el líquido de frenos";
        }
    }
}
