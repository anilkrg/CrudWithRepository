using CrudWithRepository.Models.Repository.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudWithRepository.Controllers
{
    public class ClientController : Controller
    {
        private readonly IClient clientservice;
        public ClientController(IClient clientservice)
        {
            this.clientservice = clientservice;
        }
        public IActionResult Index()
        {
            var results = clientservice.ClientList();
            return View(results);
        }
    }
}
