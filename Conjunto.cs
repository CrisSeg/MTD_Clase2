using System;
using System.Collections.Generic;

namespace Clase_2
{
	//Ejercicio 3
	public class Conjunto: Coleccionable, Iterable
	{
		private List<Comparable> conjunto;
		
		public Conjunto(){
			this.conjunto = new List<Comparable>();
		}
		
		public Comparable getElementos(int i){
			return this.conjunto[i];
		}
		
		//Ejercicio 3
		public void agregar(Comparable c){
			for (int i = 0; i < conjunto.Count; i++) {
				if (!conjunto[i].sosIgual(c)) {
					conjunto.Add(c);
				}
			}
		}
		
		public bool pertenece(Comparable c){
			for (int i = 0; i < conjunto.Count; i++) {
				if (conjunto[i].sosIgual(c)) {
					return true;
				}
			}
			return false;
		}
		
		//ejecicio 4
		public Comparable eliminar(){
			Comparable aux1 = this.conjunto[0];
			this.conjunto.RemoveAt(0);
			return aux1;
		}
		
		public int cuantos(){
			return this.conjunto.Count;
		}
		
		public Comparable minimo(){
			Comparable min = this.conjunto[0];
			
			for (int i = 1; i < conjunto.Count; i++) {
				if (this.conjunto[i].sosMenor(min)) {
					min = this.conjunto[i];
				}
			}
			
			return min;
		}
		
		public Comparable maximo(){
			Comparable max = this.conjunto[0];
			
			for (int i = 1; i < conjunto.Count; i++) {
				if (this.conjunto[i].sosMayor(max)) {
					max = this.conjunto[i];
				}
			}
			
			return max;
		}
		
		public bool contiene(Comparable c){
			for (int i = 0; i < conjunto.Count; i++) {
				if (this.conjunto[i].sosIgual(c)) {
					return true;
				}
			}
			return false;
		}
		
		//Implementamos la interface iterable
		public Iterador crearIterador(){
			return new IteradorDeConjunto(this);
		}
	}
}
