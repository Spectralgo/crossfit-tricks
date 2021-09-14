using System;
using System.Linq;
using Beril_Server.Models;
using Microsoft.AspNetCore.Mvc;

namespace Beril_Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Tricks : ControllerBase
    {
        private readonly TrickyStore _store;

        public Tricks(TrickyStore store)
        {
            _store = store;
        }

        // /api/tricks 
        [HttpGet]
        public IActionResult All() => Ok(_store.All);

        [HttpGet("{id}")]
        public IActionResult Get(int id) => Ok(_store.All.FirstOrDefault(x => x.Id.Equals(id)));

        [HttpPost]
        public IActionResult Create([FromBody] Trick trick)
        {
            _store.Add(trick);
            return Ok();
        }
        
        
        [HttpPut]
        public IActionResult Update()
        {
            throw new NotImplementedException();
        }
        
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}