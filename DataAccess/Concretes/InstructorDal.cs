﻿using Kodlama_io.DataAccess.Abstracts;
using Kodlama_io.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama_io.DataAccess.Concretes
{
    public class InstructorDal : IInstructorDal
    {
        List<Instructor> _instructors;
        public InstructorDal()
        {
            _instructors = new List<Instructor>();
        }
        public void Add(Instructor instructor)
        {
            _instructors.Add(instructor);
        }

        public void Delete(Instructor instructor)
        {
            _instructors.Remove(instructor);
        }

        public List<Instructor> GetAll()
        {
            return _instructors;
        }

        public void Update(Instructor instructor)
        {
            Instructor existInstructor = _instructors.Find(x => x.Id == instructor.Id);
            if (existInstructor is null)
                return;
            existInstructor.FirstName = instructor.FirstName;
            existInstructor.LastName = instructor.LastName;
            existInstructor.Image = instructor.Image;
            existInstructor.InstructorCv = instructor.InstructorCv;
        }
    }
}
