using System;
using System.Collections.Generic;
using System.Text;

namespace ngCmsBase.Core.Domain
{
    public interface ISluggable
    {
        string UrlSlug { get; set; }
    }
}
