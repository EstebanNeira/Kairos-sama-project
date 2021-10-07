using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Veterinaria.App.Presentacion.Pages
{
    public class RegistroMascotaModel : PageModel
    {
        public String titulo {get; set;}

        public List <Mascota> listaMascotas = new List<Mascota>();
       

        public void OnGet()
        {
           
           this.listaMascotas.Add(
             new Mascota  {Index = this.listaMascotas.Count+1, Nombre= "Thor", Edad = 5, Tipo = "Perro", Raza = "Samoyedo"}
           );

            this.listaMascotas.Add(
               new Mascota  {Index = this.listaMascotas.Count+1, Nombre= "Maximus", Edad = 8, Tipo = "Perro", Raza = "Pastor Alemán"}
           );

            this.listaMascotas.Add(
                new Mascota {Index = this.listaMascotas.Count+1, Nombre= "Iris", Edad = 2, Tipo = "Gato", Raza = "Europeo de Pelo Corto"}
           );

           this.listaMascotas.Add(
                new Mascota {Index = this.listaMascotas.Count+1, Nombre= "Seraphine", Edad = 4, Tipo = "Ave", Raza = "Cacatúa"}
           );

            this.titulo = "Administra tus mascotas";
        }
    } 


    public class Mascota{

        public int Index { get; set; }
        public String Nombre {get; set;}
        public String Tipo {get; set;}
        public int Edad {get; set;}
        public String Raza {get; set;}

    }

}
