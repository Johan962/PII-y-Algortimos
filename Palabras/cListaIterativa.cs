using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palabras
{
    public class cListaIterativa
    {
        private cNodo? first;

        public cListaIterativa()
        {
            first = null;
        }

        public bool is_empty()
        {
            return first == null;
        }

        public int length()
        {
            int count = 0;

            cNodo? curr = first;
            for (; curr != null; curr = curr.Next)
                ++count;

            return count;
        }

        public bool append(object target)
        { // returns true if succesful

            first = new cNodo(target, first);

            return true;
        }

        public bool insert(object target, int pos)
        { // returns true if succesful, precondicion: pos < _length (pos es un indice)
            if (pos >= length())
                return false;

            cNodo? curr = first;

            int i = length() - 1 - pos;
            while (curr != null && i-- > 0)
            {
                curr = curr.Next;
            }

            curr.Next = new cNodo(target, curr.Next);

            return true;
        }

        public object? item(int pos) // 'iesimo'
        { // returns obj at index 'pos'
            cNodo? curr = first;

            int i = length() - 1 - pos;
            while (curr != null && i-- > 0)
                curr = curr.Next;

            return curr == null ? null : curr.Objeto;
        }

        public int? index(object target) // 'ubicacion'
        { // returns zero-based index of the "first" 'target' ocurrence
            cNodo? curr = first;

            int i = 0;
            int? idx = null;
            while (curr != null)
            {
                if (curr.Objeto.Equals(target))
                {
                    idx = i;
                }

                curr = curr.Next;
                ++i;
            }

            return length() - 1 - idx;
        }

        public void show()
        {
            show_recursivo(first);
            Console.Write("\n");
        }

        private void show_recursivo(cNodo? nodo)
        {
            if (nodo == null)
                return;

            show_recursivo(nodo.Next);
            Console.Write($"{nodo.Objeto}, ");
        }

    }
}
