using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testdb.IService;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace testdb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenericController<T> : Controller where T : class 
    {
        private readonly IGenericService<T> _genericService;


        public GenericController(IGenericService<T> genericService)
        {
            _genericService = genericService;
        }


        // GET: api/<GenericController>
        [HttpGet]
        public List<T> Get()
        {
            return _genericService.GetAll();
        }

        // GET api/<GenericController>/5
        [HttpGet("{id}")]
        public T Get(int id)
        {
            return _genericService.GetById(id);
        }

        // POST api/<GenericController>
        [HttpPost]
        public void Post([FromBody] T obj) => _genericService.Insert(obj);

        // DELETE api/<GenericController>/5
        [HttpDelete("{id}")]
        public void Delete(object id) => _genericService.Delete(id);
    }
}
