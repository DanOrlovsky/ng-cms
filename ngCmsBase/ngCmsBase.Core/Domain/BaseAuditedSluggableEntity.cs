using System;
using System.Collections.Generic;
using System.Text;

namespace ngCmsBase.Core.Domain
{
    public class BaseAuditedSluggableEntity<T> : BaseEntity<T>, IAudited, ISluggable
    {
        public DateTime CreationTime { get; set; }
        public DateTime LastModifiedTime { get; set; }
        public DateTime DeletionTime { get; set; }
        public long CreatedBy { get; set; }
        public long LastModifiedBy { get; set; }
        public long DeletedBy { get; set; }
        public string UrlSlug { get; set; }
    }
}
