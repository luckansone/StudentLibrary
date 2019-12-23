using StudentLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLibrary.Interfaces.Services
{
    public interface IDocumentService
    {
        List<Document> GetAllDocuments();
        Document GetDocumentById(int Id);
        void Create(Document item);
        void Update(Document item);
        void Delete(Document item);
        List<Document> SearchDoc(string searchString);
    }
}
