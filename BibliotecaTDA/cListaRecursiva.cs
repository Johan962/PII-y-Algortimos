using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace BibliotecaTDA
{
    public class cListaRecursiva
    {
        private cListaRecursiva? aSublista;
        private object? aObjeto;

        public cListaRecursiva()
        {
            aObjeto = null;
            aSublista = null;
        }

        public cListaRecursiva(cListaRecursiva pSublista, object pObjeto)
        {
            aObjeto = pObjeto;
            aSublista = pSublista;
        }

        public cListaRecursiva(object pObjeto) {
            aObjeto = pObjeto;
            aSublista = null;
        }
        //Properties

        public object? Objeto {
            get { return aObjeto; }
            set { aObjeto = value; }
        }

        public cListaRecursiva? SubLista {
            get { return aSublista;}
            set { aSublista = value; }
        }

        public bool EsVacia()
        {
            return aSublista==null && aObjeto==null;
        }

        public int Longitud(){
            if (aSublista==null){
                return 0;
            }
            else {
                return 1 + aSublista.Longitud();
            }
        }
        public virtual cListaRecursiva Agregar(object pObjeto)
        {
            if( aSublista == null){
                aObjeto = pObjeto;
                aSublista = new cListaRecursiva(); 
                return aSublista;
            }
            else{
                return aSublista.Agregar(pObjeto);
            }
        }

        public int Ubicacion(object pObjeto){
           
           if ( aObjeto.Equals(pObjeto)){
                return 0;
            }
            else {
                return 1 + aSublista.Ubicacion(pObjeto);
            }
        }

        public object? Iesimo( int pos){
            
            if (pos == 0) {
                return aObjeto;
            }
            else {
                return aSublista.Iesimo(--pos);
            }
        }

        public void Eliminar(int pos) {
            if ( pos > Longitud()){
                return;
            }
            if (pos == 0){

                aSublista = aSublista.SubLista;
            }
            else {
                aSublista.Eliminar(--pos);
            }
        }
        public void Listar(){
            if (aSublista == null){
                return;
            }
            else {
                Console.WriteLine($"- {aObjeto}");
                aSublista.Listar();
            }
        }
    }
}