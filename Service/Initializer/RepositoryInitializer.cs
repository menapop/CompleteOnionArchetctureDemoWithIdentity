using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using Repo.Repository.CategoryRepository;
using Repo.shared;
using Repo.UnitOfWork;

namespace Service.Initializer
{
    public class RepositoryInitializer
    {
        public RepositoryInitializer(IServiceCollection services)
        {
            services.AddTransient<ICategoryRepository, CategoryRepository>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
        }
    }
}
