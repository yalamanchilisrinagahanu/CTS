using EntityFrameworkCore8.Data;
using EntityFrameworkCore8.Models;

AppDbContext db = new AppDbContext();

Department dept = new Department()
{
    DepartmentName = "IT"
};

db.Departments.Add(dept);
db.SaveChanges();

Student student = new Student()
{
    Name = "Rahul",
    Age = 22,
    DepartmentId = dept.DepartmentId
};

db.Students.Add(student);
db.SaveChanges();

Console.WriteLine("Record Inserted");
