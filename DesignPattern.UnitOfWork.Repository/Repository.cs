﻿using DesignPattern.UnitOfWork.Models.Data;
using Microsoft.EntityFrameworkCore;

namespace DesignPattern.UnitOfWork.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private UnitOfWorkContext _context;
        private DbSet<TEntity> _dbSet;

        public Repository(UnitOfWorkContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        public void Add(TEntity data) => _dbSet.Add(data);

        public void Delete(int id)
        {
            var dataToDelete = _dbSet.Find(id);
            _dbSet.Remove(dataToDelete);
        }

        public IEnumerable<TEntity> Get() => _dbSet.ToList();

        public TEntity Get(int id) => _dbSet.Find(id);

        public void Save() => _context.SaveChanges();

        public void Update(TEntity data)
        {
            _dbSet.Attach(data);
            _context.Entry(data).State = EntityState.Modified;
        }
    }
}
