using System;

namespace Clase_2
{
	public class IteradorDeConjunto : Iterador
	{
		private Conjunto con;
		private int indice;
		
		public IteradorDeConjunto(Conjunto con){
			this.con = con;
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
			return this.indice >= con.cuantos();
		}
		
		public Comparable actual(){
			return this.con.getElementos(indice);
		}
	}
}
