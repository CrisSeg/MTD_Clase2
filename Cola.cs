using System;
using System.Collections.Generic;

namespace Clase_2
{
	public class Cola : Coleccionable, Iterable
	{
		private List<Comparable> ele;
		public Cola()
		{
			this.ele = new List<Comparable>();
		}
		
		public void encolar(Comparable c){
			this.ele.Add(c);
		}
		
		public Comparable desEncolar(){
			Comparable aux = this.ele[0];
			this.ele.RemoveAt(0);
			return aux;
		}
		
		public Comparable getElementos(int i){
			return this.ele[i];
		}
		
		public int cuantos(){
			return this.ele.Count;
		}
		
		public Comparable minimo(){
			Comparable aux = this.ele[0];
			
			for (int i = 1; i < this.ele.Count; i++) {
				if (this.ele[i].sosMenor(aux)) {
					aux = this.ele[i];
				}
			}
			
			return aux;
		}
		
		public Comparable maximo(){
			Comparable aux = this.ele[0];
			
			for (int i = 1; i < this.ele.Count; i++) {
				if (this.ele[i].sosMayor(aux)) {
					aux = this.ele[i];
				}
			}
			
			return aux;
		}
		
		public void agregar(Comparable c){
			encolar(c);
		}
		
		public bool contiene(Comparable c){
			for (int i = 0; i < this.ele.Count; i++) {
				if (this.ele[i].sosIgual(c)) {
					return true;
				}
			}
			
			return false;
		}
		
		//Implementamos la interface iterable
		public Iterador crearIterador(){
			return new iteradorDeCola(this);
		}
	}
}
