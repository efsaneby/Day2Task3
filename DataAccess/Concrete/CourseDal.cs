using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class CourseDal : ICourseDal
    {
        List<Course> _courses;
        public CourseDal()
        {
            _courses = new List<Course>
            {
                new Course {Id = 1, Name = "C#", CategoryId = 1, InstructorId = 1},
                new Course {Id = 2, Name = "Java", CategoryId = 1, InstructorId = 1},
                new Course {Id = 3, Name = "Javascript", CategoryId = 2, InstructorId = 2},
                new Course {Id = 4, Name = "C++", CategoryId = 2, InstructorId = 2}
            };
        }
        public void Add(Course entity)
        {
            _courses.Add(entity);
        }

        public void Delete(Course entity)
        {
            var deletedEntity = _courses.First(c=>c.Id ==  entity.Id);
            _courses.Remove(deletedEntity);
        }

        public Course Get(int id)
        {
            return _courses.FirstOrDefault(c => c.Id == id);
        }

        public List<Course> GetAll()
        {
            return _courses;
        }

        public void Update(Course entity)
        {
            var updatedEntity = _courses.FirstOrDefault(c => c.Id == entity.Id);
            updatedEntity.Id = entity.Id;
            updatedEntity.Name = entity.Name;
            updatedEntity.InstructorId = entity.InstructorId;
            updatedEntity.CategoryId = entity.CategoryId;
        }
    }
}
