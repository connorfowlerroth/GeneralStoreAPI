using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GeneralStoreAPI.Data;
using Microsoft.AspNetCore.Mvc;

namespace GeneralStoreAPI.Controllers
{
   [ApiController]
   [Route("[controller")]
    public class CustomerController : Controller 
    {
        private GenrealStoreDBContext _db;
        public CustomerController(GenrealStoreDBContext db) {
            _db = db;
        }
    }
}