using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PARCIAL_19_5
{
    internal abstract class Vehiculo
    {
        protected double capacidadActualTanque;
        protected double consumoKmPorLitro;
        protected double capacidadTanque;
        protected double kmRecorridos;
        protected string modelo;
        protected string marca;

        public event EventHandler PocoCombustibleEventHandler;

        public void evaluarCombustible()
        {
            bool hayHandler = this.PocoCombustibleEventHandler != null;
            bool pocoCombustible = this.CapacidadActualTanque <= 10;
            if(pocoCombustible && hayHandler)
            {
                this.PocoCombustibleEventHandler(this, EventArgs.Empty);
            }
        }

        public double CapacidadActualTanque { 
            get => this.capacidadActualTanque;
            set => this.capacidadActualTanque = value;
        }
        public double KmRecorridos { get => this.kmRecorridos; set => this.kmRecorridos = value;}
        public double ConsumoKmPorLitro { get => this.consumoKmPorLitro; }
        public double CapacidadTanque { get => this.capacidadTanque; }
        public string Modelo { get => this.modelo; }
        public string Marca { get => this.marca; }

        public abstract string SimularViaje(double kmRecorridos);
        public abstract void CargarCombustible();
    }
}
