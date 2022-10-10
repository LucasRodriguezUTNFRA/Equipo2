using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Show
    {
        Artista artista;
        Estadio estadio;
        DateTime fecha;
        int duracion;

        int cantidadMaximaVips;     
        int cantidadMaximaGenerales;    

        List<Entrada> entradasVipVendidas;
        List<Entrada> entradasGeneralesVendidas;

        public Show(Artista artista, Estadio estadio, DateTime fecha, int duracion, int porcentajeVip)
        {
            this.artista = artista;
            this.estadio = estadio;
            this.fecha = fecha;
            this.duracion = duracion;
            this.cantidadMaximaVips = (int)(estadio.capacidadMaxima * cantidadMaximaVips / 100);
            this.cantidadMaximaGenerales = estadio.capacidadMaxima - cantidadMaximaVips;
        }

        public Artista Artista { get => artista; set => artista = value; }
        public Estadio Estadio { get => estadio; set => estadio = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public int Duracion { get => duracion; set => duracion = value; }
        public int CantidadMaximaVips { get => cantidadMaximaVips; set => cantidadMaximaVips = value; }
        public int CantidadMaximaGenerales { get => cantidadMaximaGenerales; set => cantidadMaximaGenerales = value; }
        public List<Entrada> EntradasVipVendidas { get => entradasVipVendidas; set => entradasVipVendidas = value; }
        public List<Entrada> EntradasGeneralesVendidas { get => entradasGeneralesVendidas; set => entradasGeneralesVendidas = value; }
    }
}
