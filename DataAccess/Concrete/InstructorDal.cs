using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class InstructorDal : IInstructorDal
    {
        List<Instructor> _instructors;
        public InstructorDal()
        {
            _instructors = new List<Instructor>
            {
                new Instructor {Id = 1, Name = "Engin Demirog"},
                new Instructor {Id = 2, Name = "Bilal Kocadag"}
            };
        }
        public Instructor Get(int id)
        {
            return _instructors.First(i => i.Id == id);
        }

        public List<Instructor> GetAll()
        {
            return _instructors;
        }

        public void Add(Instructor entity)
        {
            _instructors.Add(entity);
        }

        public void Delete(Instructor entity)
        {
            var deletedEntity = _instructors.First(i => i.Id == entity.Id);
            _instructors.Remove(deletedEntity);
        }

        public void Update(Instructor entity)
        {
            var updatedEntity = _instructors.First(i => i.Id == entity.Id);
            updatedEntity.Id = entity.Id;
            updatedEntity.Name = entity.Name;

        }
    }
}
