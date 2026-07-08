using System;
using System.Collections.Generic;
using System.Text;

namespace POO_Torneo_DMURILLO.Models
{
    public class Equipo
    {
        public string Nombre { get; set; }
        public string Ciudad { get; set; }
        public List<Jugador> Jugadores { get; set; }


        public Equipo(string nombre, string ciudad)
        {
            this.Nombre = nombre;
            this.Ciudad = ciudad;
            this.Jugadores = new List<Jugador>();
        }

        public void AgregarJugador(Jugador objJugador)
        {
            if (ValidarNotNull(objJugador))
            {
                this.Jugadores.Add(objJugador);
                Console.WriteLine($"Jugador {objJugador.Nombre} agregado correctamente");
            }
            else
            {
                Console.WriteLine("Error: El jugador no puede ser null");
            }   
        }

        //Validación de que jugador no sea null by dmurillo
        public Boolean ValidarNotNull(Jugador objJugador)
        {
            if (objJugador.Nombre == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ListarPlantilla()
        {
            Console.WriteLine($"La lista de jugadores del equipo {this.Nombre} de la ciudad de {this.Ciudad} es:");
            foreach (Jugador objJugador in Jugadores)
            {
                objJugador.Presentar();
            }
        }
    }
}