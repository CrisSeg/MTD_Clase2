using System;

namespace Clase_2
{
	public class ComparacionPorPromedio: EstrategiaDeComparacion
	{
		public bool sosIgual(Alumno a1, Alumno a2){
			return a1.getPromedio() == a2.getPromedio();
		}
		
		public bool sosMenor(Alumno a1, Alumno a2){
			return a1.getPromedio() < a2.getPromedio();
		}
		public bool sosMayor(Alumno a1, Alumno a2){
			return a1.getPromedio() > a2.getPromedio();
		}
	}
}
