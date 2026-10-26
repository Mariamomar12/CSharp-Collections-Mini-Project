using System;

public class StudentManager
{
    internal GenericRepository<Student> G;
    public StudentManager() 
    {
        G = new GenericRepository<Student>();
    }

    public void addStudent(Student student)
    {
        G.add(student);
    }

    public void removeStudent(Student student)
    {
        G.remove(student);
    }

    public void display()
    {
        foreach (Student student in G.list)
        {
            Console.WriteLine($"{student.Name}, {student.Id}, {student.Grade}");
        }
    }

    public void SuccessFilter(string message)
    {
        foreach (Student student in G.list)
        {
            if (student.Grade >= 50)
                Console.WriteLine(student);
        }
        Console.WriteLine(message);
    }

    public void FailureFilter(string message)
    {
        foreach(Student student in G.list)
        {
            if (student.Grade <= 50)
                Console.WriteLine(student);
        }
        Console.WriteLine(message);
    }

    public void GradeFilter(string message)
    {
        foreach(Student s in G.list)
        {
            if (s.Grade > 90)
                Console.WriteLine(s);
        }
        Console.WriteLine(message);
    }
}
