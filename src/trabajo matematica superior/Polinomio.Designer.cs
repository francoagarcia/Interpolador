namespace WindowsFormsApplication1
{
    partial class Polinomio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.salir_button = new System.Windows.Forms.Button();
            this.volver_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.progresivo_textBox = new System.Windows.Forms.TextBox();
            this.regresivo_textBox = new System.Windows.Forms.TextBox();
            this.agregarPunto_button = new System.Windows.Forms.Button();
            this.boton_evaluacion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // salir_button
            // 
            this.salir_button.Location = new System.Drawing.Point(450, 347);
            this.salir_button.Name = "salir_button";
            this.salir_button.Size = new System.Drawing.Size(172, 53);
            this.salir_button.TabIndex = 8;
            this.salir_button.Text = "Salir";
            this.salir_button.UseVisualStyleBackColor = true;
            this.salir_button.Click += new System.EventHandler(this.salir_button_Click);
            // 
            // volver_button
            // 
            this.volver_button.Location = new System.Drawing.Point(12, 347);
            this.volver_button.Name = "volver_button";
            this.volver_button.Size = new System.Drawing.Size(172, 53);
            this.volver_button.TabIndex = 9;
            this.volver_button.Text = "Volver al menu principal";
            this.volver_button.UseVisualStyleBackColor = true;
            this.volver_button.Click += new System.EventHandler(this.volver_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Progresivo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Regresivo:";
            // 
            // progresivo_textBox
            // 
            this.progresivo_textBox.Location = new System.Drawing.Point(78, 102);
            this.progresivo_textBox.Name = "progresivo_textBox";
            this.progresivo_textBox.ReadOnly = true;
            this.progresivo_textBox.Size = new System.Drawing.Size(544, 20);
            this.progresivo_textBox.TabIndex = 12;
            // 
            // regresivo_textBox
            // 
            this.regresivo_textBox.Location = new System.Drawing.Point(78, 180);
            this.regresivo_textBox.Name = "regresivo_textBox";
            this.regresivo_textBox.ReadOnly = true;
            this.regresivo_textBox.Size = new System.Drawing.Size(544, 20);
            this.regresivo_textBox.TabIndex = 13;
            // 
            // agregarPunto_button
            // 
            this.agregarPunto_button.Location = new System.Drawing.Point(231, 243);
            this.agregarPunto_button.Name = "agregarPunto_button";
            this.agregarPunto_button.Size = new System.Drawing.Size(172, 53);
            this.agregarPunto_button.TabIndex = 14;
            this.agregarPunto_button.Text = "Agregar/Quitar punto";
            this.agregarPunto_button.UseVisualStyleBackColor = true;
            this.agregarPunto_button.Click += new System.EventHandler(this.agregar_punto_Click);
            // 
            // boton_evaluacion
            // 
            this.boton_evaluacion.Location = new System.Drawing.Point(231, 347);
            this.boton_evaluacion.Name = "boton_evaluacion";
            this.boton_evaluacion.Size = new System.Drawing.Size(172, 53);
            this.boton_evaluacion.TabIndex = 15;
            this.boton_evaluacion.Text = "Evaluar Polinomio";
            this.boton_evaluacion.UseVisualStyleBackColor = true;
            this.boton_evaluacion.Click += new System.EventHandler(this.boton_evaluacion_Click);
            // 
            // Polinomio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 412);
            this.Controls.Add(this.boton_evaluacion);
            this.Controls.Add(this.agregarPunto_button);
            this.Controls.Add(this.regresivo_textBox);
            this.Controls.Add(this.progresivo_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.volver_button);
            this.Controls.Add(this.salir_button);
            this.Name = "Polinomio";
            this.Text = "Polinomio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button salir_button;
        private System.Windows.Forms.Button volver_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox progresivo_textBox;
        private System.Windows.Forms.TextBox regresivo_textBox;
        private System.Windows.Forms.Button agregarPunto_button;
        private System.Windows.Forms.Button boton_evaluacion;
    }
}