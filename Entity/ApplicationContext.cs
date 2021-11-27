using DataModel;
using DataModel.DataModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
  public class ApplicationContext:DbContext 
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }
        public DbSet<StudentDetails> StudentDetails { get; set; }
        public DbSet<Userdetails> Userdetails { get; set; }
    }
}
