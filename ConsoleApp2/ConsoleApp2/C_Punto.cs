namespace ConsoleApp2
{
    internal class C_Punto
    {
        //Attributes
        private int a_X;
        private int a_Y;

        //Contructors

        public C_Punto(int p_X, int p_Y)
        {
            a_X = p_X;
            a_Y = p_Y;
        }

        //Properties

        public int X
        {
            get { return a_X; }
            set { a_X = value; }
        }

        public int Y
        {
            get { return a_Y; }
            set { a_Y = value; }
        }

        // Instance Metod

        public double Distancia(C_Punto Punto2)
        {
            double Result = Math.Pow(Math.Pow(this.X - Punto2.X, 2) + Math.Pow(this.Y - Punto2.Y, 2), 0.5);
            return Result;
        }

        //public C_Punto SumaPuntos(C_Punto p_Punto2)
        //{
        //    C_Punto Result = new C_Punto(this.X + p_Punto2.X, this.Y + p_Punto2.Y);
        //    return Result;
        //}
    }
}
