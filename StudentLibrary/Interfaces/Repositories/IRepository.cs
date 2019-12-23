using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLibrary.Interfaces.Repositories
{
    public interface IRepository<T>
    {
        List<T> GetAllItems();
        T GetItemById(int Id);
        void Add(T item);
        void Update(T newItem);

        void Delete(T item);

        List<T> SearchDoc(string searchString);
    }
}
