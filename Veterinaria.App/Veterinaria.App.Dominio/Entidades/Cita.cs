using System;
namespace Veterinaria.App.Dominio {
    public class Cita : EntidadGenerica{
        public TipoCita TipoCita{get; set;}
        public Atencion Atencion{get; set;}
        public Mascota Mascota{get; set;}
        public Veterinario Veterinario{get; set;}
        public DateTime FechaInicio{get; set;}
        public DateTime FechaFin{get; set;}
        public Boolean Estado{get; set;}
    }
}