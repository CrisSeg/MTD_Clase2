using System;

namespace Clase_2
{
	public class iteradorDePila: Iterador
	{
		private Pila p;
		private int indice;
		
		public iteradorDePila(Pila p){
			this.p = p;
			this.primero();
		}
		
		//Implementamos la interface iterador
		
		public void primero(){
			this.indice = 0;
		}
		public void siguiente(){
			this.indice++;
		}
		
		public bool fin(){
			return this.indice >= p.cuantos();
		}
		public Comparable actual(){
			return this.p.getElementos(indice);
		}
	}
}
