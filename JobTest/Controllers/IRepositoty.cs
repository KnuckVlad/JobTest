using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobTest.Controllers
{
    interface IRepositoty<T> : IDisposable
        where T : class
    {
        IEnumerable<T> GetDocumentList();
        T GetDocument(int id);
        void Create(T item);
        void Post(T item);
        void Delete(int id);
    }
}
