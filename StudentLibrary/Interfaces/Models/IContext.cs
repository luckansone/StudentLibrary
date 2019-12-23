using StudentLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLibrary.Interfaces.Models
{
    public interface IContext
    {
        DbSet<Document> Documents { get; set; }
        void SaveChanges();
    }
}
