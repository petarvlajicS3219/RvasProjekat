using RvasProjekat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RvasProjekat.Controllers
{
    public class AranzmanController : Controller
    {

        private ApplicationDbContext _context;


        public AranzmanController()
        {

            _context = new ApplicationDbContext();
        }
        // GET: Aranzman/Detail/5
        public ActionResult Detail(int id)
        {
            return View(_context.Aranzman.SingleOrDefault(c => c.Id == id));
        }
    }
}