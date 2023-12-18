// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Linq.Expressions;
// using System.Threading.Tasks;

// namespace MyNotes.Core.IRepositories
// {
//     public interface IGenericRepository<T> where T : class
//     {
//         List<T> GetAll();//vayevarko sabai data return garxa
//         List<T> GetAllBy(Expression<Func<T,bool>> predicate);//kei ko adhar ma data return garxa
//         T GetBy(Expression<Func<T,bool>> predicate);//single entiry matra return garxa tara kei ko adhar ma
//         void Create(T t);//create note
//         void Delete (int id);//delete note
//         void Update(T t);//update note
        
//     }
// }