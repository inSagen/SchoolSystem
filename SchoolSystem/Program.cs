// See https://aka.ms/new-console-template for more information


public class School
{
    public string SchoolName { get; set; }
    public List<Classroom> Classrooms { get; set; } = new List<Classroom>();
    public List<Teacher> Teachers { get; set; } = new List<Teacher>();
    public List<Staff> StaffMembers { get; set; } = new List<Staff>();
}

public class Classroom
{ 
    public string ClassroomName { get; set; }
    public Teacher ClassTeacher { get; set; }
    public List<Student> Students { get; set; } = new List<Student>();
}    

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int Gender { get; set; }
}

public class Student : Person
{
    public string lvl { get; set; } // В каком классе учится (5А, 6В ...)
}

public class Teacher : Person
{
    public string Subject { get; set; }
}

public class Staff : Person
{
    public string JobName { get; set; }  
}