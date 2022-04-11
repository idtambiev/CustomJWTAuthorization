using Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Context
{
    public class AppDbCOntext: DbContext
    {
        public DbSet<User> Users;


        public static void OnModelCreating (ModelBuilder modelBuilder)
        {

        }
    }
}
