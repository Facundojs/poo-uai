namespace PARCIAL_19_5
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputMarca = new System.Windows.Forms.TextBox();
            this.inputModelo = new System.Windows.Forms.TextBox();
            this.inputConsumoKm = new System.Windows.Forms.TextBox();
            this.inputCapacidadTanque = new System.Windows.Forms.TextBox();
            this.inputKms = new System.Windows.Forms.TextBox();
            this.inputConsumoBat = new System.Windows.Forms.TextBox();
            this.btnCrearHibrido = new System.Windows.Forms.Button();
            this.btnSimularViaje = new System.Windows.Forms.Button();
            this.btnCrearAutoNafta = new System.Windows.Forms.Button();
            this.btnCargarCombustible = new System.Windows.Forms.Button();
            this.btnCargarBateria = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelKms = new System.Windows.Forms.Label();
            this.labelCombustible = new System.Windows.Forms.Label();
            this.labelBateria = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputMarca
            // 
            this.inputMarca.Location = new System.Drawing.Point(139, 82);
            this.inputMarca.Name = "inputMarca";
            this.inputMarca.Size = new System.Drawing.Size(100, 20);
            this.inputMarca.TabIndex = 0;
            // 
            // inputModelo
            // 
            this.inputModelo.Location = new System.Drawing.Point(139, 48);
            this.inputModelo.Name = "inputModelo";
            this.inputModelo.Size = new System.Drawing.Size(100, 20);
            this.inputModelo.TabIndex = 1;
            // 
            // inputConsumoKm
            // 
            this.inputConsumoKm.Location = new System.Drawing.Point(139, 157);
            this.inputConsumoKm.Name = "inputConsumoKm";
            this.inputConsumoKm.Size = new System.Drawing.Size(100, 20);
            this.inputConsumoKm.TabIndex = 2;
            // 
            // inputCapacidadTanque
            // 
            this.inputCapacidadTanque.Location = new System.Drawing.Point(139, 119);
            this.inputCapacidadTanque.Name = "inputCapacidadTanque";
            this.inputCapacidadTanque.Size = new System.Drawing.Size(100, 20);
            this.inputCapacidadTanque.TabIndex = 3;
            // 
            // inputKms
            // 
            this.inputKms.Location = new System.Drawing.Point(389, 78);
            this.inputKms.Name = "inputKms";
            this.inputKms.Size = new System.Drawing.Size(113, 20);
            this.inputKms.TabIndex = 4;
            // 
            // inputConsumoBat
            // 
            this.inputConsumoBat.Location = new System.Drawing.Point(139, 267);
            this.inputConsumoBat.Name = "inputConsumoBat";
            this.inputConsumoBat.Size = new System.Drawing.Size(100, 20);
            this.inputConsumoBat.TabIndex = 5;
            // 
            // btnCrearHibrido
            // 
            this.btnCrearHibrido.Location = new System.Drawing.Point(139, 303);
            this.btnCrearHibrido.Name = "btnCrearHibrido";
            this.btnCrearHibrido.Size = new System.Drawing.Size(100, 23);
            this.btnCrearHibrido.TabIndex = 6;
            this.btnCrearHibrido.Text = "Crear auto híbrido";
            this.btnCrearHibrido.UseVisualStyleBackColor = true;
            this.btnCrearHibrido.Click += new System.EventHandler(this.btnCrearHibrido_Click);
            // 
            // btnSimularViaje
            // 
            this.btnSimularViaje.Location = new System.Drawing.Point(389, 138);
            this.btnSimularViaje.Name = "btnSimularViaje";
            this.btnSimularViaje.Size = new System.Drawing.Size(113, 23);
            this.btnSimularViaje.TabIndex = 7;
            this.btnSimularViaje.Text = "Simular viaje";
            this.btnSimularViaje.UseVisualStyleBackColor = true;
            this.btnSimularViaje.Click += new System.EventHandler(this.btnSimularViaje_Click);
            // 
            // btnCrearAutoNafta
            // 
            this.btnCrearAutoNafta.Location = new System.Drawing.Point(139, 211);
            this.btnCrearAutoNafta.Name = "btnCrearAutoNafta";
            this.btnCrearAutoNafta.Size = new System.Drawing.Size(100, 23);
            this.btnCrearAutoNafta.TabIndex = 8;
            this.btnCrearAutoNafta.Text = "Crear auto a nafta";
            this.btnCrearAutoNafta.UseVisualStyleBackColor = true;
            this.btnCrearAutoNafta.Click += new System.EventHandler(this.btnCrearAutoNafta_Click);
            // 
            // btnCargarCombustible
            // 
            this.btnCargarCombustible.Location = new System.Drawing.Point(389, 181);
            this.btnCargarCombustible.Name = "btnCargarCombustible";
            this.btnCargarCombustible.Size = new System.Drawing.Size(113, 23);
            this.btnCargarCombustible.TabIndex = 9;
            this.btnCargarCombustible.Text = "Cargar combustible";
            this.btnCargarCombustible.UseVisualStyleBackColor = true;
            this.btnCargarCombustible.Click += new System.EventHandler(this.btnCargarCombustible_Click);
            // 
            // btnCargarBateria
            // 
            this.btnCargarBateria.Location = new System.Drawing.Point(389, 231);
            this.btnCargarBateria.Name = "btnCargarBateria";
            this.btnCargarBateria.Size = new System.Drawing.Size(113, 23);
            this.btnCargarBateria.TabIndex = 10;
            this.btnCargarBateria.Text = "Cargar batería";
            this.btnCargarBateria.UseVisualStyleBackColor = true;
            this.btnCargarBateria.Click += new System.EventHandler(this.btnCargarBateria_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Modelo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Marca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Capacidad de tanque";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Consumo KM/Litro";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Consumo Bateria/KM";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Simulador de vehículos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(386, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Funciones";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(386, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "KM a recorrer";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(340, 339);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "KM Recorridos";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(340, 293);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Combustible actual";
            // 
            // labelKms
            // 
            this.labelKms.AutoSize = true;
            this.labelKms.Location = new System.Drawing.Point(480, 339);
            this.labelKms.Name = "labelKms";
            this.labelKms.Size = new System.Drawing.Size(13, 13);
            this.labelKms.TabIndex = 22;
            this.labelKms.Text = "--";
            // 
            // labelCombustible
            // 
            this.labelCombustible.AutoSize = true;
            this.labelCombustible.Location = new System.Drawing.Point(480, 293);
            this.labelCombustible.Name = "labelCombustible";
            this.labelCombustible.Size = new System.Drawing.Size(13, 13);
            this.labelCombustible.TabIndex = 21;
            this.labelCombustible.Text = "--";
            // 
            // labelBateria
            // 
            this.labelBateria.AutoSize = true;
            this.labelBateria.Location = new System.Drawing.Point(480, 313);
            this.labelBateria.Name = "labelBateria";
            this.labelBateria.Size = new System.Drawing.Size(13, 13);
            this.labelBateria.TabIndex = 24;
            this.labelBateria.Text = "--";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(340, 313);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "Bateria actual";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelBateria);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.labelKms);
            this.Controls.Add(this.labelCombustible);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCargarBateria);
            this.Controls.Add(this.btnCargarCombustible);
            this.Controls.Add(this.btnCrearAutoNafta);
            this.Controls.Add(this.btnSimularViaje);
            this.Controls.Add(this.btnCrearHibrido);
            this.Controls.Add(this.inputConsumoBat);
            this.Controls.Add(this.inputKms);
            this.Controls.Add(this.inputCapacidadTanque);
            this.Controls.Add(this.inputConsumoKm);
            this.Controls.Add(this.inputModelo);
            this.Controls.Add(this.inputMarca);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputMarca;
        private System.Windows.Forms.TextBox inputModelo;
        private System.Windows.Forms.TextBox inputConsumoKm;
        private System.Windows.Forms.TextBox inputCapacidadTanque;
        private System.Windows.Forms.TextBox inputKms;
        private System.Windows.Forms.TextBox inputConsumoBat;
        private System.Windows.Forms.Button btnCrearHibrido;
        private System.Windows.Forms.Button btnSimularViaje;
        private System.Windows.Forms.Button btnCrearAutoNafta;
        private System.Windows.Forms.Button btnCargarCombustible;
        private System.Windows.Forms.Button btnCargarBateria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelKms;
        private System.Windows.Forms.Label labelCombustible;
        private System.Windows.Forms.Label labelBateria;
        private System.Windows.Forms.Label label13;
    }
}

