using System;
using System.Collections.Generic;
using System.Text;

namespace ngCmsBase.Core.Domain.Authorization
{
    public class Role : BaseAuditedEntity<int>
    {
        public string RoleName { get; set; }
    }
}
