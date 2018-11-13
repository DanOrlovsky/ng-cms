using ngCmsBase.Core.Data;
using ngCmsBase.Core.Domain.Blogs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ngCmsBase.Service.Blogs
{
    public class BlogService : IngServiceBase
    {
        private readonly IRepository<Blog, long> _blogRepository;

        public BlogService(IRepository<Blog, long> blogRepository)
        {
            _blogRepository = blogRepository;
        }


        public async Task<Blog> GetBlogById(long id)
        {
            return await _blogRepository.GetByIdAsync(id);
        }
    }
}
