using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b_taller_automovil.Clases
{
    public class Cliente : Persona
    {
        public bool credito;
        public int saldo;
        public float saldopendiente;

        public Cliente(int id, string nombre, int telefono, bool credito) : base(id, nombre, telefono)
        {
            this.Credito = credito;
            this.Saldo = 0;
        }


        public bool Credito { get => credito; set => credito = value; }
        public int Saldo { get => saldo; set => saldo = value; }
        public float Saldopendiente { get => saldopendiente; set => saldopendiente = value; }
    }
}
