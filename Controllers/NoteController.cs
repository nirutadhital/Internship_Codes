using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
// using MyNotes.Core.Configuration;
using MyNotes.Data;
using MyNotes.Models;
using MyNotes.ViewModels;


namespace MyNotes.Controllers
{
    [Authorize]
    public class NoteController : Controller
    {
        private readonly ApplicationDbContext _context;
        //private readonly IUnitOfWork _unitOfWork;
        private readonly UserManager<User> _userManager;
        public NoteController(ApplicationDbContext context, UserManager<User> userManager)
        {
            _context=context;
            _userManager=userManager;
           // _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var UserId=_userManager.GetUserId(HttpContext.User);//ayle varkharai login vako user ko id bokxa UserId variable le
            var notes=_context.Notes.Where(n=>n.UserId==UserId).ToList();//this is traditional approach
            //var notes=_unitOfWork.Note.GetAllBy(n=>n.UserId==UserId);//this is repository pattern approach
            return View(notes);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new NoteViewModel());
        }

        [HttpPost]
        public IActionResult Create(NoteViewModel model)
        {
            if(ModelState.IsValid)
            {
                var UserId=_userManager.GetUserId(HttpContext.User);//ayle varkharai login vako user ko id bokxa UserId variable le
                var note=new Note()//NoteViewModel bata ayeko data lai ya lagera save garxau
                {
                    Title=model.Title,
                    Description=model.Description,
                    Color=model.Color,
                    UserId=UserId
                };
                _context.Notes.Add(note);//datbase ma lagera add garxa//traditional approach
                _context.SaveChanges();//db ma changes lai save garxa
                //_unitOfWork.Note.Create(note);
                //_unitOfWork.Save();//repository pattern approach
                return RedirectToAction(nameof(Index),"Note");//data save vaisake paxi home page ma redirect garni
            }
            return View(model);
        }

        
        [HttpGet]
        public IActionResult Edit(int id)//individual note ko id
        {
            //ram to note ram le mtra add garna paunaparxa
            var userId=_userManager.GetUserId(HttpContext.User);//current user ko userid
            var note=_context.Notes.FirstOrDefault(n=>n.Id==id);//traditional approach//note ko id ko adhar ma note liyera note vanni variable ma rakhya
            //var note=_unitOfWork.Note.GetBy(n=>n.Id==id);//repository pattern approach
            if(note.UserId==userId)//if this note lekhni user ko id ra current user ko id same xa vane
            {
                var model=new NoteViewModel()
                {
                    Id=note.Id,
                    Title=note.Title,
                    Description=note.Description,
                    CreatedDate=note.CreatedDate,
                    Color=note.Color,
                    UserId=userId
                };
                return View(model);
            }
            else
            {
                return Content("Yor are not Authorized");
            }
        }


        [HttpPost]
        public IActionResult Edit(NoteViewModel model)
        {
            if(ModelState.IsValid)
            {
            var userId=_userManager.GetUserId(HttpContext.User);//current user ko userid
            if(model.UserId==userId)
            {
                var note=new Note
                {
                    Id=model.Id,
                    Title=model.Title,
                    Description=model.Description,
                    CreatedDate=model.CreatedDate,
                    Color=model.Color,
                    UserId=model.UserId
                };
                 _context.Notes.Update(note);
                 _context.SaveChanges();//traditional approach
                //_unitOfWork.Note.Update(note);
                //_unitOfWork.Save();//repository pattern approach
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return Content("you are not authorized");
            }
            }
            return View(model);
        }


        public IActionResult Delete(int id)//individual note ko id
        {
            if(id==0)
            {
                return Content("Note id is NULL");
            }
            //ram to note ram le mtra delete garna paunaparxa
            var userId=_userManager.GetUserId(HttpContext.User);//current user ko userid
            var note=_context.Notes.FirstOrDefault(n=>n.Id==id);//traditional approach//note ko id ko adhar ma note liyera note vanni variable ma rakhya
            //var note=_unitOfWork.Note.GetBy(n=>n.Id==id);//repository pattern approach
            if(note.UserId==userId)//if this note lekhni user ko id ra current user ko id same xa vane
            {
                 _context.Notes.Remove(note);//traditional
                 _context.SaveChanges();//traditional
                //_unitOfWork.Note.Delete(id);
                //_unitOfWork.Save();//repository pattern approach
                return RedirectToAction(nameof(Index));

            }
            else
            {
                return Content("Your are not Authorized");
            }
        }
        
    }
}