using System;

namespace Clase_2
{
	//Ejercicio 1
	public interface EstrategiaDeComparacion
	{
		bool sosIgual(Alumno a1, Alumno a2);
		bool sosMenor(Alumno a1, Alumno a2);
 		bool sosMayor(Alumno a1, Alumno a2);
	}
}
