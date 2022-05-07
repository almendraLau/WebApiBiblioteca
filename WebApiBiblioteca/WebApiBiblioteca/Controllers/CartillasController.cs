using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiBiblioteca.Context;
using WebApiBiblioteca.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiBiblioteca.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartillasController : ControllerBase
    {
        private readonly AppDbContext context;

        public CartillasController(AppDbContext context)
        {
            this.context = context;
        }
        // GET: api/<CartillasController>
        [HttpGet]
        public IEnumerable<Cartilla> Get()
        {
            return context.Cartilla.ToList();
        }

        // GET api/<CartillasController>/5
        [HttpGet("{id}")]
        public Cartilla Get(int id)
        {
            var cartilla = context.Cartilla.FirstOrDefault(c => c.nId == id);
            return cartilla;
        }

        // POST api/<CartillasController>
        [HttpPost]
        public ActionResult Post([FromBody] Cartilla cartilla)
        {
            try
            {
                context.Cartilla.Add(cartilla);
                context.SaveChanges();
                return Ok();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return BadRequest();
            }

        }

        // PUT api/<CartillasController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Cartilla cartilla)
        {
            try
            {
                if (cartilla.nId == id)
                {
                    context.Entry(cartilla).State = EntityState.Modified;
                    context.SaveChanges();
                    return Ok();
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return BadRequest();
            }

        }

        // DELETE api/<CartillasController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var cartilla = context.Cartilla.FirstOrDefault(c => c.nId == id);
            if (cartilla != null)
            {
                context.Cartilla.Remove(cartilla);
                context.SaveChanges();
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
