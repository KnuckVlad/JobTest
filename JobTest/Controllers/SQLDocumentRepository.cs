using JobTest.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobTest.Controllers
{
    public class SQLDocumentRepository : IRepositoty<Document>
    {
        private ApplicationContext db;

        public SQLDocumentRepository()
        {
            this.db = new ApplicationContext();
        }

        public IEnumerable<Document> GetDocumentList()
        {
            return db.Documents;
        }

        public Document GetDocument(int id)
        {
            return db.Documents.Find(id);
        }

        public void Create(Document document)
        {
           db.Documents.Add(document);
        }

        public void Post(Document item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            Document document = db.Documents.Find(id);
            if (document != null)
                db.Documents.Remove(document);
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
            }
            this.disposed = true;
        }
    }
}
