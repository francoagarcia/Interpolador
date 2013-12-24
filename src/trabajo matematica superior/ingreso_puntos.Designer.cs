namespace WindowsFormsApplication1
{
    public partial class ingreso_puntos
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
            this.volverMenuPrincipal_button = new System.Windows.Forms.Button();
            this.calcularPolinomio_button = new System.Windows.Forms.Button();
            this.posY_label = new System.Windows.Forms.Label();
            this.posY_textBox = new System.Windows.Forms.TextBox();
            this.posX_label = new System.Windows.Forms.Label();
            this.posX_textBox = new System.Windows.Forms.TextBox();
            this.ingresarPunto_button = new System.Windows.Forms.Button();
            this.cantPuntos_label = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.sacar_punto = new System.Windows.Forms.Button();
            this.viewTable_button = new System.Windows.Forms.Button();
            this.h_label = new System.Windows.Forms.Label();
            this.h_valor_label = new System.Windows.Forms.Label();
            this.label_cambio_pol = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // salir_button
            // 
            this.salir_button.Location = new System.Drawing.Point(450, 347);
            this.salir_button.Name = "salir_button";
            this.salir_button.Size = new System.Drawing.Size(172, 53);
            this.salir_button.TabIndex = 7;
            this.salir_button.Text = "Salir";
            this.salir_button.UseVisualStyleBackColor = true;
            this.salir_button.Click += new System.EventHandler(this.salir_button_Click);
            // 
            // volverMenuPrincipal_button
            // 
            this.volverMenuPrincipal_button.Location = new System.Drawing.Point(12, 347);
            this.volverMenuPrincipal_button.Name = "volverMenuPrincipal_button";
            this.volverMenuPrincipal_button.Size = new System.Drawing.Size(172, 53);
            this.volverMenuPrincipal_button.TabIndex = 8;
            this.volverMenuPrincipal_button.Text = "Volver al menú principal";
            this.volverMenuPrincipal_button.UseVisualStyleBackColor = true;
            this.volverMenuPrincipal_button.Click += new System.EventHandler(this.volverMenuPrincipal_button_Click);
            // 
            // calcularPolinomio_button
            // 
            this.calcularPolinomio_button.Location = new System.Drawing.Point(231, 347);
            this.calcularPolinomio_button.Name = "calcularPolinomio_button";
            this.calcularPolinomio_button.Size = new System.Drawing.Size(172, 53);
            this.calcularPolinomio_button.TabIndex = 9;
            this.calcularPolinomio_button.Text = "Calcular polinomio";
            this.calcularPolinomio_button.UseVisualStyleBackColor = true;
            this.calcularPolinomio_button.Click += new System.EventHandler(this.calcular_equi_Click);
            // 
            // posY_label
            // 
            this.posY_label.AutoSize = true;
            this.posY_label.Location = new System.Drawing.Point(228, 124);
            this.posY_label.Name = "posY_label";
            this.posY_label.Size = new System.Drawing.Size(70, 13);
            this.posY_label.TabIndex = 10;
            this.posY_label.Text = "Posicion en y";
            // 
            // posY_textBox
            // 
            this.posY_textBox.Location = new System.Drawing.Point(332, 121);
            this.posY_textBox.Name = "posY_textBox";
            this.posY_textBox.Size = new System.Drawing.Size(71, 20);
            this.posY_textBox.TabIndex = 11;
            // 
            // posX_label
            // 
            this.posX_label.AutoSize = true;
            this.posX_label.Location = new System.Drawing.Point(228, 77);
            this.posX_label.Name = "posX_label";
            this.posX_label.Size = new System.Drawing.Size(70, 13);
            this.posX_label.TabIndex = 12;
            this.posX_label.Text = "Posicion en x";
            // 
            // posX_textBox
            // 
            this.posX_textBox.Location = new System.Drawing.Point(332, 77);
            this.posX_textBox.Name = "posX_textBox";
            this.posX_textBox.Size = new System.Drawing.Size(71, 20);
            this.posX_textBox.TabIndex = 13;
            // 
            // ingresarPunto_button
            // 
            this.ingresarPunto_button.Location = new System.Drawing.Point(12, 211);
            this.ingresarPunto_button.Name = "ingresarPunto_button";
            this.ingresarPunto_button.Size = new System.Drawing.Size(172, 53);
            this.ingresarPunto_button.TabIndex = 14;
            this.ingresarPunto_button.Text = "Ingresar punto";
            this.ingresarPunto_button.UseVisualStyleBackColor = true;
            this.ingresarPunto_button.Click += new System.EventHandler(this.ingresarPunto_button_Click);
            // 
            // cantPuntos_label
            // 
            this.cantPuntos_label.AutoSize = true;
            this.cantPuntos_label.Location = new System.Drawing.Point(573, 22);
            this.cantPuntos_label.Name = "cantPuntos_label";
            this.cantPuntos_label.Size = new System.Drawing.Size(99, 13);
            this.cantPuntos_label.TabIndex = 18;
            this.cantPuntos_label.Text = "Cantidad de puntos";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(465, 22);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(102, 13);
            this.label.TabIndex = 17;
            this.label.Text = "Cantidad de puntos:";
            // 
            // sacar_punto
            // 
            this.sacar_punto.Location = new System.Drawing.Point(231, 211);
            this.sacar_punto.Name = "sacar_punto";
            this.sacar_punto.Size = new System.Drawing.Size(172, 53);
            this.sacar_punto.TabIndex = 19;
            this.sacar_punto.Text = "Quitar punto";
            this.sacar_punto.UseVisualStyleBackColor = true;
            this.sacar_punto.Click += new System.EventHandler(this.sacar_punto_Click);
            // 
            // viewTable_button
            // 
            this.viewTable_button.Location = new System.Drawing.Point(450, 211);
            this.viewTable_button.Name = "viewTable_button";
            this.viewTable_button.Size = new System.Drawing.Size(172, 53);
            this.viewTable_button.TabIndex = 20;
            this.viewTable_button.Text = "Ver tabla";
            this.viewTable_button.UseVisualStyleBackColor = true;
            this.viewTable_button.Click += new System.EventHandler(this.viewTable_button_Click);
            // 
            // h_label
            // 
            this.h_label.AutoSize = true;
            this.h_label.Location = new System.Drawing.Point(232, 162);
            this.h_label.Name = "h_label";
            this.h_label.Size = new System.Drawing.Size(66, 13);
            this.h_label.TabIndex = 21;
            this.h_label.Text = "Distancia (h)";
            // 
            // h_valor_label
            // 
            this.h_valor_label.AutoSize = true;
            this.h_valor_label.Location = new System.Drawing.Point(329, 162);
            this.h_valor_label.Name = "h_valor_label";
            this.h_valor_label.Size = new System.Drawing.Size(31, 13);
            this.h_valor_label.TabIndex = 22;
            this.h_valor_label.Text = "Valor";
            // 
            // label_cambio_pol
            // 
            this.label_cambio_pol.AutoSize = true;
            this.label_cambio_pol.Location = new System.Drawing.Point(447, 162);
            this.label_cambio_pol.Name = "label_cambio_pol";
            this.label_cambio_pol.Size = new System.Drawing.Size(60, 13);
            this.label_cambio_pol.TabIndex = 23;
            this.label_cambio_pol.Text = "Cambiara!!!";
            this.label_cambio_pol.Visible = false;
            // 
            // ingreso_puntos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 412);
            this.Controls.Add(this.label_cambio_pol);
            this.Controls.Add(this.h_valor_label);
            this.Controls.Add(this.h_label);
            this.Controls.Add(this.viewTable_button);
            this.Controls.Add(this.sacar_punto);
            this.Controls.Add(this.cantPuntos_label);
            this.Controls.Add(this.label);
            this.Controls.Add(this.ingresarPunto_button);
            this.Controls.Add(this.posX_textBox);
            this.Controls.Add(this.posX_label);
            this.Controls.Add(this.posY_textBox);
            this.Controls.Add(this.posY_label);
            this.Controls.Add(this.calcularPolinomio_button);
            this.Controls.Add(this.volverMenuPrincipal_button);
            this.Controls.Add(this.salir_button);
            this.Name = "ingreso_puntos";
            this.Text = "Ingresar puntos equiespaciados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button salir_button;
        private System.Windows.Forms.Button volverMenuPrincipal_button;
        private System.Windows.Forms.Button calcularPolinomio_button;
        private System.Windows.Forms.Label posY_label;
        private System.Windows.Forms.Label posX_label;
        private System.Windows.Forms.TextBox posX_textBox;
        private System.Windows.Forms.TextBox posY_textBox;
        private System.Windows.Forms.Button ingresarPunto_button;
        private System.Windows.Forms.Label cantPuntos_label;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button sacar_punto;
        private System.Windows.Forms.Button viewTable_button;
        private System.Windows.Forms.Label h_label;
        private System.Windows.Forms.Label h_valor_label;
        private System.Windows.Forms.Label label_cambio_pol;
    }
}