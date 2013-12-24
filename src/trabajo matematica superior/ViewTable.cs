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
    public partial class ViewTable : Form
    {
        Tabla miTabla;

        public ViewTable(Tabla unaTabla)
        {
            InitializeComponent();
            this.miTabla = unaTabla;
            foreach (Punto p in unaTabla.get_puntos()) 
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = p.get_x();
                dataGridView1.Rows[n].Cells[1].Value = p.get_y();
            }
        }


    }
}
