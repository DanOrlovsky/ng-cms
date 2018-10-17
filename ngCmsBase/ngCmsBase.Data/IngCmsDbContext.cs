using Microsoft.EntityFrameworkCore;
using ngCmsBase.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace ngCmsBase.Data
{
    public interface IngCmsDbContext 
    {
        DbSet<TEntity> Set<TEntity, T>() where TEntity : BaseEntity<T>;

        int SaveChanges();

    }
}
