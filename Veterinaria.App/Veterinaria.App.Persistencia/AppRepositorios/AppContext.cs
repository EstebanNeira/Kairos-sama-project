using System;
using Microsoft.EntityFrameworkCore;
using Veterinaria.App.Dominio;

namespace Veterinaria.App.Persistencia { 

    public class AppContext : DbContext {

        public DbSet<Persona> Persona {get; set;}
        public DbSet<Veterinario> Veterinario {get; set;}
        public DbSet<Genero> Genero {get; set;}
        public DbSet<Especie> Especie {get; set;}
        public DbSet<Raza> Raza {get; set;}
        public DbSet<Cuidador> Cuidador {get; set;}
        public DbSet<Mascota> Mascota {get; set;}
        public DbSet<TipoCita> TipoCita {get; set;}
        public DbSet<Atencion> Atencion {get; set;}
        public DbSet<Cita> Cita {get; set;}
        public DbSet<Medicamento> Medicamento {get; set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder){
            if(!optionBuilder.IsConfigured) {
                optionBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = BDVeterinaria");
            }
        }

    }

}