using System;
namespace Veterinaria.App.Dominio {
    public class Atencion : EntidadGenerica {
        public String MotivoConsulta{get; set;}
        public String ExploracionClinica{get; set;}
        public String Diagnostico{get; set;}
        public String Pronostico{get; set;}
    }
}