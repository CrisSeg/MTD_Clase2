using System;

namespace Clase_2
{
	public class ComparacionPorNombre: EstrategiaDeComparacion
	{
		public bool sosIgual(Alumno a1, Alumno a2){
			return a1.getNombre() == a2.getNombre();
		}
		
		public bool sosMenor(Alumno a1, Alumno a2){
			return a1.getNombre() != a2.getNombre();
		}
 		
		public bool sosMayor(Alumno a1, Alumno a2){
			return a1.getNombre() != a2.getNombre();
		}
	}
}
