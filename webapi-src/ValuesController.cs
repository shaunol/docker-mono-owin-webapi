using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;

namespace OwinMonoSelfHostTest
{
    public class ValuesController : ApiController
    {
        // GET /values
        public async Task<IEnumerable<string>> Get()
        {
            var data = await Task.Run(() => new [] {"value1", "value2"});
            return data;
        }

        // GET /values/{id}
        public async Task<string> Get(int id)
        {
            var value = await Task.Run(() => "value");
            return value;
        }

        // POST /values 
        public async Task Post([FromBody]string value)
        {
            //
        }

        // PUT /values/{id} 
        public async Task Put(int id, [FromBody]string value)
        {
            //
        }

        // DELETE /values/{id} 
        public async Task Delete(int id)
        {
            //
        }
    } 
}
