using Kodlama_io.Business.Abstracts;
using Kodlama_io.DataAccess.Abstracts;
using Kodlama_io.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama_io.Business.Concretes
{
    public class CourseManager : ICourseService
    {
        private readonly ICourseDal _courseDal;

        public CourseManager(ICourseDal CourseDal)
        {
            _courseDal = CourseDal;
        }

        public void Add(Course Course)
        {
            _courseDal.Add(Course);
        }

        public void Delete(Course Course)
        {
            _courseDal.Delete(Course);
        }

        public List<Course> GetAll()
        {
            return _courseDal.GetAll();
        }

        public void Update(Course Course)
        {
            _courseDal.Update(Course);
        }
    }
}
