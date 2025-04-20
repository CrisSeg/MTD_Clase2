
using System;

namespace Clase_2
{
	public class Numero : Comparable
	{
		private int valor;
		
		public Numero(int valor)
		{
			this.valor = valor;
		}
		
		public int getValor()
		{ return this.valor; }
		
		public bool sosIgual(Comparable c){
			return this.valor == ((Numero)c).valor;
		}
		public bool sosMenor(Comparable c){
			return this.valor < ((Numero)c).valor;
		}
		public bool sosMayor(Comparable c){
			return this.valor > ((Numero)c).valor;
		}
		
		public string toString(){
			return this.valor.ToString();
		}
	}
}
