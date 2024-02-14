using System;
using Bussiness.Concrete;
using Entities.Concrete;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Program started!\n");

List<Course> courses = new List<Course>();
CourseManager courseManager = new CourseManager(courses);
courseManager.Add(new Course { Id = 1, Name = "Yazılım Geliştirici Yetiştirme Kampı (C# + ANGULAR)", Price = 0, InstructorId = 1 });
courseManager.Add(new Course { Id = 2, Name = "Yazılım Geliştirici Yetiştirme Kampı (JAVA + REACT)", Price = 0, InstructorId = 2 });
courseManager.Add(new Course { Id = 3, Name = "Programlamaya Giriş İçin Temel Kurs", Price = 0, InstructorId = 3 });
courseManager.Add(new Course { Id = 4, Name = "Python", Price = 0, InstructorId = 4 });


List<Instructor> instructors = new List<Instructor>();
InstructorManager instructorManager = new InstructorManager(instructors);
instructorManager.Add(new Instructor { Id = 1, FirstName = "Engin", LastName = "Demiroğ", ImageUrl = "https://www.kodlama.io/wp-content/uploads/2021/04/engin-demirog.jpg" });


List<Category> categories = new List<Category>();
CategoryManager categoryManager = new CategoryManager(categories);
categoryManager.Add(new Category { Id = 1, Name = "Programlama" });
categoryManager.Add(new Category { Id = 2, Name = "Yazılım" });
categoryManager.Add(new Category { Id = 3, Name = "Frontend" });
categoryManager.Add(new Category { Id = 4, Name = "Backend" });


printCourses(); printCategories(); printInstructors();
Console.ReadLine();


// ------------------Functions------------------

void printCourses()
{
    Console.WriteLine("\nCourses:");
    foreach (var course in courseManager.GetAll())
    {
        Console.WriteLine($"Id: {course.Id} {course.Name} - Price: {course.Price} - Instructor: {instructorManager.GetById(course.InstructorId)?.FirstName} {instructorManager.GetById(course.InstructorId)?.LastName} - Category: {categoryManager.GetById(course.CategoryId)?.Name}");
    }
}

void printInstructors()
{
    Console.WriteLine("\nInstructors:");
    foreach (var instructor in instructorManager.GetAll())
    {
        Console.WriteLine("ID:" + instructor.Id + " - " + instructor.FirstName + " " + instructor.LastName);
    }
}

void printCategories()
{
    Console.WriteLine("\nCategories:");
    foreach (var category in categoryManager.GetAll())
    {
        Console.WriteLine($"Id: {category.Id} {category.Name}");
    }
}



