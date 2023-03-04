using Crestapi.Models;

namespace Crestapi.Repo
{
    public class InMemory : IItems
    {
        private readonly List<Item> items = new()
       {
        new Item {Id =Guid.NewGuid(), Name = "some item", Price = 1234, CreateDate = DateTimeOffset.UtcNow},
        new Item {Id =Guid.NewGuid(), Name = "another item", Price = 56, CreateDate = DateTimeOffset.UtcNow},
        new Item {Id =Guid.NewGuid(), Name = "random item", Price = 0987, CreateDate = DateTimeOffset.UtcNow}
       };

        public IEnumerable<Item> GetItems()
        {
            return items;
        }
        public Item GetItem(Guid id)
        {
            return items.Where(item => item.Id == id).SingleOrDefault();

        }


    }

}
