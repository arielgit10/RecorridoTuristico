using System;

namespace RecorridoTuristico
{

	public class Arista<T>
	{
		private Vertice<T> destino;
		private int peso;
	
		public Arista(Vertice<T> destino, int peso){
				this.destino = destino;
				this.peso = peso;
		}
		
		public Vertice<T> getDestino() {
			return this.destino;
		}
		
		public int getPeso() {
			return this.peso;
		}
		
		public void setDestino(Vertice<T> destino) {
			this.destino= destino;
		}
		
		public void setPeso(int peso) {
			this.peso = peso;
		}
	
	}
}
