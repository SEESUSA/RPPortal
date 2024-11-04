using Application.Features.Product.Queries;
using Domain.Entites;
using Infrastructure.Database;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.Entity;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        private readonly RPPDbContext _context;

        public ProductsController(RPPDbContext context)
        {
           _context = context;
        }

        [HttpGet]
        [Route("GetUsersAsync")]
        public  IActionResult GetUsers()
        {
            var result =  _context.Users.ToList();


            var users = new Users
            {

                FirstName = "muddasir",
                LastName = "irshad",
                Email = "muddasir@gmail.com",
                Password = "123456"
            };
            _context.Users.Add(users);
            _context.SaveChanges();

            return Ok();
        }
    }
}
