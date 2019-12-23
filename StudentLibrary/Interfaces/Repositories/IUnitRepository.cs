using StudentLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLibrary.Interfaces.Repositories
{
    public interface IUnitRepository
    {
        IRepository<Document> documentRepository { get; set; }
    }
}
