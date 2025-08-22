
namespace _3MLIDTS_YairGonzalez_03cs
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lbTituloTemps = new System.Windows.Forms.Label();
            this.lbCelsius = new System.Windows.Forms.Label();
            this.lbFahrenheint = new System.Windows.Forms.Label();
            this.lbKelvin = new System.Windows.Forms.Label();
            this.tbCelsius = new System.Windows.Forms.TextBox();
            this.tbFahrenheit = new System.Windows.Forms.TextBox();
            this.tbKevin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(67, 187);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 23);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.LightPink;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(188, 187);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 23);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lbTituloTemps
            // 
            this.lbTituloTemps.AutoSize = true;
            this.lbTituloTemps.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloTemps.Location = new System.Drawing.Point(89, 9);
            this.lbTituloTemps.Name = "lbTituloTemps";
            this.lbTituloTemps.Size = new System.Drawing.Size(157, 25);
            this.lbTituloTemps.TabIndex = 2;
            this.lbTituloTemps.Text = "Temperaturas";
            this.lbTituloTemps.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbCelsius
            // 
            this.lbCelsius.AutoSize = true;
            this.lbCelsius.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCelsius.Location = new System.Drawing.Point(64, 69);
            this.lbCelsius.Name = "lbCelsius";
            this.lbCelsius.Size = new System.Drawing.Size(55, 13);
            this.lbCelsius.TabIndex = 3;
            this.lbCelsius.Text = "Celsius :";
            this.lbCelsius.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbFahrenheint
            // 
            this.lbFahrenheint.AutoSize = true;
            this.lbFahrenheint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFahrenheint.Location = new System.Drawing.Point(64, 111);
            this.lbFahrenheint.Name = "lbFahrenheint";
            this.lbFahrenheint.Size = new System.Drawing.Size(75, 13);
            this.lbFahrenheint.TabIndex = 4;
            this.lbFahrenheint.Text = "Fahrenheit :";
            // 
            // lbKelvin
            // 
            this.lbKelvin.AutoSize = true;
            this.lbKelvin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKelvin.Location = new System.Drawing.Point(64, 146);
            this.lbKelvin.Name = "lbKelvin";
            this.lbKelvin.Size = new System.Drawing.Size(50, 13);
            this.lbKelvin.TabIndex = 5;
            this.lbKelvin.Text = "Kelvin :";
            // 
            // tbCelsius
            // 
            this.tbCelsius.Location = new System.Drawing.Point(146, 69);
            this.tbCelsius.Name = "tbCelsius";
            this.tbCelsius.Size = new System.Drawing.Size(100, 20);
            this.tbCelsius.TabIndex = 6;
            // 
            // tbFahrenheit
            // 
            this.tbFahrenheit.Location = new System.Drawing.Point(146, 104);
            this.tbFahrenheit.Name = "tbFahrenheit";
            this.tbFahrenheit.Size = new System.Drawing.Size(100, 20);
            this.tbFahrenheit.TabIndex = 7;
            // 
            // tbKevin
            // 
            this.tbKevin.Location = new System.Drawing.Point(146, 139);
            this.tbKevin.Name = "tbKevin";
            this.tbKevin.Size = new System.Drawing.Size(100, 20);
            this.tbKevin.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 261);
            this.Controls.Add(this.tbKevin);
            this.Controls.Add(this.tbFahrenheit);
            this.Controls.Add(this.tbCelsius);
            this.Controls.Add(this.lbKelvin);
            this.Controls.Add(this.lbFahrenheint);
            this.Controls.Add(this.lbCelsius);
            this.Controls.Add(this.lbTituloTemps);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Name = "Form1";
            this.Text = "Actividad 03 - Conversor de Temperaturas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lbTituloTemps;
        private System.Windows.Forms.Label lbCelsius;
        private System.Windows.Forms.Label lbFahrenheint;
        private System.Windows.Forms.Label lbKelvin;
        private System.Windows.Forms.TextBox tbCelsius;
        private System.Windows.Forms.TextBox tbFahrenheit;
        private System.Windows.Forms.TextBox tbKevin;
    }
}

