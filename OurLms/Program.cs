using System;

Student student1 = new Student("X", "X@gmail.com", "password123", "Student", "Math");
Teacher teacher1 = new Teacher("Y", "Y@gmail.com", "password456", "Teacher", "Class1");

Console.WriteLine("=== Displaying User Information ===");
// Calling the inherited method from the User base class
student1.DisplayInfo();
teacher1.DisplayInfo();

Console.WriteLine("=== Executing Class Functions ===");
// Calling the specific methods for Guru and Siswa
student1.GradeAssigment();
teacher1.SubmitAssignment();

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

    public void SubmitAssignment()
    {
        Console.WriteLine($"{Name} has submitted the assignment");
    }
}

class Student : User
{
    public string Subject;
    public Student(string name, string email, string password, string role, string subject) : base(name, email, password, role)
    {
        Subject = subject;
    }

    public void GradeAssigment() 
    {
        Console.WriteLine($"{Name} has graded the assignment.");
    }
}