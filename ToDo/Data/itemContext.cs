using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ToDo.Models;

    public class itemContext : DbContext
    {
        public itemContext (DbContextOptions<itemContext> options)
            : base(options)
        {
        }

        public DbSet<ToDo.Models.item> item { get; set; }
    }
