using Crestapi.Models;

namespace Crestapi.Repo
{
    public interface IItems
    {
        Item GetItem(Guid id);
        IEnumerable<Item> GetItems();
    }
}