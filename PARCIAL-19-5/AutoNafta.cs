using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace PARCIAL_19_5
{
    internal class AutoNafta: Vehiculo
    {

        public AutoNafta(string modelo, string marca, double capacidadTanque, double consumoKmPorLitro)
        {
            this.capacidadActualTanque = capacidadTanque;
            this.consumoKmPorLitro = consumoKmPorLitro;
            this.capacidadTanque = capacidadTanque;
            this.modelo = modelo;
            this.marca = marca;
        }
        public override string SimularViaje(double kmRecorridos)
        {
            double litrosAConsumirDelViaje = this.consumoKmPorLitro * kmRecorridos;

            if (litrosAConsumirDelViaje > this.capacidadActualTanque)
                return "Los litros a consumir del viaje deben ser menor o igual a la capacidad actual del tanque";
            else
            {
                this.kmRecorridos += kmRecorridos;
                this.capacidadActualTanque -= litrosAConsumirDelViaje;
                return $"Se ha realizado un viaje correctamente, se recorrieron {KmRecorridos}KMS y el gasto de combustible fue de {litrosAConsumirDelViaje} LITROS";
            }
        }

        public override void CargarCombustible()
        {
            this.capacidadActualTanque = this.capacidadTanque;
        }

    }
}
