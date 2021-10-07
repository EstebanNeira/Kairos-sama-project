using System;

namespace Veterinaria.App.Dominio {

    public class Persona : EntidadGenerica {
        public String Nombre {get; set;}
        public String Apellido {get; set;}
        public DateTime FechaNacimiento {get; set;}
        public String Telefono {get; set;}
        public String Direccion {get; set;}
        public String Correo {get; set;}
        public String Contrasena {get; set;}
        public DateTime FechaRegistro {get; set;}
    }
}