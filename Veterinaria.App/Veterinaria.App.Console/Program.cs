using System;
using Veterinaria.App.Dominio;
using Veterinaria.App.Persistencia;
using System.Text.Json;

namespace Veterinaria.App.Consola {
    class Program {
        
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");
            AgregarVeterinario();
            //ActualizarVeterinario(2);
            //Console.WriteLine(JsonSerializer.Serialize(ConsultarPorIdVeterinario(1)));
            //BorrarVeterinario(2);
            //AgregarCuidador();
            //ActualizarCuidador(1);
            //Console.WriteLine(JsonSerializer.Serialize(ConsultarPorIdCuidador(1)));
            //BorrarCuidador(1);
            //InsertarRaza();

        }
        //CRUD VETERINARIO
        private static void AgregarVeterinario() {
            Repositorio<Veterinario>.Init().Insertar(
                new Veterinario {
                    Nombre = "David",
                    Apellido = "Gonzales",
                    FechaNacimiento = new DateTime(1987,08,25),
                    Telefono = "7894563",
                    Direccion = "Carrera 445",
                    Correo = "david.gonzales@gmail.com",
                    Contrasena = "12345",
                    FechaRegistro =  DateTime.Now,
                    Especializacion = "Auxiliar veterinario",
                    TarjetaProfesional = "8965874"
                }
            );
        }

        public static Veterinario ConsultarPorIdVeterinario(int id) {
            Veterinario veterinario = Repositorio<Veterinario>.Init().Consultar(id);

            if(veterinario == null) {
                throw new ArgumentException("No existe");
            }
            
            return veterinario;
        }
        public static void ActualizarVeterinario(int id) {
            Veterinario veterinario = ConsultarPorIdVeterinario(id);

            veterinario.Nombre = "Marcelo";
            veterinario.Telefono = "123456";
            veterinario.Correo = "marcelo.gonzales@gmail.com";
            veterinario.FechaRegistro = DateTime.Now;
            Console.WriteLine(JsonSerializer.Serialize(veterinario));

            Repositorio<Veterinario>.Init().Actualizar(veterinario);
        }
        public static void BorrarVeterinario(int id) {
            Repositorio<Veterinario>.Init().Borrar(ConsultarPorIdVeterinario(id));
        }
        //CRUD CUIDADOR
        private static void AgregarCuidador() {
            Repositorio<Cuidador>.Init().Insertar(
                new Cuidador {
                    Nombre = "Daniela",
                    Apellido = "Martinez",
                    FechaNacimiento = new DateTime(2001,09,01),
                    Telefono = "789546",
                    Direccion = "calle 68",
                    Correo = "daniela.martinez@gmail.com",
                    Contrasena = "789658",
                    FechaRegistro = DateTime.Now,
                    TelefonoSecundario = "3006267932"
                }
            );
        }

        public static Cuidador ConsultarPorIdCuidador(int id) {
            Cuidador cuidador = Repositorio<Cuidador>.Init().Consultar(id);

            if(cuidador == null) {
                throw new ArgumentException("No existe");
            }

            return cuidador;
        }
        public static void ActualizarCuidador(int id) {
            Cuidador cuidador = ConsultarPorIdCuidador(id);

            cuidador.Nombre = "Alexadra";
            cuidador.Telefono = "123456";
            cuidador.Correo = "alexandra.martinez@gmail.com";

            Repositorio<Cuidador>.Init().Actualizar(cuidador);
        }
        public static void BorrarCuidador(int id) {
            Repositorio<Cuidador>.Init().Borrar(ConsultarPorIdCuidador(id));
        }
        //CRUD Raza

  /* public static void InsertarRaza() {
            Especie especie = new Especie();
            especie.Id = 1;
            Repositorio<Raza>.Init().Insertar(
                new Raza {
                    Especie = especie,
                    Nombre = "Ladrador"
                }
            );
        }*/
    }
    

}
