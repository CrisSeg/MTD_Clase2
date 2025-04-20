using System;

namespace Clase_2
{
	public class ColeccionMultiple : Coleccionable, Iterable
	{
		private Pila p;
		private Cola c;
		
		public ColeccionMultiple(Pila p, Cola c){
			this.p = p;
			this.c = c;
		}
		
		public int cuantos(){
			return p.cuantos() + c.cuantos();
		}
		
		public Comparable minimo(){
			Comparable aux1 = p.minimo();
			Comparable aux2 = c.minimo();
			
			aux1 = aux1.sosMenor(aux2)? aux1: aux2;
			return aux1;
		}
		public Comparable maximo(){
			Comparable aux1 = p.minimo();
			Comparable aux2 = c.minimo();
			
			aux1 = aux1.sosMenor(aux2)? aux1 : aux2;
			return aux1;
		}
		public void agregar(Comparable c){}
		
		public bool contiene(Comparable com){
			return p.contiene(com) || c.contiene(com);
		}
		
		public Iterador crearIterador(){
			return p.crearIterador();
		}
		
	}
}
