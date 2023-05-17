using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class C_Triangulo
    {
        //Attributes
        private int a_X1;
        private int a_Y1;
        private int a_X2;
        private int a_Y2;
        private int a_X3;
        private int a_Y3;

        private C_Punto a_Punto1;
        private C_Punto a_Punto2;
        private C_Punto a_Punto3;

        // Constructores

        public C_Triangulo()
        {
            a_Punto1 = new C_Punto(0, 0);
            a_Punto2 = new C_Punto(0, 3);
            a_Punto3 = new C_Punto(4, 0);
        }

        public C_Triangulo(C_Punto p_Punto1, C_Punto p_Punto2, C_Punto p_Punto3)
        {
            if (EsTriangulo(p_Punto1, p_Punto2, p_Punto3))
            {
                a_Punto1 = p_Punto1;
                a_Punto2 = p_Punto2;
                a_Punto3 = p_Punto3;
            }
            else
            {
                a_Punto1 = new C_Punto(0, 0);
                a_Punto2 = new C_Punto(0, 3);
                a_Punto3 = new C_Punto(4, 0);
            }
        }

        public C_Triangulo(int p_X1, int p_Y1, int p_X2, int p_Y2, int p_X3, int p_Y3)
        {
            if (EsTriangulo(new C_Punto(p_X1, p_Y1), new C_Punto(p_X2, p_Y2), new C_Punto(p_X3, p_Y3)))
            {
                a_X1 = p_X1;
                a_Y1 = p_Y1;
                a_X2 = p_X2;
                a_Y2 = p_Y2;
                a_X3 = p_X3;
                a_Y3 = p_Y3;
            }
            else
            {
                a_Punto1 = new C_Punto(p_X1, p_Y1);
                a_Punto2 = new C_Punto(p_X2, p_Y2);
                a_Punto3 = new C_Punto(p_X3, p_Y3);
            }

        }

        //Properties

        public C_Punto Punto1
        {
            get { return a_Punto1; }
            set { a_Punto1 = value; }
        }

        public C_Punto Punto2
        {
            get { return a_Punto2; }
            set { a_Punto2 = value; }
        }

        public C_Punto Punto3
        {
            get { return a_Punto3; }
            set { a_Punto3 = value; }
        }

        // Class Metods

        public static bool EsTriangulo(C_Punto p_P1, C_Punto p_P2, C_Punto p_P3)
        {
            if (
                p_P1.Distancia(p_P2) + p_P2.Distancia(p_P3) > p_P1.Distancia(p_P3) &&
                p_P2.Distancia(p_P3) + p_P3.Distancia(p_P1) > p_P2.Distancia(p_P1) &&
                p_P3.Distancia(p_P1) + p_P1.Distancia(p_P2) > p_P3.Distancia(p_P2))
            {
                return true;
            }
            return false;
        }
        public double Area()
        {
            double area = (((Punto1.X * Punto2.Y) + (Punto2.X * Punto3.Y) + (Punto3.X * Punto1.Y) - 
                            (Punto1.X * Punto3.Y) + (Punto3.X * Punto2.Y) + (Punto2.X * Punto1.Y))/ 2);
            return area;
        }
        public static double Area(C_Punto p_p1, C_Punto p_p2, C_Punto p_p3)
        {
            double area = (((p_p1.X * p_p2.Y) + (p_p2.X * p_p3.Y) + (p_p3.X * p_p1.Y) - (p_p1.X * p_p3.Y) + (p_p3.X * p_p2.Y) + (p_p2.X * p_p1.Y)) / 2);
            return area;
        }

        public static double Perimetro(C_Punto p_p1, C_Punto p_p2, C_Punto p_p3)
        {
            double perimetro = p_p1.Distancia(p_p2) + p_p2.Distancia(p_p3) + p_p3.Distancia(p_p1);
            return perimetro;
        }
    }
}
