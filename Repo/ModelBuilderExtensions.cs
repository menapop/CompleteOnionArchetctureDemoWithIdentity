using System;
using System.Collections.Generic;
using System.Text;
using Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Repo
{
    public static class ModelBuilderExtensions
    {
        // data for first time 
        public static void seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(new Category { Id = 1, Name = "TVs" });
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole { Id = "2ff40bf0-8fcd-414d-ab0c-d8d9b967f6e2", Name = "Admin" },
                new IdentityRole { Id = "41be4058-c5dc-4431-b846-0e173fc9185e", Name = "User" });
        }
    }
}
