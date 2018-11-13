using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ngCmsBase.Data;
using ngCmsBase.Service.Authorization;
using ngCmsBase.Service.Blogs;

namespace ngCmsBase.Web.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {

        private readonly UserService _userService;
        private readonly BlogService _blogService;

        public ValuesController(
            UserService userService,
            BlogService blogService)
        {
            _userService = userService;
            _blogService = blogService;
        }

        // GET api/values
        [HttpGet]
        public async Task<IEnumerable<string>> Get()
        {
            var users = await _userService.GetUsers();
            await _blogService.GetBlogById(1);
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
