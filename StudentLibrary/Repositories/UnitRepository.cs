using StudentLibrary.Interfaces.Repositories;
using StudentLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLibrary.Repositories
{
    public class UnitRepository:IUnitRepository
    {
        public IRepository<Document> documentRepository { get; set; }

        public UnitRepository(IRepository<Document> documentRepository)
        {
            this.documentRepository = documentRepository;
        }
    }
}
