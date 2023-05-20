using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PARCIAL_19_5
{
    public partial class Form1 : Form
    {
        private Vehiculo vehiculo;

        public Form1()
        {
            InitializeComponent();
            actualizarInfo();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pocoCombustibleEventHandler(object sender, EventArgs e)
        {
            MessageBox.Show("Tiene menos de 10 de combustible!");
        }

        private void asignarEventHandler()
        {
            this.vehiculo.PocoCombustibleEventHandler += pocoCombustibleEventHandler;
        }

        private void btnCrearHibrido_Click(object sender, EventArgs e)
        {
            bool camposValidos = validarCampos(true);

            if (!camposValidos) return;

            vehiculo = new AutoHibrido(
                inputModelo.Text,
                inputMarca.Text,
                Convert.ToDouble(inputCapacidadTanque.Text),
                Convert.ToDouble(inputConsumoKm.Text),
                Convert.ToDouble(inputConsumoBat.Text)
                );
            this.actualizarInfo();
            asignarEventHandler();
        }

        private void btnCrearAutoNafta_Click(object sender, EventArgs e)
        {
            bool camposValidos = validarCampos(false);

            if (!camposValidos) return;

            this.vehiculo = new AutoNafta(
                inputModelo.Text,
                inputMarca.Text,
                Convert.ToDouble(inputCapacidadTanque.Text),
                Convert.ToDouble(inputConsumoKm.Text)
            );
            actualizarInfo();
            asignarEventHandler();
        }

        private void actualizarInfo()
        {
            actualizarBotones();
            actualizarLabels();
            actualizarInputs();
            if(vehiculo != null)
            {
                vehiculo.evaluarCombustible();
            }
        }

        private void actualizarLabels()
        {
            string defaultText = "--";
            bool hayVehiculo = this.vehiculo != null;

            labelCombustible.Text = hayVehiculo
                ? this.vehiculo.CapacidadActualTanque.ToString()
                : defaultText;
            labelKms.Text = hayVehiculo
                ? this.vehiculo.KmRecorridos.ToString()
                : defaultText;
            labelBateria.Text = hayVehiculo && this.vehiculo is AutoHibrido
                ? (this.vehiculo as AutoHibrido).BateriaActual.ToString()
                : defaultText;
        }

        private void actualizarBotones()
        {
            bool hayVehiculo = this.vehiculo != null;

            btnCargarBateria.Enabled = hayVehiculo && this.vehiculo is AutoHibrido;
            btnCargarCombustible.Enabled = hayVehiculo;
            btnSimularViaje.Enabled = hayVehiculo;
        }

        private void actualizarInputs() 
        {
            inputCapacidadTanque.Text = "";
            inputConsumoBat.Text = "";
            inputConsumoBat.Text = "";
            inputConsumoKm.Text = "";
            inputModelo.Text = "";
            inputMarca.Text = "";
            inputKms.Text = "";

            inputKms.Enabled = this.vehiculo != null;
        }

        private bool validarCampos(bool validarBateria)
        {
            string feedback = "";

            if (!validarTexto(inputMarca))
                feedback += "\n\t- Marca";

            if (!validarTexto(inputModelo))
                feedback += "\n\t- Modelo";

            if (!validarNumero(inputCapacidadTanque))
                feedback += "\n\t- Capacidad del tanque";

            if (!validarNumero(inputConsumoKm))
                feedback += "\n\t- Consumo de combustible/km";

            if(validarBateria && !validarNumero(inputConsumoBat))
                feedback += "\n\t- Consumo de bateria/km";

            bool validos = String.IsNullOrEmpty(feedback);

            if(!validos)
                MessageBox.Show($"Por favor, revisa los siguientes campos:{feedback}", "Errores", MessageBoxButtons.OK);

            return validos;
        }

        private bool validarTexto(TextBox textBox) 
        {
            return textBox.Text.Length > 0;
        }

        private bool validarNumero(TextBox textBox) 
        {
            bool flag;
            try
            {
                flag = Convert.ToDouble(textBox.Text) > 0;
            } catch {
                flag = false;
            }

            return flag;
        }

        private void btnCargarBateria_Click(object sender, EventArgs e)
        {
            if(this.vehiculo != null && vehiculo is AutoHibrido)
            {
                (vehiculo as AutoHibrido).cargarBateria();
            }
            actualizarInfo();
        }

        private void btnCargarCombustible_Click(object sender, EventArgs e)
        {
            if(this.vehiculo != null)
            {
                this.vehiculo.CargarCombustible();
            }
            actualizarInfo();
        }

        private void btnSimularViaje_Click(object sender, EventArgs e)
        {
            bool kmsValido = validarNumero(inputKms);

            if (kmsValido)
            {
                int kilometrosPorRecorrer = Convert.ToInt32(inputKms.Text);

                string respuesta = this.vehiculo.SimularViaje(kilometrosPorRecorrer);

                MessageBox.Show(respuesta);
            }
            else MessageBox.Show("Ingresa un numero valido en los kilometros");
            actualizarInfo();
        }
    }
}
