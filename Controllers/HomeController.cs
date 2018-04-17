﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DependencyInjection.Infrastructure;
using DependencyInjection.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DependencyInjection.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(IRepository repo)
        {
            repository = repo;
        }
        private IRepository repository;// { get; } = TypeBroker.Repository;
        // GET: /<controller>/
        public ViewResult Index()
        {            
            return View(repository.Products);
        }
    }
}