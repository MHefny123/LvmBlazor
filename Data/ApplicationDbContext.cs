using System;
using System.Collections.Generic;
using System.Text;
using BlazorLVM.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlazorLVM.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ToDo> ToDoList { get; set; }

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }
    }
}
