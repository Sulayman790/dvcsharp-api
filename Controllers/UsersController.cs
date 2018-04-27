using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dvcsharp_core_api.Models;
using dvcsharp_core_api.Data;

namespace dvcsharp_core_api
{
   [Route("api/[controller]")]
   public class UsersController : Controller
   {
      private readonly GenericDataContext _context;

      public UsersController(GenericDataContext context)
      {
         _context = context;
      }

      [HttpGet]
      public IEnumerable<User> Get()
      {
         return _context.Users.ToList();
      }
   }
}