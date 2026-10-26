using System;

public class Student
{
	public int Id { get; set; }
	public string Name { get; set; }
	public double Grade { get; set; }

	public void IdSetter(int id)
	{
		if (id < 0)
            Console.WriteLine("Invalid ID!!");
		else
			Id = id;
	}

	public void gradeSetter(double grade)
	{
		if (grade < 0)
            Console.WriteLine("Invalid grade!!");
		else
			Grade = grade;
	}
	public Student(int id, string name, double grade)
	{
		IdSetter(id);
		Name = name;
		gradeSetter(grade);
	}

    public override string ToString()
    {
        return $"ID: {Id}, Name: {Name}, Grade: {Grade}";

	}
}
