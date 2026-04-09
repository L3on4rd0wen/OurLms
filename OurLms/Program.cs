class User
{
    public string Name; public string Email; public string Password; public string Role;

    public User(string name, string email, string password, string role)
    {
        Name = name; Email = email; Password = password; Role = role;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name} \nEmail: {Email} \nRole: {Role}\n");
    }
}

class Student : User
{
    public string ClassName;
    public Student(string name, string email, string password, string role, string className) : base(name, email, password, role) 
    { 
        ClassName = className;
    }

    public void SubmitAssignment(string assignment)
    {
        Console.WriteLine($"{Name} has submitted the assignment");
    }
}

class Teacher : User
{
    public string Subject;
    public Teacher(string name, string email, string password, string role, string subject) : base(name, email, password, role)
    {
        Subject = subject;
    }

    public void GradeAssigment() 
    {
        Console.WriteLine($"{Name} has graded the assignment.");
    }
}