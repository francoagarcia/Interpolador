namespace WindowsFormsApplication1
{
    partial class Evaluacion_Polinomio
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
            this.boton_progresivo = new System.Windows.Forms.Button();
            this.posicion_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.boton_regresivo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.valor_textbox = new System.Windows.Forms.TextBox();
            this.agregarPunto_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // salir_button
            // 
            this.salir_button.Location = new System.Drawing.Point(450, 347);
            this.salir_button.Name = "salir_button";
            this.salir_button.Size = new System.Drawing.Size(172, 53);
            this.salir_button.TabIndex = 9;
            this.salir_button.Text = "Salir";
            this.salir_button.UseVisualStyleBackColor = true;
            this.salir_button.Click += new System.EventHandler(this.salir_button_Click);
            // 
            // volver_button
            // 
            this.volver_button.Location = new System.Drawing.Point(12, 347);
            this.volver_button.Name = "volver_button";
            this.volver_button.Size = new System.Drawing.Size(172, 53);
            this.volver_button.TabIndex = 10;
            this.volver_button.Text = "Volver al menu principal";
            this.volver_button.UseVisualStyleBackColor = true;
            this.volver_button.Click += new System.EventHandler(this.volver_button_Click);
            // 
            // boton_progresivo
            // 
            this.boton_progresivo.Location = new System.Drawing.Point(155, 243);
            this.boton_progresivo.Name = "boton_progresivo";
            this.boton_progresivo.Size = new System.Drawing.Size(172, 53);
            this.boton_progresivo.TabIndex = 11;
            this.boton_progresivo.Text = "Evaluar Progresivo";
            this.boton_progresivo.UseVisualStyleBackColor = true;
            this.boton_progresivo.Click += new System.EventHandler(this.boton_progresivo_Click_1);
            // 
            // posicion_textbox
            // 
            this.posicion_textbox.Location = new System.Drawing.Point(170, 102);
            this.posicion_textbox.Name = "posicion_textbox";
            this.posicion_textbox.Size = new System.Drawing.Size(367, 20);
            this.posicion_textbox.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Posicion:";
            // 
            // boton_regresivo
            // 
            this.boton_regresivo.Location = new System.Drawing.Point(365, 243);
            this.boton_regresivo.Name = "boton_regresivo";
            this.boton_regresivo.Size = new System.Drawing.Size(172, 53);
            this.boton_regresivo.TabIndex = 15;
            this.boton_regresivo.Text = "Evaluar Regresivo";
            this.boton_regresivo.UseVisualStyleBackColor = true;
            this.boton_regresivo.Click += new System.EventHandler(this.boton_regresivo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Valor:";
            // 
            // valor_textbox
            // 
            this.valor_textbox.Location = new System.Drawing.Point(170, 145);
            this.valor_textbox.Name = "valor_textbox";
            this.valor_textbox.ReadOnly = true;
            this.valor_textbox.Size = new System.Drawing.Size(367, 20);
            this.valor_textbox.TabIndex = 17;
            // 
            // agregarPunto_button
            // 
            this.agregarPunto_button.Location = new System.Drawing.Point(236, 347);
            this.agregarPunto_button.Name = "agregarPunto_button";
            this.agregarPunto_button.Size = new System.Drawing.Size(172, 53);
            this.agregarPunto_button.TabIndex = 18;
            this.agregarPunto_button.Text = "Agregar/Quitar punto";
            this.agregarPunto_button.UseVisualStyleBackColor = true;
            this.agregarPunto_button.Click += new System.EventHandler(this.agregarPunto_button_Click);
            // 
            // Evaluacion_Polinomio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 412);
            this.Controls.Add(this.agregarPunto_button);
            this.Controls.Add(this.valor_textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.boton_regresivo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.posicion_textbox);
            this.Controls.Add(this.boton_progresivo);
            this.Controls.Add(this.volver_button);
            this.Controls.Add(this.salir_button);
            this.Name = "Evaluacion_Polinomio";
            this.Text = "Evaluacion_Polinomio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button salir_button;
        private System.Windows.Forms.Button volver_button;
        private System.Windows.Forms.Button boton_progresivo;
        private System.Windows.Forms.TextBox posicion_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button boton_regresivo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox valor_textbox;
        private System.Windows.Forms.Button agregarPunto_button;
    }
}