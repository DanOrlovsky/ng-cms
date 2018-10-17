using System;
using System.Collections.Generic;
using System.Text;

namespace ngCmsBase.Core.Domain
{
    public interface IAudited
    {
        DateTime CreationTime { get; set; }

        DateTime LastModifiedTime { get; set; }

        DateTime DeletionTime { get; set; }

        long CreatedBy { get; set; }

        long LastModifiedBy { get; set; }

        long DeletedBy { get; set; }
    }
}
