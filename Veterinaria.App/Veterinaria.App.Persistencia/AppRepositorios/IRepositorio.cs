using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veterinaria.App.Dominio;

namespace Veterinaria.App.Persistencia {
    public interface IRepositorio<T> where T : EntidadGenerica {
        void Insertar(T entidad);
        void Borrar(T entidad);
        T Consultar(int id);
        void Actualizar(T entidad);
        IEnumerable<T> ConsultarTodos();
    }
}