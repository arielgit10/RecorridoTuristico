
using System;
using System.Collections.Generic;


namespace RecorridoTuristico
{

	public class RecorridoTuristico<T>
	{
		public RecorridoTuristico()
		{
		}
		

		public void DFS(List<Vertice<T>> camino,Vertice<T> origen) {
			//creamos arreglo de visitados
			bool [] visitados = new bool[camino.Count];
			
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
		
			
	public List<List<Vertice<T>>> todosLosCaminosConDFS(Grafo<T> grafo,Vertice<T> origen, Vertice<T> destino){
			//Lista de Vertices (camino)
			List<Vertice<T>> camino = new List<Vertice<T>>();
			//resultados es una lista de lista de vertices, ya que almacena caminos
			List<List<Vertice<T>>> resultado = new List<List<Vertice<T>>>();
			
			//arreglo de boleanos
			bool[] visitados = new bool[grafo.getVertices().Count];
			
			//llamada al método privado
			__todosLosCaminosConDFS(grafo,origen,destino,camino,resultado,visitados);
			
			return resultado;	
		}
		
		//método privado
		private void __todosLosCaminosConDFS(Grafo<T> grafo, Vertice<T> origen, Vertice<T> destino, List<Vertice<T>> camino, List<List<Vertice<T>>> resultado, bool[] visitados){

			//agregar origen al camino
			camino.Add(origen);
			
			//marcamos a origen como visitado
			visitados[origen.getPosicion() - 1] = true;
			
			//chequeamos si origen y destino coinciden
			if(origen==destino){  //compara referencias: si ambas apuntan al mismo objeto, el objeto es el mismo
				//crear una copia de camino y agregar a camino

				List<Vertice<T>> caminoCopia = new List<Vertice<T>>(camino);
				resultado.Add(caminoCopia);
			}	
			else{
				//para cada adyacente a origen
				foreach(var adyacente in origen.getAdyacentes()){
					//si no fue visitado anteriormente
					if(!visitados[adyacente.getDestino().getPosicion() - 1]){
						//recursion
						__todosLosCaminosConDFS(grafo,adyacente.getDestino(),destino,camino,resultado,visitados);
						//desmarcar adyacente como visitado
						visitados[adyacente.getDestino().getPosicion() - 1] = false;
						
						//quitar ultimo vértice de camino
						camino.RemoveAt(camino.Count - 1);  //removeAt borra por índice (es más rápido que Remove()). En este caso, borro el ultimo elemento de camino, ya que quiero eliminar el ultimo agregado						
					}
				}
			}	
		}
		
		
		//parte pública, encapsula datos y facilita la tarea al usuario.
		public List<Vertice<T>> MejorCaminoConDFS(Grafo<T> grafo, Vertice<T> origen, Vertice<T> destino){
			//Lista de Vertices (camino)
			List<Vertice<T>> camino = new List<Vertice<T>>();
			
			//arreglo de boleanos
			bool[] visitados = new bool[grafo.getVertices().Count];
			
			//creo variable para almacenar el mejor camino
			List<Vertice<T>> mejorCamino = new List<Vertice<T>>(grafo.getVertices());
			
			//llamada al método privado
			return __MejorCaminoConDFS(grafo,origen,destino,camino,mejorCamino,visitados);
		}
		
		//método privado
		private List<Vertice<T>> __MejorCaminoConDFS(Grafo<T> grafo, Vertice<T> origen, Vertice<T> destino, List<Vertice<T>> camino,List<Vertice<T>> mejorCamino, bool[] visitados){
			
			//agregar origen al camino
			camino.Add(origen);
			//marcamos a origen como visitado
			visitados[origen.getPosicion() - 1] = true;
			
			//chequeamos si origen y destino coinciden
			if(origen==destino){  //compara referencias: si ambas apuntan al mismo objeto, el objeto es el mismo
				if(camino.Count<mejorCamino.Count){
					mejorCamino.Clear();              //limpio mejor camino
					mejorCamino.AddRange(camino);		//le agrego a mejor camino los elemento de camino
					//mejorCamino=new List<Vertice<T>>(mejorCamino);
				}			
			}	
			else{
				//para cada adyacente a origen
				foreach(var adyacente in origen.getAdyacentes()){
					//si no fue visitado anteriormente
					if(!visitados[adyacente.getDestino().getPosicion() - 1]){
						//recursion
						mejorCamino=this.__MejorCaminoConDFS(grafo,adyacente.getDestino(),destino,camino,mejorCamino,visitados);
					
						//desmarcar adyacente como visitado
						visitados[adyacente.getDestino().getPosicion() - 1] = false;
						
						//quitar ultimo vértice de camino
						camino.RemoveAt(camino.Count - 1);  //removeAt borra por índice (es más rápido que Remove()). En este caso, borro el ultimo elemento de camino, ya que quiero eliminar el ultimo agregado
						
					}
				}
			}
			
			return mejorCamino;			
		}
		
	
		
	public List<Arista<T>> MejorCaminoConDFSArista(Grafo<T> grafo, Vertice<T> origen, Vertice<T> destino){
			//Lista de Vertices (camino)
			List<Arista<T>> camino = new List<Arista<T>>();
			
			//arreglo de boleanos
			bool[] visitados = new bool[grafo.getVertices().Count];
			
			//creo variable para almacenar el mejor camino
			List<Arista<T>> mejorCamino = new List<Arista<T>>();
			
			//llamada al método privado
			return __MejorCaminoConDFSArista(grafo,origen,destino,camino,mejorCamino,visitados);
		}
		
		//método privado
		private List<Arista<T>> __MejorCaminoConDFSArista(Grafo<T> grafo, Vertice<T> origen, Vertice<T> destino, List<Arista<T>> camino,List<Arista<T>> mejorCamino, bool[] visitados){
	
			camino.Add(origen.getAdyacentes()[0]);
			visitados[origen.getPosicion() - 1] = true;		
			
			//chequeamos si origen y destino coinciden
			if(origen==destino){  //compara referencias: si ambas apuntan al mismo objeto, el objeto es el mismo
				//if((camino.Count>mejorCamino.Count) && (this.calcularTiempo(camino)<120)){
				if(mejorCamino.Count==0){
					mejorCamino.Clear();
					mejorCamino.AddRange(camino);
					//this.verCamino(mejorCamino);
				}
				if((this.calcularKilometro(camino)) < (this.calcularKilometro(mejorCamino))){
					mejorCamino.Clear();              //limpio mejor camino
					mejorCamino.AddRange(camino);		//le agrego a mejor camino los elemento de camino
					//this.verCamino(mejorCamino);
				}				
			}	
			else{
				//para cada adyacente a origen
				foreach(var adyacente in origen.getAdyacentes()){
					//si no fue visitado anteriormente
					if(!visitados[adyacente.getDestino().getPosicion() - 1]){
						//recursion	

						mejorCamino=this.__MejorCaminoConDFSArista(grafo,adyacente.getDestino(),destino,camino,mejorCamino,visitados);
			
						//desmarcar adyacente como visitado
						visitados[adyacente.getDestino().getPosicion() - 1] = false;
						
						//quitar ultimo vértice de camino
						camino.RemoveAt(camino.Count - 1);  //removeAt borra por índice (es más rápido que Remove()). En este caso, borro el ultimo elemento de camino, ya que quiero eliminar el ultimo agregado
						
					}
				}
			}
			
			return mejorCamino;			
		}
		
		
		
		public int calcularTiempo(List<Arista<T>> camino){
			int calculo=0;
			foreach(var arista in camino){
					calculo+= arista.getPeso() + Convert.ToInt32(arista.getDestino().getDato());
			}
			return calculo;
		}
		
		public int calcularKilometro(List<Arista<T>> camino){
			int calculo=0;
			foreach(var arista in camino){
					calculo+= arista.getPeso();
			}
			return calculo;
		}
		
		public void verCamino(List<Arista<T>> camino){
	//		Console.WriteLine("***************");
			foreach(var arista in camino){
				Console.Write(arista.getDestino().getDato() + "-");
			}
	//		Console.WriteLine("**************");
		}
		
		
	}
}
