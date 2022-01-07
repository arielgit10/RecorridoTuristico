
using System;

namespace RecorridoTuristico
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			Grafo<string> argentina = new Grafo<string>();
			
			Vertice<string> jujuy = new Vertice<string>("San Salvador de Jujuy");
			argentina.agregarVertice(jujuy);
			Vertice<string> salta = new Vertice<string>("Salta");
			argentina.agregarVertice(salta );
			Vertice<string> catamarca = new Vertice<string>("San Fernando del Valle de Catamarca");
			argentina.agregarVertice(catamarca);
			Vertice<string> tucuman = new Vertice<string>("San Miguel de Tucumán");
			argentina.agregarVertice(tucuman);
			Vertice<string> santiagoDelEstero = new Vertice<string>("Santiago del Estero");
			argentina.agregarVertice(santiagoDelEstero);
			Vertice<string> chaco = new Vertice<string>("Resistencia");
			argentina.agregarVertice(chaco);
			Vertice<string> formosa = new Vertice<string>("Formosa");
			argentina.agregarVertice(formosa);					
			Vertice<string> laRioja= new Vertice<string>("La Rioja");
			argentina.agregarVertice(laRioja);
			Vertice<string> cordoba = new Vertice<string>("Córdoba");
			argentina.agregarVertice(cordoba);
			Vertice<string> santaFe = new Vertice<string>("Santa fe");
			argentina.agregarVertice(santaFe);
			Vertice<string> corrientes = new Vertice<string>("Corrientes");
			argentina.agregarVertice(corrientes);
			Vertice<string> misiones = new Vertice<string>("Posadas");
			argentina.agregarVertice(misiones);
			Vertice<string> sanJuan = new Vertice<string>("San Juan");
			argentina.agregarVertice(sanJuan);
			Vertice<string> sanLuis = new Vertice<string>("San Luis");
			argentina.agregarVertice(sanLuis);
			Vertice<string> laPampa = new Vertice<string>("Santa Rosa");
			argentina.agregarVertice(laPampa);
			Vertice<string> buenosAires = new Vertice<string>("La Plata");
			argentina.agregarVertice(buenosAires);
			Vertice<string> entreRios = new Vertice<string>("Paraná");
			argentina.agregarVertice(entreRios);
			Vertice<string> mendoza = new Vertice<string>("Mendoza");
			argentina.agregarVertice(mendoza);
			Vertice<string> rioNegro = new Vertice<string>("Viedma");
			argentina.agregarVertice(rioNegro);
			Vertice<string> neuquen = new Vertice<string>("Neuquén");
			argentina.agregarVertice(neuquen);
			Vertice<string> chubut = new Vertice<string>("Rawson");
			argentina.agregarVertice(chubut);
			Vertice<string> santaCruz = new Vertice<string>("Río Gallegos");
			argentina.agregarVertice(santaCruz);
			Vertice<string> tierraDelFuego = new Vertice<string>("Ushuaia");
			argentina.agregarVertice(tierraDelFuego);
			
			//conexion jujuy
			argentina.conectar(jujuy,salta,67);
			
			//conexion salta
			argentina.conectar(salta,jujuy,67);
			argentina.conectar(salta,catamarca,410);
			argentina.conectar(salta,tucuman,228);		
			argentina.conectar(salta,santiagoDelEstero,353);		
			argentina.conectar(salta,chaco,706);		
			argentina.conectar(salta,formosa,741);		
			
			//conexion catamarca
			argentina.conectar(catamarca,tucuman,189);
			argentina.conectar(catamarca,salta,410);
			argentina.conectar(catamarca,laRioja,149);
			argentina.conectar(catamarca,cordoba,362);
			argentina.conectar(catamarca,santiagoDelEstero,166);
					 
			//conexion tucuman
			argentina.conectar(tucuman,catamarca,189);
			argentina.conectar(tucuman,salta,228);
			argentina.conectar(tucuman,santiagoDelEstero,141);
			
			//conexion santiago del estero
			argentina.conectar(santiagoDelEstero,catamarca,166);
			argentina.conectar(santiagoDelEstero,salta,353);
			argentina.conectar(santiagoDelEstero,tucuman,141);
			argentina.conectar(santiagoDelEstero,chaco,523);
			argentina.conectar(santiagoDelEstero,cordoba,401);
			argentina.conectar(santiagoDelEstero,santaFe,547);
			
			//conexion chaco
			argentina.conectar(chaco,santiagoDelEstero,523);
			argentina.conectar(chaco,salta,706);
			argentina.conectar(chaco,formosa,161);
			argentina.conectar(chaco,santaFe,495);
			argentina.conectar(chaco,corrientes,13);
			
			//conexion formosa
			argentina.conectar(formosa,chaco,161);
			argentina.conectar(formosa,salta,741);
			
			//conexion la rioja
			argentina.conectar(laRioja,catamarca,149);
			argentina.conectar(laRioja,cordoba,340);
			argentina.conectar(laRioja,sanLuis,435);
			argentina.conectar(laRioja,sanJuan,283);
			
			//conexiones cordoba
			argentina.conectar(cordoba,catamarca,362);
			argentina.conectar(cordoba,santiagoDelEstero,401);
			argentina.conectar(cordoba,laRioja,340);
			argentina.conectar(cordoba,sanLuis,293);
			argentina.conectar(cordoba,laPampa,577);
			argentina.conectar(cordoba,buenosAires,698);
			argentina.conectar(cordoba,santaFe,330);
			
			//conexiones santa fe
			argentina.conectar(santaFe,cordoba,330);
			argentina.conectar(santaFe,santiagoDelEstero,547);
			argentina.conectar(santaFe,chaco,495);
			argentina.conectar(santaFe,corrientes,498);
			argentina.conectar(santaFe,buenosAires,444);
			argentina.conectar(santaFe,entreRios,19);
			
			//conexiones corrientes
			argentina.conectar(corrientes,santaFe,498);
			argentina.conectar(corrientes,chaco,13);
			argentina.conectar(corrientes,misiones,291);
			argentina.conectar(corrientes,entreRios,500);
			
			//conexiones misiones
			argentina.conectar(misiones,corrientes,291);
			
			//conexiones san juan
			argentina.conectar(sanJuan,laRioja,283);
			argentina.conectar(sanJuan,sanLuis,284);
			argentina.conectar(sanJuan,mendoza,152);
			
			//conexiones san luis
			argentina.conectar(sanLuis,sanJuan,284);
			argentina.conectar(sanLuis,laRioja,435);
			argentina.conectar(sanLuis,cordoba,293);
			argentina.conectar(sanLuis,laPampa,412);
			argentina.conectar(sanLuis,mendoza,235);
			
			//conexiones la pampa
			argentina.conectar(laPampa,sanLuis,412);
			argentina.conectar(laPampa,cordoba,577);
			argentina.conectar(laPampa,buenosAires,602);
			argentina.conectar(laPampa,rioNegro,477);
			argentina.conectar(laPampa,mendoza,586);
			
			//conexiones buenos aires
			argentina.conectar(buenosAires,laPampa,602);
			argentina.conectar(buenosAires,cordoba,698);
			argentina.conectar(buenosAires,santaFe,444);
			argentina.conectar(buenosAires,entreRios,427);
			argentina.conectar(buenosAires,rioNegro,789);
			
			//conexiones entre rios
			argentina.conectar(entreRios,buenosAires,427);
			argentina.conectar(entreRios,santaFe,19);
			argentina.conectar(entreRios,corrientes,500);
			
			//conexiones mendoza
			argentina.conectar(mendoza,sanJuan,152);
			argentina.conectar(mendoza,sanLuis,235);
			argentina.conectar(mendoza,laPampa,586);
			argentina.conectar(mendoza,rioNegro,1019);
			argentina.conectar(mendoza,neuquen,676);
			
			//conexiones rio negro
			argentina.conectar(rioNegro,mendoza,1019);
			argentina.conectar(rioNegro,laPampa,477);
			argentina.conectar(rioNegro,buenosAires,789);
			argentina.conectar(rioNegro,neuquen,479);
			argentina.conectar(rioNegro,chubut,327);
			
			//conexiones neuquén
			argentina.conectar(neuquen,mendoza,676);
			argentina.conectar(neuquen,rioNegro,479);
			
			//conexiones chubut
			argentina.conectar(chubut,rioNegro,327);
			argentina.conectar(chubut,santaCruz,975);
			
			//conexiones santa cruz
			argentina.conectar(santaCruz,chubut,975);
			argentina.conectar(santaCruz,tierraDelFuego,359);
			
			//conexiones tierra del fuego
			argentina.conectar(tierraDelFuego,santaCruz,359);
			
		
			RecorridoTuristico<string> recorrido = new RecorridoTuristico<string>();
			
			Console.WriteLine("Recorrido desde La Plata hasta La Rioja: ");
			foreach(var v in recorrido.MejorCaminoConDFS(argentina,buenosAires,laRioja)){
				Console.Write(v.getDato() + "-");
			}
			Console.WriteLine();Console.WriteLine();Console.WriteLine();	
			Console.WriteLine("Recorrido desde Chubut hasta Misiones: ");
			foreach(var v in recorrido.MejorCaminoConDFS(argentina,chubut,misiones)){
				Console.Write(v.getDato() + "-");
			}
			Console.WriteLine();Console.WriteLine();Console.WriteLine();		
			Console.WriteLine("Recorrido desde Salta hasta Neuquén: ");
			foreach(var v in recorrido.MejorCaminoConDFS(argentina,salta,neuquen)){
				Console.Write(v.getDato() + "-");
			}
			Console.WriteLine();Console.WriteLine();Console.WriteLine();
			

		
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}