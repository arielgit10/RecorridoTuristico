using System;
using System.Collections.Generic;

namespace RecorridoTuristico
{

	public class Grafo<T>
	{
		public Grafo()
		{
		}
		
		private List<Vertice<T>> vertices = new List<Vertice<T>>();
	
		public void agregarVertice(Vertice<T> v) {
			v.setPosicion(vertices.Count + 1);
			this.vertices.Add(v);
		}

		public void eliminarVertice(Vertice<T> v) {
			this.vertices.Remove(v);
		}

		public void conectar(Vertice<T> origen, Vertice<T> destino, int peso) {
			origen.getAdyacentes().Add(new Arista<T>(destino,peso));
			destino.setGrado();
		}

		public void desConectar(Vertice<T> origen, Vertice<T> destino) {
			Arista<T> arista = origen.getAdyacentes().Find(a => a.getDestino().Equals(destino));
			origen.getAdyacentes().Remove(arista);
		}
	
		public List<Vertice<T>> getVertices() {
			return this.vertices;
		}

		public Vertice<T> vertice(int posicion) {
			return this.vertices[posicion];
		}
	
		
		public void DFS(Vertice<T> origen) {
			
			//creamos arreglo de visitados
			bool [] visitados = new bool[this.getVertices().Count];
			
			//llamamos a _DFS
			this._DFS(origen,visitados);
			
		}
		
		private void _DFS(Vertice<T> origen, bool[] visitados) {
			
			//marcamos origen como visitado
			visitados[origen.getPosicion() -1] = true;
				
			//procesamos origen
			Console.Write(origen.getDato().ToString() + " ");
			
			//llamamos recursivamente en adyacentes no visitados
			foreach(var adyacente in origen.getAdyacentes()){
				if(!visitados[adyacente.getDestino().getPosicion() - 1]){
					this._DFS(adyacente.getDestino(),visitados);
				}
			}
		}
		
		
		public void BFS(Vertice<T> origen) {
			Cola<Vertice<T>> c = new Cola<Vertice<T>>();
			Vertice<T> verticeAux;
			
			bool [] visitados = new bool[this.getVertices().Count];
			
			//encolamos origen
			c.encolar(origen);
			//marcamos origen como visitado
			visitados[origen.getPosicion() - 1] = true;
				
			//procesamos cola
			while(!c.esVacia()){
				//desencolamos
				verticeAux = c.desencolar();
				//procesamos dato desencolado
				Console.Write(verticeAux.getDato().ToString() + " ");
				//encolamos adyacente no visitados
				foreach(var adyacente in verticeAux.getAdyacentes()){
					if(!visitados[adyacente.getDestino().getPosicion() - 1]){
						c.encolar(adyacente.getDestino());
						//marcamos a los elementos encolados como visitados
						visitados[adyacente.getDestino().getPosicion() - 1] = true;
					}
						
				}
					
			}
				
		}
		
		
		public  List<Vertice<T>> DFS_Pila(Vertice<T> origen,List<Vertice<T>> lista) {
			
			//creamos arreglo de visitados
			bool [] visitados = new bool[this.getVertices().Count];
				
			//marcamos origen como visitado
			visitados[origen.getPosicion() -1] = true;
				
			//procesamos origen
			lista.Add(origen);
			//Console.Write(origen.getDato().ToString() + " ");
			
			//llamamos recursivamente en adyacentes no visitados
			foreach(var adyacente in origen.getAdyacentes()){
				if(!visitados[adyacente.getDestino().getPosicion() - 1]){
					this._DFS(adyacente.getDestino(),visitados);
					lista.Add(adyacente.getDestino());
				}
			}
			return lista;
		}
		
		
		
		
		
		
		
	}
}
