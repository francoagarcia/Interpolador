using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class Punto
    {
        private float x;
        private float y;

        public float get_x()
        {
            return x;
        }
        public float get_y()
        {
            return y;
        }
        public void set_x(float valor)
        {
            x = valor;
        }
        public void set_y(float valor)
        {
            y = valor;
        }
        public Punto quien_es_mayor_con(Punto otro_punto)
        {
            if (otro_punto.get_x() > this.get_x())
                return otro_punto;
            else
                return this;
        }
        public bool sos_mayor_a(Punto otro_punto)
        {
            return (otro_punto.get_x() < this.get_x());
        }
    }
}
