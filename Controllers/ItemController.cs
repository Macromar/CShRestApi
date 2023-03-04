using Microsoft.AspNetCore.Mvc;
using Crestapi.Repo;
using Crestapi.Models;

namespace Crestapi.Contreollers
{
    [ApiController]
    [Route("items")]
    public class ItemsController : ControllerBase{
        private readonly IItems itemsMem;
        public ItemsController(IItems itemsMem)
        {
            this.itemsMem= itemsMem; 
        }

        [HttpGet]
        public IEnumerable<Item> GetItems(){
            return itemsMem.GetItems();
        }

        [HttpGet("{Id}")]
        public ActionResult<Item> GetItem(Guid Id){
            var item = itemsMem.GetItem(Id);
            if (item is null)
            {
                return NotFound();
            }
            return Ok(item);

        }

    }
}