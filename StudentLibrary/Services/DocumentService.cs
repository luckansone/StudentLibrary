using StudentLibrary.Interfaces.Repositories;
using StudentLibrary.Interfaces.Services;
using StudentLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLibrary.Services
{
    public class DocumentService:IDocumentService
    {
        IUnitRepository unitRepository;


        public DocumentService(IUnitRepository unitRepository)
        {
            this.unitRepository = unitRepository;
        }

        public List<Document> GetAllDocuments()
        {
            return unitRepository.documentRepository.GetAllItems();
        }

        public Document GetDocumentById(int Id)
        {
            return unitRepository.documentRepository.GetItemById(Id);
        }

        public void Create(Document item)
        {
            unitRepository.documentRepository.Add(item);
        }

        public void Update(Document item)
        {
            unitRepository.documentRepository.Update(item);
        }

        public void Delete(Document item)
        {
            unitRepository.documentRepository.Delete(item);
        }

        public List<Document> SearchDoc(string searchString)
        {
            return unitRepository.documentRepository.SearchDoc(searchString);
        }
    }
}
