﻿using Kodlama_io.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama_io.Business.Abstracts
{
    public interface ICourseService
    {
        void Add(Course course);
        void Delete(Course course);
        void Update(Course course);
        List<Course> GetAll();
    }
}
