using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ngCmsBase.Core.Domain.Authorization
{
    public class User : BaseEntity<long>
    {
        [StringLength(64)]
        public string UserName { get; set; }

        [StringLength(128)]
        public string Email { get; set; }

        [StringLength(64)]
        public string Name { get; set; }

        [StringLength(64)]
        public string Surname { get; set; }

        public string Password { get; set; }
    }
}
