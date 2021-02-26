using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SmsCoreApi.DAL.Interfaces;
using SmsCoreApi.Data;
using SmsCoreApi.Models;

namespace SmsCoreApi.DAL.Repositories
{
    public class SubjectRepositoy : ISubjectRepository
    {
        private readonly ApplicationDbContext _db;

        public SubjectRepositoy(ApplicationDbContext dbContext)
        {
            _db = dbContext;
        }

        public async Task<object> Delete(int id)
        {
            var subject = await _db.Subjects.FindAsync(id);
            if (subject != null)
            {
                _db.Subjects.Remove(subject);
                await _db.SaveChangesAsync();
                return subject;
            }
            return null;
        }

        public async Task<IEnumerable<Subject>> Get()
        {
            return await _db.Subjects.ToListAsync();

        }

        public async Task<Subject> Get(int id)
        {
            var subject = await _db.Subjects.FindAsync(id);
            return subject;
        }

        public async Task<object> Post(Subject entity)
        {
            if (_db.Subjects.Any(s => s.SubjectName == entity.SubjectName))
            {
                return null;
            }
            _db.Subjects.Add(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

        public async Task<object> Put(Subject entity)
        {
            _db.Entry(entity).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return entity;
        }

        public async Task<object> Put(int id, Subject entity)
        {
            var subject = _db.Subjects.Find(id);
            subject.SubjectName = entity.SubjectName;
            await _db.SaveChangesAsync();
            return entity;
        }

    }
}
