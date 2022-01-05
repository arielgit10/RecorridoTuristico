using System;
using System.Collections.Generic;

namespace RecorridoTuristico
{
	public class ArbolGeneral<T>
	{
		
		private T dato;
		private List<ArbolGeneral<T>> hijos = new List<ArbolGeneral<T>>();

		public ArbolGeneral(T dato) {
			this.dato = dato;
		}
	
		public T getDatoRaiz() {
			return this.dato;
		}
	
		public List<ArbolGeneral<T>> getHijos() {
			return this.hijos;
		}
	
		public void agregarHijo(ArbolGeneral<T> hijo) {
			this.getHijos().Add(hijo);
		}
	
		public void eliminarHijo(ArbolGeneral<T> hijo) {
			this.getHijos().Remove(hijo);
		}
	
		public bool esHoja() {
			return this.getHijos().Count == 0;
		}
	
		public int altura() {
			return 0;
		}
	
		
		public int nivel(T dato) {
			return 0;
		}
		
		//m�todo recursivo que recibe y retorna una lista de �rboles 	
		public List<ArbolGeneral<T>> preorden(List<ArbolGeneral<T>> listaDescendientes){
			foreach(var hijo in this.hijos){   //se recorren los hijos del nodo
				listaDescendientes.Add(hijo);	//se a�ade el hijo a la lista
				hijo.preorden(listaDescendientes);  //llamada recursiva
			}	
			return listaDescendientes;			
		}
		
			
		public override string ToString()
		{
			return string.Format("Dato={0}", dato);
		}

	
	
	}
}