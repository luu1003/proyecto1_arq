using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using b_taller_automovil.Eventos;

namespace b_taller_automovil.Clases
{
    public class ListaReparacion
    {
        private float valor = 1200000;
        private Carro carro;
        private DateTime fecha;
        private List<Repuestos> l_repuestos;
        private List<Mecanico> l_mecanicos;
        private Reparacion l_reparaciones;


        public ListaReparacion(Carro carro, List<Repuestos> l_repuestos, List<Mecanico> l_mecanicos, Reparacion l_reparaciones)
        {
            this.carro = carro;
            this.fecha = DateTime.Now;
            this.l_repuestos = l_repuestos;
            this.l_mecanicos = l_mecanicos;
            this.l_reparaciones = l_reparaciones;
        }

        public float Valor { get => valor; set => valor = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public Carro Carro { get => carro; set => carro = value; }
        public List<Repuestos> L_repuestos { get => l_repuestos; set => l_repuestos = value; }
        public List<Mecanico> L_mecanicos { get => l_mecanicos; set => l_mecanicos = value; }
        public Reparacion L_reparaciones { get => l_reparaciones; set => l_reparaciones = value; }
    }
}
