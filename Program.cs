// See https://aka.ms/new-console-template for more information


using DBTest;
using Microsoft.EntityFrameworkCore;

using var dbContext = new DepartmentContext();


var cSharp = new Lecture("CSharp", "number1");
var java = new Lecture("Java", "number2");
var literature = new Lecture("Literature", "number3");


var student1 = new Student("Povilas", "Povilaitis", new DateTime(1990 - 01 - 01));
var student2 = new Student("Maryte", "Bulkyte", new DateTime(1995 - 03 - 15));
var student3 = new Student("Petras", "Petrauskas", new DateTime(1991 - 11 - 10));
var student6 = new Student("Domas", "Buba", new DateTime(1994 - 11 - 10));

//1 uzduotis
/*dbContext.AddRange(new Department
{
    Name = "Languages",
    Lectures = new List<Lecture> { literature },
    Students = new List<Student> { student3 }
},
new Department
{
    Name = "Technology",
    Lectures = new List<Lecture> { cSharp, java , literature },
    Students = new List<Student> { student1, student2, student6 }
});
dbContext.SaveChanges();*/


//2;3;4 uzduotys
/*var philo = new Lecture("Philosophy", "number4");
var student4 = new Student("Donatas", "Donatelo", new DateTime(2000 - 01 - 01));
var returnedDept = dbContext.Departments
    .Where(x => x.Name == "Technology")
    .Include(x => x.Students)
    .Include(x => x.Lectures)
    .First();

returnedDept.Students.Add(student4);
returnedDept.Lectures.Add(philo);
dbContext.Departments.Update(returnedDept);
dbContext.SaveChanges();*/

/*var latin = new Lecture("Latin", "number5");
var student5 = new Student("Kazimiera", "Prunckiene", new DateTime(1800 - 12 - 11));
var returnedDept = dbContext.Departments
    .Where(x => x.Name == "Languages")
    .Include(x => x.Students)
    .Include(x => x.Lectures)
    .First();

returnedDept.Students.Add(student5);
returnedDept.Lectures.Add(latin);
dbContext.Departments.Update(returnedDept);
dbContext.SaveChanges();*/

//5 uzduotis perkelti studenta
/*var langDept = dbContext.Departments
    .Where(x => x.Name == "Languages")
    .Include(x => x.Students)
    .Include(x => x.Lectures)
    .First();

foreach (var item in langDept.Students)
{
    if(item.Surname == "Prunckiene")
    {
        item.Department.Name = "Technology";
        break;
    }
}

dbContext.Departments.Update(langDept);
dbContext.SaveChanges();*/

//6;7;8 uzduotys
/*var deptLectures = dbContext.Departments
    .Include(x => x.Lectures).
    Include(x => x.Students).
    ToList();

foreach (var department in deptLectures)
{
    foreach (var student in department.Students)
    {
        Console.WriteLine($"Departamento {department.Name} studentai {student.Name}");
    }
    foreach (var lecture in department.Lectures)
    {
        Console.WriteLine($"Departamento {department.Name} paskaitos {lecture.Name}");
    }
}

var lecturesFromStudent = dbContext.Students
    .Include(x => x.Department)
    .ThenInclude(x => x.Lectures)
    .Where(x => x.Name == "Maryte")
    .ToList();

foreach (var stud in lecturesFromStudent)
{
    foreach (var lecture in stud.Department.Lectures)
    {
        Console.WriteLine(lecture.Name);
    }
}*/
