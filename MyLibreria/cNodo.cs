namespace MyLibreria
{
    public class cNodo
    {
        //Attributes
        private object aPrimero;
        private cNodo aNodo;
        //Constructors

        public cNodo()
        {
            aPrimero = null;
            aNodo = new cNodo();
        }

        public cNodo(object pPrimero, cNodo pNodo)
        {
            aPrimero = pPrimero;
            aNodo = pNodo;
        }

        //Metods
        static public bool EsVacio(object pObjeto)
        {
            if (pObjeto == null )
            {
                return true;
            }
            return false;
        }
    }
}