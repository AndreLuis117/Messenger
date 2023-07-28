using Messenger.Data.Repository;
using Messenger.Domain.Entities;
using Messenger.Domain.Interfaces.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.App
{
    public static class DependencyInjectionConfig
    {
        public static void ConfigureDependencies(IServiceCollection services)
        {
            services.AddScoped<IBaseRepository<BaseEntity>, BaseRepository<BaseEntity>>();
        }
    }
}
