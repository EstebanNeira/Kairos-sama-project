using System;
using System.Collections.Generic;
using System.Linq;
using Veterinaria.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace Veterinaria.App.Persistencia {
    public class Repositorio<T> : IRepositorio<T> 
    where T : EntidadGenerica
    {
        protected readonly AppContext appContext;
        protected readonly DbSet<T> dbSet;
        private Repositorio() {
            this.appContext = new AppContext();
            this.dbSet = appContext.Set<T>();
        }
         public void Insertar(T entidad) {
             if(entidad == null) {
                throw new ArgumentNullException("entidad");
            }
            dbSet.Add(entidad);
            this.appContext.SaveChanges();
         }
        public void Borrar(T entidad) {
            if(entidad == null) {
                throw new ArgumentNullException("entidad");
            }

            dbSet.Remove(entidad);
            this.appContext.SaveChanges();
        }
        public T Consultar(int id) {
            return dbSet.SingleOrDefault( entity=> entity.Id == id);
        }
        public void Actualizar(T entidad) {
            if(entidad == null) {
                throw new ArgumentNullException("entidad");
            }
            dbSet.Update(entidad);
            this.appContext.SaveChanges();
        }
        public  IEnumerable<T> ConsultarTodos() {
            return dbSet.AsEnumerable();
        }

        public static Repositorio<T> Init() {
            return new Repositorio<T>();
        } 
    }
}