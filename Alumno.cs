using System;

namespace Clase_2
{
	public class Alumno : Persona, Comparable
	{
		private int legajo;
		private int promedio;
		private EstrategiaDeComparacion estrategia;
		
		public Alumno(string n, int d, int l, int p): base(n, d){
			this.nombre = n;
			this.dni = d;
			this.legajo = l;
			this.promedio = p;
			estrategia = new ComparacionPorLegajo();
		}
		
		public override string getNombre()
		{
			return this.nombre;
		}
		
		public override int getDni(){
			return this.dni;
		}
		
		public int getLegajo(){
			return this.legajo;
		}
		
		public int getPromedio(){
			return this.promedio;
		}
		
		public void setNvaEstrategia(EstrategiaDeComparacion nvaEstrategia){
			this.estrategia = nvaEstrategia;
		}
		
		public override bool sosIgual(Comparable c)
        {
			return this.estrategia.sosIgual(this, (Alumno)c);
        }

        public override bool sosMenor(Comparable c)
        {
            return this.estrategia.sosMenor(this, (Alumno)c);
        }

        public override bool sosMayor(Comparable c)
        {
            return this.estrategia.sosMayor(this, (Alumno)c);
        }
        
		public override string toString()
		{
			return base.toString() + string.Format(" Legajo: {0}, Promedio: {1}", legajo, promedio);
		}
	}
}
