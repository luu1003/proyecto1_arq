using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using b_taller_automovil.Eventos;
using b_taller_automovil.Interfaces;

namespace b_taller_automovil.Clases
{
    public abstract class Carro : IReparacion
    {
        private string placa;
        private string marca;
        private string modelo;
        private int año;
        private Cliente dueño;


        public string Placa { get => placa; set => placa = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public int Año { get => año; set => año = value; }
        public Cliente Dueño { get => dueño; set => dueño = value; }

        public Carro(string placa, string marca, string modelo, int año, Cliente dueño)
        {
            this.Placa = placa;
            this.Marca = marca;
            this.Modelo = modelo;
            this.Año = año;
            this.Dueño = dueño;
        }

        public abstract string reparacion_puesta_punto();
    }
}
