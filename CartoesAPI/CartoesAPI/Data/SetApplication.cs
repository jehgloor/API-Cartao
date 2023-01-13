using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CartoesAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace CartoesAPI.Data
{
    public class SetApplication : DbContext
    {
        public SetApplication(DbContextOptions<SetApplication> opt) : base(opt)
        { }

        public DbSet<Card> Cards { get; set; }
    }
}
