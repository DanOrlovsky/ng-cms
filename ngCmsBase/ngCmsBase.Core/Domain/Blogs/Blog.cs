using System;
using System.Collections.Generic;
using System.Text;

namespace ngCmsBase.Core.Domain.Blogs
{
    public class Blog : BaseAuditedSluggableEntity<long>
    {
        public string Title { get; set; }

        public string Body { get; set; }
    }
}
