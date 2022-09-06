using ForumApi.DAL.Interfaces;
using ForumApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumApi.DAL.Repositories
{
    public class SubjectRepository : ISubjectRepository
    {
        private readonly ApplicationDbContext _db;

        public SubjectRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public void Create(Subject entity)
        {
            _db.Subjects.Add(entity);
            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Subject Edit(int id, Subject entity)
        {
            throw new NotImplementedException();
        }

        public Subject Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Subject> Select()
        {
            return _db.Subjects.ToList();
        }
    }
}
