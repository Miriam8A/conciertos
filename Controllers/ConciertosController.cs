using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using conciertos.Models;
using conciertos.Data;

namespace conciertos.Controllers
{
    public class ConciertosController:Controller
    {
       private readonly ApplicationDbContext _context;

        public ConciertosController(ApplicationDbContext context){
            _context = context;
        } 
        public IActionResult Index()
        {
            return View(_context.DataConciertos.ToList());
        }
        public IActionResult Create(){
            return View();
        }
        [HttpPost]
        public IActionResult Create(Concierto objConciertos){
            
            _context.Add(objConciertos);
            _context.SaveChanges();
            ViewData["Message"] = "¡¡¡El concierto se registró exitosamente!!!";
            return View();
            
        }
        public IActionResult Delete(int id){

            Concierto objConciertos = _context.DataConciertos.Find(id);
            _context.Remove(objConciertos);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }


    }
}