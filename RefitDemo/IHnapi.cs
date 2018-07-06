namespace RefitDemo
{
    using Refit;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IHnapi
    {
        [Get("/item/{id}")]
        Task<Item> GetItem(int id);

        [Get("/news?page={pageId}")]
        Task<IEnumerable<Item>> GetPage(int pageId);
    }
}
