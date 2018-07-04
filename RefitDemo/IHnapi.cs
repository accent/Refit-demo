namespace RefitDemo
{
    using Refit;
    using System.Collections.Generic;

    public interface IHnapi
    {
        [Get("/item/{id}")]
        Item GetItem(int id);

        [Get("/news?page={pageId}")]
        IEnumerable<Item> GetPage(int pageId);
    }
}
