
using System;
using System.Collections.Generic;

namespace RecorridoTuristico
{

	class Estrategia
	{
		 
//		//Calcula y retorna un texto con la distancia del camino que existe entre el planeta del Bot y la raíz.
//		public string Consulta1( ArbolGeneral<T> arbol)
//		{
//	
//			int distancia= __consulta1(arbol);  //llamamos al método privado que hará el trabajo
//			
//			return string.Format("La distancia que existe entre el planeta boot y la raiz es de {0}.",distancia);
//		}
//		//recorrido por niveles con separación
//		private int __consulta1(ArbolGeneral<T> arbol){
//			Cola<ArbolGeneral<Planeta>> cola = new Cola<ArbolGeneral<Planeta>>();
//			ArbolGeneral<Planeta> arbolAux;
//				
//			int nivel=0;
//			cola.encolar(arbol);
//			cola.encolar(null);  
//				
//			while(!cola.esVacia()){
//				arbolAux = cola.desencolar(); 	
//				
//				if(arbolAux==null){        		    
//					if(!cola.esVacia()){  		 	
//						nivel++;			   //se incrementa el nivel
//						cola.encolar(null);       		
//					}	
//				}
//				else{   
//					if(arbolAux.getDatoRaiz().EsPlanetaDeLaIA()){   //si el nodo es planeta de la IA, se corta la ejecución
//						break;
//					}
//					if(arbolAux.getHijos().Count != 0){          	 //si el nodo tiene hijos
//						foreach(var hijo in arbolAux.getHijos()){   //se recorren los hijos
//							cola.encolar(hijo);						//se encolan los hijos
//						}
//					}					
//				}
//			}
//			return nivel;
//		}
//
//
////		Retorna un texto con el listado de los planetas ubicados en todos los descendientes 
////		del nodo que contiene al planeta del Bot.	
//		public string Consulta2( ArbolGeneral<Planeta> arbol)
//		{
//			string texto="";			
//		
//			List<ArbolGeneral<Planeta>> listaDescendientes = __consulta2(arbol); //se llama al metodo privado que retornará la lista de descendientes
//			
//			if(listaDescendientes.Count==0){   //si la lista está vacía
//				texto+="No tiene descendientes el planeta bot.";
//			}
//			else{	//si no está vacía se recorre la lista de descendientes
//				texto +=string.Format("Los descendientes del planeta bot son:");
//				foreach(var des in listaDescendientes){
//					texto +=string.Format("\n{0}",des.ToString());  //se añade a la variable texto el dato del nodo
//					Console.WriteLine();
//				}
//			}
//			
//			return texto;
//		}
//	
//		//recorrido por niveles
//		private List<ArbolGeneral<Planeta>>  __consulta2(ArbolGeneral<Planeta> arbol){
//			Cola<ArbolGeneral<Planeta>> cola = new Cola<ArbolGeneral<Planeta>>();
//			ArbolGeneral<Planeta> arbolAux;				
//			List<ArbolGeneral<Planeta>> listaDescendientes = new List<ArbolGeneral<Planeta>>();
//						
//			cola.encolar(arbol);
// 	
//			while(!cola.esVacia()){
//				arbolAux = cola.desencolar(); 	
//
//				if(arbolAux.getDatoRaiz().EsPlanetaDeLaIA()){					//si el nodo es planeta de la IA
//					listaDescendientes = arbolAux.preorden(listaDescendientes); //se llama al método que añadirá los nodos a la lista
//					break;												   
//				}
//				if(arbolAux.getHijos().Count != 0){						//se recorre los hijos del nodo, si tiene, y se los encola
//					foreach(var hijo in arbolAux.getHijos()){
//						cola.encolar(hijo);
//					}					
//				}
//			}
//			return listaDescendientes;
//		}
//		
//		
//		
//		//Calcula y retorna en un texto la población total y promedio por cada nivel del árbol.
//		public string Consulta3( ArbolGeneral<Planeta> arbol)
//		{
//			string texto="";
//			float poblacion=0;
//			int cantidadPlanetas=0;			
//			
//			return __Consulta3(arbol,texto,poblacion,cantidadPlanetas);  //se retorna el método privado que realiza el trabajo
//		}
//		
//		//recorrido por nivel con separación
//		private string __Consulta3( ArbolGeneral<Planeta> arbol, string texto,float poblacion,int cantidadPlanetas)
//		{
//			Cola<ArbolGeneral<Planeta>> cola = new Cola<ArbolGeneral<Planeta>>();  //creo una cola
//			ArbolGeneral<Planeta> arbolAux; 	//creo un arbol auxiliar
//			
//			int nivel=0;
//				
//			cola.encolar(arbol); //se encola el primer nodo del arbol
//			cola.encolar(null);  //encolo un null
//			
//			while(!cola.esVacia()){ 		  //mientras la cola no esté vacía
//				arbolAux = cola.desencolar(); 	    //sacamos el elemento de la cola y lo guardamos en el arbolAuxiliar
//				
//				if(arbolAux==null){        		    //si el nodo es un null, agregamos a la variable texto los datos del nodo
//					texto += string.Format("\nNivel{0}\nPoblación={1},Promedio={2}\n",nivel,poblacion,poblacion/cantidadPlanetas);
//					
//					if(!cola.esVacia()){  		 		//si la cola no esta vacía
//						nivel++;						//incremento nivel
//						poblacion=0;					//reseteo variable 
//						cantidadPlanetas=0;				//reseteo variable 
//						cola.encolar(null);       		//encolo nuevamente el null
//					}
//				}
//				else{    
//					cantidadPlanetas++;								//incremento variable
//					poblacion+=arbolAux.getDatoRaiz().Poblacion(); //incremento variable
//
//					foreach(var hijo in arbolAux.getHijos()){ //recorro hijos del nodo
//						cola.encolar(hijo);					 //encolo los hijos
//					}
//				}
//				
//			}		
//			
//			return texto;
//		}
//		
//		
//		
//		//Este método calcula y retorna el movimiento apropiado según el estado del juego. 
//		//	El estado del juego es recibido en el parámetro arbol de tipo ArbolGeneral<Planeta>. 
//		//	Cada nodo del árbol contiene como dato un planeta del juego.
//		public Movimiento CalcularMovimiento(ArbolGeneral<Planeta> arbol)
//		{					
//			List<ArbolGeneral<Planeta>> caminoAtaque = caminoDeAtaque(arbol); //se llama al método que retorna el camino de ataque y se lo guarda en una lista de árboles
//			
//			Movimiento mov = null;
//			
//			for(int i=0;i<caminoAtaque.Count-1;i++){ //recorro lo lista
//				if(caminoAtaque[i].getDatoRaiz().EsPlanetaDeLaIA()){	 //si el nodo es planeta de la IA			
//					if(caminoAtaque[i].getDatoRaiz().Poblacion()>caminoAtaque[i+1].getDatoRaiz().Poblacion()){	//y si tiene mayor población que el nodo a atacar
//						mov=new Movimiento(caminoAtaque[i].getDatoRaiz(),caminoAtaque[i+1].getDatoRaiz());    //se realiza el ataque
//					}
//					else{									//si no es mayor
//						mov=ataque(caminoAtaque[i],mov);		//se llama al método ataque que retorna un movimiento y se le pasa el nodo	
//					}
//				}								
//			}	
//			return mov;
//		}
//			
//		//método que retorna un ataque (recorrido por niveles)
//		private Movimiento ataque(ArbolGeneral<Planeta> arbol,Movimiento mov){
//			
//			Cola<ArbolGeneral<Planeta>> cola = new Cola<ArbolGeneral<Planeta>>();
//			ArbolGeneral<Planeta> arbolAux;				
//			
//			cola.encolar(arbol);
// 			
//			while(!cola.esVacia()){
//				arbolAux = cola.desencolar(); 	
//				
//				foreach(ArbolGeneral<Planeta> h in arbol.getHijos()){   //recorre los hijos del nodo
//						if(h.getDatoRaiz().EsPlanetaDeLaIA()){			//si el hijo es planeta de la IA
//								mov=new Movimiento(h.getDatoRaiz(),arbol.getDatoRaiz());  //se realiza un ataque (el hijo ataca al padre, para reforzarlo)
//								break;		
//						}
//				}			
//				
//				if(arbolAux.getHijos().Count != 0){   //si el nodo tiene hijos
//					foreach(var hijo in arbolAux.getHijos()){  //se recorre sus hijos
//						
//						if(hijo.getDatoRaiz().EsPlanetaDeLaIA()){	//si el hijo es planeta de la IA
//							cola.encolar(hijo);						//se encola							
//						}	
//					}					
//				}
//			}
//			return mov;;
//		}
//		
//		
//		//método que retorna la lista del camino de ataque		
//		public List<ArbolGeneral<Planeta>> caminoDeAtaque(ArbolGeneral<Planeta> arbol){
//			List<ArbolGeneral<Planeta>> cBot = caminoABotConDFS(arbol);  	  //se llama al método que retorna el camino al bot
//			List<ArbolGeneral<Planeta>> cUser = caminoAUsuarioConDFS(arbol); //se llama al método que retorna el camino al user
//			List<ArbolGeneral<Planeta>> caminoAtaque = new List<ArbolGeneral<Planeta>>();   
//			
//			//busco ancestro comun entre el camino hacia el bot y el camino hacia el user
//			ArbolGeneral<Planeta> ancestro=null;
//			foreach (ArbolGeneral<Planeta> arbB in cBot){
//				foreach (ArbolGeneral<Planeta> arbU in cUser){
//					if(arbU==arbB){
//						ancestro=arbU;
//					}
//				}
//			}
//			
//			//REVIERTO LA LISTA DEL CAMINO AL BOT
//			cBot.Reverse();
//
//			//AÑADO A CAMINO ATAQUE LO CORRESPONDIENTE AL CAMINO AL BOT
//			foreach (ArbolGeneral<Planeta> arb in cBot){  //recorro las nodos del camino al bot
//				caminoAtaque.Add(arb);
//				if(arb==ancestro){   //si el nodo es igual al ancestro, se corta la ejecución del bucle for
//					break;
//				}
//			}
//			
//			//AÑADO A CAMINO ATAQUE LO CORRESPONDIENTE AL CAMINO AL user
//			bool aniadir= false;     //variable inicializada en false
//			foreach (ArbolGeneral<Planeta> arb in cUser){   //recorro los nodos del camino al user
//				if(aniadir){            	   //si la variable es true
//					caminoAtaque.Add(arb);    //se añade al camino de ataque el nodo
//				}
//				if(arb==ancestro){   //si el nodo es igual al ancestro
//					aniadir=true;   //la varible es true
//				}
//			}
//			return caminoAtaque;   //se retorna el camino de ataque
//		}
//		
//
//		
//		//método que retorna el camino al bot, una lista
//		public List<ArbolGeneral<Planeta>> caminoABotConDFS(ArbolGeneral<Planeta> origen){
//			List<ArbolGeneral<Planeta>> camino = new List<ArbolGeneral<Planeta>>();
//			List<ArbolGeneral<Planeta>> mejorCamino = new List<ArbolGeneral<Planeta>>(origen.getHijos());		
//			return __caminoABotConDFS(origen,origen,camino,mejorCamino);  //se retorna el método privado que realiza el trabajo
//		}
//		
//		//método privado
//		private List<ArbolGeneral<Planeta>> __caminoABotConDFS(ArbolGeneral<Planeta> arbol,ArbolGeneral<Planeta> origen,List<ArbolGeneral<Planeta>> camino,List<ArbolGeneral<Planeta>> mejorCamino){
//		
//			//agregar origen al camino
//			camino.Add(origen);
//
//			if(origen.getDatoRaiz().EsPlanetaDeLaIA()){  // si el nodo es planeta de la IA
//				if(camino.Count<mejorCamino.Count){  //si camino tiene menos nodos que el mejor camino
//					mejorCamino.Clear();			//se eliminan los nodos de mejor camino
//					mejorCamino.AddRange(camino);  //se agregan a mejor camino los nodos de camino
//				}
//			}	
//			else{	 
//				foreach(var hijo in origen.getHijos()){     //se recorre los hijos del nodo
//					mejorCamino=this.__caminoABotConDFS(arbol,hijo,camino,mejorCamino);   //se realiza una recursión				
//					//quitar ultimo nodo de camino
//					camino.RemoveAt(camino.Count - 1);
//				}
//			}	
//			return mejorCamino;			
//		}
//		
//		
//		//método que retorna el camino al usuario
//		public List<ArbolGeneral<Planeta>> caminoAUsuarioConDFS(ArbolGeneral<Planeta> origen){
//			List<ArbolGeneral<Planeta>> camino = new List<ArbolGeneral<Planeta>>();
//			List<ArbolGeneral<Planeta>> mejorCamino = new List<ArbolGeneral<Planeta>>(origen.getHijos());
//			return __caminoAUsuarioConDFS(origen,origen,camino,mejorCamino);  //se retorna el método privado que realiza el trabajo
//		}
//		
//		//método privado
//		private List<ArbolGeneral<Planeta>> __caminoAUsuarioConDFS(ArbolGeneral<Planeta> arbol,ArbolGeneral<Planeta> origen,List<ArbolGeneral<Planeta>> camino,List<ArbolGeneral<Planeta>> mejorCamino)
//		{
//			//agregar origen al camino
//			camino.Add(origen);
//			
//			if(origen.getDatoRaiz().EsPlanetaDelJugador()){  // si el nodo es planeta de la IA
//				if(camino.Count<mejorCamino.Count){			//si camino tiene menos nodos que el mejor camino
//					mejorCamino.Clear();					//se eliminan los nodos de mejor camino
//					mejorCamino.AddRange(camino);			//se agregan a mejor camino los nodos de camino
//				}
//			}	
//			else{	
//				foreach(var hijo in origen.getHijos()){          //se recorre los hijos del nodo
//					mejorCamino=this.__caminoAUsuarioConDFS(arbol,hijo,camino,mejorCamino);  //se realiza una recursión					
//					//quitar ultimo vértice de camino
//					camino.RemoveAt(camino.Count - 1);
//				}
//			}
//			return mejorCamino;					
//		}
//		
//		
//		
//		
//		
		
		
	}
}
