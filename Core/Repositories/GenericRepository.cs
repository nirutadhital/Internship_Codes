// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Linq.Expressions;
// using System.Threading.Tasks;
// using Microsoft.EntityFrameworkCore;
// using MyNotes.Core.IRepositories;
// using MyNotes.Data;

// namespace MyNotes.Core.Repositories
// {
//     public class GenericRepository<T> : IGenericRepository<T> where T : class
//     {
//         private readonly ApplicationDbContext _context;
//         private readonly DbSet<T> entity;
//         public GenericRepository(ApplicationDbContext context)
//         {
//             _context=context;
//             entity=context.Set<T>();

//         }
//         public void Create(T t)
//         {
//             entity.Add(t);
//         }

//         public void Delete(int id)
//         {
//             var currentEntity=entity.Find(id);
//             entity.Remove(currentEntity);
//         }

//         public List<T> GetAll()
//         {
//             return entity.ToList();
//         }

//         public List<T> GetAllBy(Expression<Func<T, bool>> predicate)
//         {
//             return entity.Where(predicate).ToList();
//         }

//         public T GetBy(Expression<Func<T, bool>> predicate)
//         {
//             return entity.FirstOrDefault(predicate);
//         }

//         public void Update(T t)
//         {
//             entity.Update(t);
//         }
//     }
// }