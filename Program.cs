using System;
using System.Collections.Generic;

namespace Clase_2
{
	class Program
	{
		public static void Main(string[] args)
		{
			/*Pila pila = new Pila();
			Cola cola = new Cola();
			Conjunto conjunto= new Conjunto();
			
			llenarAlumno(pila);
			llenarAlumno(cola);
			llenarAlumno(conjunto);
			
			Console.WriteLine("Elementos de la pila: ");
			imprimirElementos(pila);
			Console.WriteLine("Elementos de la cola: ");
			imprimirElementos(cola);
			Console.WriteLine("Elementos del Conjunto: ");
			imprimirElementos(conjunto);*/
			
			Console.WriteLine("Coleccion Pila: ");
			Pila pila = new Pila();
			llenarAlumno(pila);
			ComparacionPorNombre nom = new ComparacionPorNombre();
			cambiarEstrategia(pila, nom);
			Console.WriteLine("Comparacion por nombre: ");
			informar(pila);
			
			ComparacionPorLegajo le = new ComparacionPorLegajo();
			cambiarEstrategia(pila, le);
			Console.WriteLine("Comparacion por legajo: ");
			informar(pila);
			
			ComparacionPorPromedio pro = new ComparacionPorPromedio();
			cambiarEstrategia(pila, pro);
			Console.WriteLine("Comparacion por promedio: ");
			informar(pila);
			
			ComparacionPorDni dni = new ComparacionPorDni();
			cambiarEstrategia(pila, dni);
			Console.WriteLine("Comparacion por dni: ");
			informar(pila);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
			public static void llenar(Coleccionable c){
			Random rn = new Random();
			
			for (int i = 0; i < 20; i++) {
				Comparable com = new Numero(rn.Next());
				c.agregar(com);
			}
		}
		
		public static void informar(Coleccionable col){
			Console.WriteLine("La cantidad total de elementos del coleccionable es: {0}", col.cuantos());
			Console.WriteLine("El minimo elemento del coleccionable es: {0}", ((Alumno)col.minimo()).toString());
			Console.WriteLine("El maximo elemento del coleccionable es: {0}", ((Alumno)col.maximo()).toString());
			
			Console.WriteLine("Escriba el numero que desea buscar: ");
			//Comparable com = new Alumno("",int.Parse(Console.ReadLine()), 0, 0);
			/*Comparable com = new Alumno("", 0, int.Parse(Console.ReadLine()), 0);
			if (col.contiene(com)) {
				Console.WriteLine("El elemento leido esta en la coleccion");
			}
			else
				Console.WriteLine("El elemento leido no esta en la coleccion");*/
		}
		
		//Ejercicio 2
		public static void llenarAlumno(Coleccionable col){
			List<string> nom = new List<string>{"Cristian", "Gabriel", "Juan", "Marisa", "Lujan", "Alfredo", "Florencia"};
			
			Random n = new Random();
			Random d = new Random();
			Random l = new Random();
			Random p = new Random();
			
			for (int i = 0; i < 20; i++) {
				Comparable c = new Alumno(nom[n.Next(0,7)], d.Next(4000000,4500000), l.Next(0,1000), p.Next(0,11));
				EstrategiaDeComparacion dni = new ComparacionPorDni();
				((Alumno)c).setNvaEstrategia(dni);
				col.agregar(c);
			}
		}
		
		//Clase 2 Ejercicio 6
		public static void imprimirElementos(Coleccionable col){
			Iterador ite = col.crearIterador();
			
			ite.primero();
			while (!ite.fin()) {
				Console.WriteLine(ite.actual().toString());
				ite.siguiente();
			}
		}
		
		//Clase 2 Ejercicio 8
		public static void cambiarEstrategia(Coleccionable col, EstrategiaDeComparacion est){
			Iterador ite = col.crearIterador();
			
			ite.primero();
			while (!ite.fin()) {
				((Alumno)ite.actual()).setNvaEstrategia(est);
				ite.siguiente();
			}
		}
	}
}