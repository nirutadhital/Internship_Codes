// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using MyNotes.Core.Configuration;
// using MyNotes.Core.IRepositories;
// using MyNotes.Core.Repositories;

// namespace MyNotes.Data
// {
//     public class UnitOfWork : IUnitOfWork
//     {
//         private readonly ApplicationDbContext _context;
//         public INoteRepository Note {get; private set;}

//         public UnitOfWork(ApplicationDbContext context)
//         {
//             _context=context;
//             Note=new NoteRepository(context);

//         }
//         public void Save()
//         {
//             _context.SaveChanges();
//         }
//     }
// }