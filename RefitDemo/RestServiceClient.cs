using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RefitDemo
{
    public class RestServiceClient
    {
        private IHnapi hnapi;

        public RestServiceClient()
        {
            this.hnapi = RestService.For<IHnapi>("http://node-hnapi.herokuapp.com/");
        }

        public async Task<Item> GetItem(int id)
        {
            return await this.hnapi.GetItem(id);
        }

        public async Task<IEnumerable<Item>> GetNewsList(int page)
        {
            return await this.hnapi.GetPage(page);
        }
    }
}
