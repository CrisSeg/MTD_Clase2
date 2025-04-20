using System;
using System.Collections.Generic;

namespace Clase_2
{
	public class Pila : Coleccionable, Iterable
	{
		List<Comparable> p;
		public Pila()
		{
			this.p = new List<Comparable>();
		}
		
		public void apilar(Comparable c){
			this.p.Add(c);
		}
		
		public Comparable desApilar(){
			Comparable aux = this.p[p.Count-1];
			p.RemoveAt(p.Count-1);
			return aux;
		}
		
		public Comparable getElementos(int i){
			return this.p[i];
		}
		
		public int cuantos(){
			return this.p.Count;
		}
		public Comparable minimo(){
			Comparable min = this.p[0];
			
			for (int i = 1; i < p.Count; i++) {
				if (this.p[i].sosMenor(min)) {
					min = this.p[i];
				}
			}
			
			return min;
		}
		public Comparable maximo(){
			Comparable max = this.p[0];
			
			for (int i = 1; i < p.Count; i++) {
				if (this.p[i].sosMayor(max)) {
					max = this.p[i];
				}
			}
			
			return max;
		}
		public void agregar(Comparable c){
			apilar(c);
		}
		
		public bool contiene(Comparable c){
			for (int i = 0; i < p.Count; i++) {
				if (this.p[i].sosIgual(c)) {
					return true;
				}
			}
			return false;
		}
		
		//Implementamos la interface iterable
		public Iterador crearIterador(){
			return new iteradorDePila(this);
		}
	}
}
