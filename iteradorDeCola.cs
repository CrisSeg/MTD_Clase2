using System;

namespace Clase_2
{
	public class iteradorDeCola: Iterador
	{
		private Cola c;
		private int indice;
		
		public iteradorDeCola(Cola c)
		{
			this.c = c;
			this.primero();
		}
		
		//implemetamos la interface iterador
		public void primero(){
			this.indice = 0;
		}
		
		public void siguiente(){
			this.indice++;
		}
		
		public bool fin(){
			return this.indice >= c.cuantos();
		}
		
		public Comparable actual(){
			return this.c.getElementos(indice);
		}
	}
}
