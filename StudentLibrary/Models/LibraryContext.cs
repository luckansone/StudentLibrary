using StudentLibrary.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLibrary.Models
{
    public class LibraryContext: DbContext, IContext
    {
        public LibraryContext(): base("DevConnection")
        {

        }

        public DbSet<Document> Documents { get; set; }

        public void SaveChanges() => base.SaveChanges();
    }
}
