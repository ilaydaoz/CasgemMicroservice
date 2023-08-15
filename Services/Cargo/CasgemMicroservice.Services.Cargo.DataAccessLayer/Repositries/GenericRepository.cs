﻿using CasgemMicroservice.Services.Cargo.DataAccessLayer.Abstract;
using CasgemMicroservice.Services.Cargo.DataAccessLayer.Context;

namespace CasgemMicroservice.Services.Cargo.DataAccessLayer.Repositries
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        private readonly CargoContext _cargoContext;

        public GenericRepository(CargoContext cargoContext)
        {
            _cargoContext = cargoContext;
        }

        public void Delete(T entity)
        {
            _cargoContext.Set<T>().Remove(entity);
            _cargoContext.SaveChanges();
        }

        public List<T> GetAll()
        {
            return _cargoContext.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return _cargoContext.Set<T>().Find(id);
        }

        public void Insert(T entity)
        {
            _cargoContext.Set<T>().Add(entity);
            _cargoContext.SaveChanges();
        }

        public void Update(T entity)
        {
            _cargoContext.Set<T>().Update(entity);
            _cargoContext.SaveChanges();
        }
    }
}
