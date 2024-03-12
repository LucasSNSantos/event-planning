using infra.Data;
using infra.Entities;
using infra.Interfaces;
using infra.Interfaces.Generic;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq.Expressions;

namespace infra.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _context;

        public UserRepository(DataContext dataContext)
        {
                _context = dataContext;
        }
        public void Add(User entity)
        {
            _context.Add(entity);
            _context.SaveChanges();

        }

        public async ValueTask<IEnumerable<User>> Find(Expression<Func<User, bool>> predicate)
        {
            return await _context.User.Where(predicate).ToListAsync(); ;
            
        }

        public async ValueTask<IEnumerable<User>> FindLoaded(Expression<Func<User, bool>> predicate)
        {
            return await _context.User.Where(predicate).ToListAsync(); ;
        }

        public async ValueTask<IEnumerable<User>> GetAll()
        {
            return await _context.User.ToListAsync(); ;

        }

        public async ValueTask<User> GetById(int id)
        {
            return await _context.User.Where(x => x.Id == id).FirstOrDefaultAsync(); ;

        }

        public bool Remove(User entity)
        {
            _context.Remove(entity);
            _context.SaveChanges();
            return true;
        }

        public void Update(User entity)
        {
            _context.Update(entity);
            _context.SaveChanges();
        }
    }
}
