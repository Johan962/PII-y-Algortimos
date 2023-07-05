namespace BibliotecaTDA
{
    public class cNodo
    {
        //Attributes

        private object? aElemento;
        private cNodo? aNext;

        //Constructors

        public cNodo()
        {
            aElemento = null;
            aNext = null;
        }

        public cNodo(object pElemento, cNodo pNext)
        {
            aElemento = pElemento;
            aNext = pNext;
        }

        public cNodo(object pElemento)
        {
            aElemento = pElemento;
            aNext = null;
        }

        //Properties
        
        public object? Elemento
        {
            get { return aElemento; }
            set { aElemento = value; }
        }

        public cNodo? Next
        {
            get { return aNext; }
            set { aNext = value; }
        }

        //Metods

        public bool EsVacio()
        {
            if (aElemento == null && aNext == null)
            {
                return true;
            }
            return false;
        }
    }
}