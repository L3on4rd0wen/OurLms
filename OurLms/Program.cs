using System;

Student student1 = new Student("Student", "student@student.school34.sch.id", "123student", "Student", "Math");
Teacher teacher1 = new Teacher("Teacher", "teacher@teacher.school34.sch.id", "teacher123", "Teacher", "Math Class");

Console.WriteLine("=== Displaying User Information ===");
// Calling the inherited method from the User base class
student1.DisplayInfo();
teacher1.DisplayInfo();

Console.WriteLine("=== Executing Class Functions ===");
// Calling the specific methods for Guru and Siswa
student1.GradeAssigment(teacher1);
teacher1.SubmitAssignment(student1);

class User
{
    public string Name; 
    public string Email; 
    public string Password; 
    public string Role;

    public User(string name, string email, string password, string role)
    {
        Name = name; Email = email; Password = password; Role = role;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name} \nEmail: {Email} \nRole: {Role}\n");
    }
}

class Teacher : User
{
    public string ClassName;
    public Teacher(string name, string email, string password, string role, string className) : base(name, email, password, role)
    { 
        ClassName = className;
    }

    public void SubmitAssignment(Student student)
    {
        Console.WriteLine($"{student.Name} has submitted the assignment");
    }
}

class Student : User
{
    public string Subject;
    public Student(string name, string email, string password, string role, string subject) : base(name, email, password, role)
    {
        Subject = subject;
    }

    public void GradeAssigment(Teacher teacher) 
    {
        Console.WriteLine($"{teacher.Name} has graded the assignment.");
    }
}