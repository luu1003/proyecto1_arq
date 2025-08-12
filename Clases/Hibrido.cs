using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b_taller_automovil.Clases
{
    public class Hibrido : Carro
    {
        private byte numero_bateria;

        public Hibrido(string placa, string marca, string modelo, int año, Cliente dueño, byte numero_bateria)
            : base(placa, marca, modelo, año, dueño)
        {
            this.Numero_bateria = numero_bateria;
        }

        public Hibrido(string placa, string marca, string modelo, int año, Cliente dueño)
            : base(placa, marca, modelo, año, dueño)
        {
        }

        public byte Numero_bateria { get => numero_bateria; set => numero_bateria = value; }

        public override string reparacion_puesta_punto()
        {
            return $"Se lubrico el motor generador eléctrico, tambien se cambian los frenos y se calibran, recarga de las baterías, se examina el desgaste de las llantas, se examina amortiguación y se cambia el líquido de frenos.";
        }
    }
}
