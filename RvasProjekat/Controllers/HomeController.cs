﻿using RvasProjekat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace RvasProjekat.Controllers
{
    public class HomeController : Controller
    {


        private ApplicationDbContext _context;


        public HomeController()
        {
            
            _context = new ApplicationDbContext();
        }

        public ActionResult Index()
        {
            return View(_context.Aranzman.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}