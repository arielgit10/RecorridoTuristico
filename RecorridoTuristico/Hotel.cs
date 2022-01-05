
using System;

namespace RecorridoTuristico
{

	public class Hotel
	{
		private string name;
		private int cantHabitaciones;
		private int habOcupadas;
		
		public Hotel(string name, int cantHabitaciones)
		{
			this.name=name;
			this.cantHabitaciones=cantHabitaciones;
			this.habOcupadas=0;
		}
		
		
		public int getCantHabitaciones(){
			return this.cantHabitaciones;
		}
		
		public int getHabOcupadas(){
			return this.habOcupadas;
		}
		
		public bool sinHabitaciones(){
			return this.habOcupadas==cantHabitaciones;
		}
		
		public int cantHabitacionesDisponibles(){
			return this.cantHabitaciones - this.habOcupadas;
		}
		

		
	}
}
