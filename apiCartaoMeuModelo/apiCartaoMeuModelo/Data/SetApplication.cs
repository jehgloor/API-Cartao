using apiCartaoMeuModelo.Model;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace apiCartaoMeuModelo.Data
{
    public class SetApplication : DbContext
    {
        public SetApplication(DbContextOptions<SetApplication> opt) : base(opt)
            { }
        
            public DbSet<Card> Cards { get; set; }
            public DbSet<Pessoa> Pessoa { get; set; }
        
    }
}
