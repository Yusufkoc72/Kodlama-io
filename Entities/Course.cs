﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama_io.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int InstructorId { get; set; }
        public string CourseName { get; set; }
        public double CoursePrice { get; set; }
        public string CourseImage { get; set; }
        public string Description { get; set; }
        public int ProgressBar { get; set; }
    }
}
