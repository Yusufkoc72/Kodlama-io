using Kodlama_io.Business.Concretes;
using Kodlama_io.DataAccess.Concretes;
using Kodlama_io.Entities;

Category category1 = new Category();
category1.Id = 1;
category1.CategoryName = "yazılım";

Category category2 = new Category();
category2.Id = 2;
category2.CategoryName = "Donanım";


CategoryManager categoryManager = new CategoryManager(new CategoryDal());
categoryManager.Add(category1);
categoryManager.Add(category2);
categoryManager.Delete(category2);


List<Category> categoryList = categoryManager.GetAll();

foreach (var category in categoryList)
{
    Console.WriteLine(category.CategoryName);
}


Course course1 = new Course();
course1.Description = "güzel bir kurs";
course1.ProgressBar = 1;
course1.Id = 1;
course1.CategoryId = 1;
course1.CourseImage = "course.png";
course1.CourseName = "donanım";
course1.CoursePrice = 0;

Course updatecourse1 = new Course();
updatecourse1.Description = "idare bir kurs";
updatecourse1.ProgressBar = 1;
updatecourse1.Id = 1;
updatecourse1.CategoryId = 1;
updatecourse1.CourseImage = "course.png";
updatecourse1.CourseName = "donanım";
updatecourse1.CoursePrice = 0;

CourseManager courseManager = new CourseManager(new CourseDal());

courseManager.Add(course1);


List<Course> courseList = courseManager.GetAll();

foreach (var course in courseList)
{
    Console.WriteLine(course.Description);
}

courseManager.Update(updatecourse1);

foreach (var course in courseList)
{
    Console.WriteLine(course.Description);
}