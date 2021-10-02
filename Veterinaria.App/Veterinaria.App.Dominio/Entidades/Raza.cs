using System;
namespace Veterinaria.App.Dominio {
    public class Raza : EntidadGenerica {
        public Especie Especie{get;set;}
        public String Nombre{get; set;}
    }
}