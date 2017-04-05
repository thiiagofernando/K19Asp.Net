using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace K19.Models
{
    public class K19Context : DbContext
    {

        public DbSet<Editora> Editora { get; set; }
        public DbSet<Livro> Livro { get; set; }

        //public K19Context() : base("name=K19Context")
        //  {

        //    }

        //public System.Data.Entity.DbSet<K19.Models.Editora> Editoras { get; set; }
    }
}
