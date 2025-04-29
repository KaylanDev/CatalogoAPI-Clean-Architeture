using Catalogo.Domain.Interfaces;
using Catalogo.Infrastruture.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo.Infrastruture.Repositories;

public class Repository<T> : IRepository<T> where T : class
{
    private readonly AppDbContext _db;

    public Repository(AppDbContext db)
    {
        _db = db;
    }
    public Task<T> CreateAsync(T t)
    {
      _db.Set<T>().Add(t);
        _db.SaveChanges();
        return Task.FromResult(t);
    }

    public async Task<IEnumerable<T>> GetAsync()
    {
       var entiti = await _db.Set<T>().ToListAsync();
        return entiti;
    }

    public async Task<T> GetByIdAsync(int? id)
    {
        return await _db.Set<T>().FindAsync(id);
    }

    public Task<T> RemoveAsync(T t)
    {
         _db.Set<T>().Remove(t);
       _db.SaveChanges();
        return Task.FromResult(t);
    }

    public Task<T> UpdateAsync(T t)
    {
        _db.Set<T>().Update(t);
        _db.SaveChanges();
        return Task.FromResult(t);
    }
}
