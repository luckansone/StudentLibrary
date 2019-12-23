using StudentLibrary.Interfaces.Models;
using StudentLibrary.Interfaces.Repositories;
using StudentLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLibrary.Repositories
{
    public class DocumentRepository : IRepository<Document>
    {
        IContext context;
        public DocumentRepository(IContext context)
        {
            this.context = context;
        }

        public void Add(Document item)
        {
            context.Documents.Add(item);
            context.SaveChanges();
        }

        public void Delete(Document item)
        {
            context.Documents.Remove(item);
            context.SaveChanges();
        }

        public List<Document> GetAllItems()
        {
            return context.Documents.ToList();
        }

        public Document GetItemById(int Id)
        {
            return context.Documents.ToList().Find(x => x.Id == Id);
        }

        public void Update(Document newItem)
        {
            Document item = context.Documents.ToList().Find(x => x.Id == newItem.Id);

            context.Documents.Remove(item);
            context.SaveChanges();
            context.Documents.Add(item);
            context.SaveChanges();
        }

        public List<Document> SearchDoc(string searchString)
        {
            return context.Documents.ToList().FindAll(x => x.Title.Contains(searchString) || x.Author.Contains(searchString));
        }
    }
}
