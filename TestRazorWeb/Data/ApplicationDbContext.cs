﻿using Microsoft.EntityFrameworkCore;
using TestRazorWeb.Model;

namespace TestRazorWeb.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
        }
        public DbSet<Category> Category { get; set; }

    }
}
