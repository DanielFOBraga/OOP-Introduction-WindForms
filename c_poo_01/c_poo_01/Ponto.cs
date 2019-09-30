using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_poo_01
{
    class Ponto
    {
        private double x;

        public double X
        {
            get { return x; }
            set { x = value; }
        }
        private double y;

        public double Y
        {
            get { return y; }
            set { y = value; }
        }
        private bool _igualdade { get; set; }

        public Ponto() : this(0, 0) { }

        public Ponto(double _x, double _y)
        {
            x = _x;
            y = _y;
        }
        //redefinição do comportamento do operador + para somar pontos cartesianos
        public static Ponto operator +(Ponto p1, Ponto p2)
        {
            Ponto p = new Ponto();
            p.x = p1.x + p2.x;
            p.y = p1.y + p2.y;
            return p;
        }
        public static bool operator ==(Ponto p1, Ponto p2)
        {
            if (p1.X == p2.X && p1.Y == p2.Y)
                return true;

            else
                return false;
        }
        public static bool operator !=(Ponto p1, Ponto p2)
        {
            if (p1.X != p2.X || p1.Y != p2.Y)

                return true;
            else
                return false;

        }
    }
}
