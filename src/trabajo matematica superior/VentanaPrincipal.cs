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
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void ingreso_puntos_Click(object sender, EventArgs e)
        {
            ingreso_puntos formIngreso = new ingreso_puntos(this);
            formIngreso.Show();
            this.Hide();
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
