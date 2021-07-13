using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class HavanLabsContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public HavanLabsContext() : base(@"Data Source=localhost\sqlexpress;Initial Catalog=HavanLabs;Integrated Security=True")
        {

        }
    }
}
