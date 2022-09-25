using ForumApi.DAL.Interfaces;
using ForumApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumApi.DAL.Repositories
{
    public class UploadedFileRepository : IUploadedFileRepository
    {
        private readonly ApplicationDbContext _db;
        public UploadedFileRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public void Create(UploadedFile entity)
        {
            _db.UploadedFiles.Add(entity);
            _db.SaveChanges();
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public UploadedFile Edit(string id, UploadedFile entity)
        {
            throw new NotImplementedException();
        }

        public UploadedFile Get(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UploadedFile> Select()
        {
            throw new NotImplementedException();
        }
    }
}
