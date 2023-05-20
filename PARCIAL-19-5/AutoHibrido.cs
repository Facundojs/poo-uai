using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PARCIAL_19_5
{
    internal class AutoHibrido : Vehiculo
    {
        private double bateriaActual;
        private double consumoBateriaPorKm;

        public AutoHibrido(
            string modelo, string marca, double capacidadTanque,
            double consumoKmPorLitro, double consumoBateriaPorKm
        )
        {
            this.consumoBateriaPorKm = consumoBateriaPorKm;
            this.CapacidadActualTanque = capacidadTanque;
            this.consumoKmPorLitro = consumoKmPorLitro;
            this.capacidadTanque = capacidadTanque;
            this.bateriaActual = 100;
            this.modelo = modelo;
            this.marca = marca;
        }

        public double BateriaActual { get => this.bateriaActual; }

        public override string SimularViaje(double kmRecorridos)
        {
            double bateriaAConsumirViaje = kmRecorridos * this.consumoBateriaPorKm;
            bool alcanzaBateria = this.bateriaActual >= bateriaAConsumirViaje;
            double litrosConsumidos = 0;
            double bateriaConsumida = 0;
            if (!alcanzaBateria)
            {
                double litrosAConsumirDelViaje = kmRecorridos / this.consumoKmPorLitro;
                if(litrosAConsumirDelViaje >= this.capacidadActualTanque)
                    return $"No tienes suficientes recursos para este viaje";
                else
                    litrosConsumidos = litrosAConsumirDelViaje;
            } else
            {
                bateriaConsumida = bateriaAConsumirViaje;
            }

            this.CapacidadActualTanque -= litrosConsumidos;
            this.bateriaActual -= bateriaConsumida;
            this.kmRecorridos += kmRecorridos;

            string response = $"Se ha realizado un viaje correctamente, se recorrieron {kmRecorridos} KMS";

            if (bateriaConsumida > 0)
                return response += $", el gasto de batería fue del {bateriaAConsumirViaje}%";
            return response += $", el gasto de combustible fue de {litrosConsumidos} LITROS";
        }

        public override void CargarCombustible()
        {
            this.CapacidadActualTanque = this.capacidadTanque;
            this.cargarBateria();
        }

        public void cargarBateria() 
        {
            this.bateriaActual = 100;
        }
    }
}
