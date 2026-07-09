using System;
using System.Collections.Generic;
using System.Text;

namespace POO_Torneo_DMURILLO.Models
{
    public class Partido
    {
        public Equipo Local { get; set; }
        public Equipo Visitante { get; set; }
        public DateTime Fecha { get; set; }
        public string Lugar { get; set; }
        public string Estado { get; set; }
        public int Numero { get; set; }


        public Partido(Equipo local, Equipo visitante, DateTime fecha, string lugar, int numero, string estado)
        {
            if (ValidarEquipos(local, visitante) == 1)
            {
                throw new Exception("Los equipos no pueden ser nulos");
            }
            if (ValidarEquipos(local, visitante) == 2)
            {
                throw new Exception("Los equipos no pueden ser iguales");
            }

            this.Local = local;
            this.Visitante = visitante;
            this.Fecha = fecha;
            this.Lugar = lugar;
            Numero = numero;
            Estado = estado;
        }

        public void MostrarResumen()
        {
            Console.WriteLine($"Hay un partido programado entre el local {this.Local.Nombre} y el visitante {this.Visitante.Nombre} en el lugar {this.Lugar}");
        }
        //Validacion de equipos, si son nulos o si son iguales
        public int ValidarEquipos(Equipo local, Equipo visitante)
        {
            if (local != null && visitante != null)
            {
                return 1;
            }
            if (local.Nombre == visitante.Nombre)
            {
                return 2;
            }
            return 0;
        }

        public void IniciarPartido(int partido) { }

        public void PausarPartido(int partido) { }

        public void FinalizarPartido(int partido) { }

    }
}
