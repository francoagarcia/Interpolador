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
    public partial class ingreso_puntos : Form
    {
        Tabla unaTabla;
        VentanaPrincipal formVentanaPrincipal;
        Polinomio formPolinomio;
        public ingreso_puntos()
        {
            InitializeComponent();
            formPolinomio=new Polinomio(this);
            this.set_cantPuntos(0);
            this.unaTabla = new Tabla();
        }

        public ingreso_puntos(VentanaPrincipal formVentana)
        {
            InitializeComponent();
            formPolinomio = new Polinomio(this);
            this.h_label.Visible = false;
            this.h_valor_label.Visible = false;
            this.set_cantPuntos(0);
            this.unaTabla = new Tabla();
            this.formVentanaPrincipal = formVentana;
            
        }

        private void calcular_equi_Click(object sender, EventArgs e)
        {
            
            formPolinomio.nuevos_datos(unaTabla);
            formPolinomio.Show();
            this.Hide();
        }

        public void set_table(Tabla otraTabla) 
        {
            this.unaTabla = otraTabla;
        }

        private void set_cantPuntos(int cantidadDePuntos) 
        {
            this.cantPuntos_label.Text = cantidadDePuntos.ToString();
        }

        private void ingresarPunto_button_Click(object sender, EventArgs e)
        {
            float puntoX = float.Parse(posX_textBox.Text);
            float puntoY = float.Parse(posY_textBox.Text);
            this.h_label.Visible = false;
            this.h_valor_label.Visible = false;
            Punto unPunto = new Punto();
            unPunto.set_x(puntoX);
            unPunto.set_y(puntoY);
            unaTabla.agregar_punto(unPunto);
            this.set_cantPuntos(unaTabla.get_puntos().Count);
            this.posX_textBox.Text = "";
            this.posY_textBox.Text = "";
            unaTabla.ordenar();
            bool existe_h = this.unaTabla.existe_h();
            if (existe_h)
            {

                this.h_label.Visible = true;
                this.h_valor_label.Visible = true;
                this.h_valor_label.Text = this.unaTabla.posible_h().ToString();
            }
            if (formPolinomio.cambiara_para(unPunto))
            {
                label_cambio_pol.Visible = true;
            }
            else
            {
                label_cambio_pol.Visible = false;
            }
        }

        private void salir_button_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
        public void label_invisible()
        {
            label_cambio_pol.Visible = false;
        }

        private void sacar_punto_Click(object sender, EventArgs e)
        {
            unaTabla.sacar_punto(float.Parse(posX_textBox.Text));
            this.posX_textBox.Text = "";
            this.posY_textBox.Text = "";
            this.h_label.Visible = false;
            this.h_valor_label.Visible = false;
            bool existe_h = this.unaTabla.existe_h();
            if (existe_h)
            {
                this.h_label.Visible = true;
                this.h_valor_label.Visible = true;
                this.h_valor_label.Text = this.unaTabla.posible_h().ToString();
            }
            this.set_cantPuntos(this.unaTabla.get_puntos().Count);
        }

        private void volverMenuPrincipal_button_Click(object sender, EventArgs e)
        {
            this.formVentanaPrincipal.Show();
            this.Close();
        }

        private void viewTable_button_Click(object sender, EventArgs e)
        {
            ViewTable formViewTable = new ViewTable(this.unaTabla);
            formViewTable.Show();
        }

    }
}
