using System;
namespace Veterinaria.App.Dominio {
    public class Mascota : EntidadGenerica {
        public Cuidador Cuidador{get; set;}
        public Raza Raza{get;set;}
        public Genero Genero{get; set;}
        public int Nombre{get; set;}
        public DateTime FechaNacimiento{get; set;}
        public float Peso{get; set;}
        public String Tamaño{get; set;}
        public String Color{get; set;}
        public Boolean Esterilzado{get; set;}
        public String DetalleCuidado{get; set;}
        
    }
}