using System;
using System.Collections.Generic;

namespace RecorridoTuristico
{

	public class Vertice<T>
	{
		private List<Arista<T>> adyacentes; 
		private T dato;
		private int posicion,grado;
		private List<Hotel> hoteles;
		
		
		public Vertice()
		{
		}
		
	    public Vertice(T dato){
			this.dato = dato;
			this.adyacentes = new List<Arista<T>>();
			
		}
    
		public T getDato() {
			return this.dato;
		}

		public void setDato(T unDato) {
			this.dato = unDato;
		}

		
		public int getPosicion() {
			return this.posicion;
		}
	
		public List<Arista<T>> getAdyacentes(){
			return this.adyacentes;
		}
	
		public void setPosicion(int pos){
			this.posicion = pos; 
		}

		public List<Hotel> getHoteles(){
			return this.hoteles;
		}
		
		
		public void setGrado(){
			this.grado++;
		}
		
		public override string ToString()
		{
			return string.Format("[Vertice Dato={0}, Posicion={1}]", this.dato, this.posicion);
		}

	}
}
