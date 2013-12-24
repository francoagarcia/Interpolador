using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Evaluacion_Polinomio : Form
    {
        private Pol prog;
        private Pol reg;
        private Tabla miTabla;
        private ingreso_puntos formIngresoPuntos;

        public Evaluacion_Polinomio(ingreso_puntos formIngreso, Tabla unaTabla, Pol progresivo, Pol regresivo)
        {
            InitializeComponent();
            this.miTabla = unaTabla; 
            this.formIngresoPuntos = formIngreso;
            this.prog = progresivo;
            this.reg = regresivo;
        }

        private void boton_regresivo_Click(object sender, EventArgs e)
        {
            float pos = float.Parse(posicion_textbox.Text);
            this.valor_textbox.Text = reg.evaluar_polinomio(pos).ToString();
        }
        private void boton_progresivo_Click(object sender, EventArgs e)
        {
            float pos = float.Parse(posicion_textbox.Text);
            this.valor_textbox.Text = prog.evaluar_polinomio(pos).ToString();
        }

        private void boton_progresivo_Click_1(object sender, EventArgs e)
        {
            float pos = float.Parse(posicion_textbox.Text);
            this.valor_textbox.Text = prog.evaluar_polinomio(pos).ToString();
        }

        private void salir_button_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void volver_button_Click(object sender, EventArgs e)
        {
            VentanaPrincipal formVentanaPrincipal = new VentanaPrincipal();
            formVentanaPrincipal.Show();
            this.Close();
        }

        private void agregarPunto_button_Click(object sender, EventArgs e)
        {
            this.formIngresoPuntos.set_table(this.miTabla);
            this.formIngresoPuntos.Show();
            this.Close();
        }

    }
}
