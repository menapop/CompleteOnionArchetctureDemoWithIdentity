using System;
using System.Collections.Generic;
using System.Text;
using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Repo.shared;

namespace Repo.Repository.CategoryRepository
{
    public class CategoryRepository :  Repository<Category>,ICategoryRepository
    {
          
        public CategoryRepository(ApplicationContext context) : base(context)
        { 
          
        }
    }
}
