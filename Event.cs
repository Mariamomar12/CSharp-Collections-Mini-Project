using System;

public class ImportantEventArgs : EventArgs
{
    public string studentName {  get; }
    public double grade { get; }

    public ImportantEventArgs(string studentName, double grade)
    {
        this.studentName = studentName;
        this.grade = grade;
    }
}

public class ImportanatEvent
{
    public event EventHandler<ImportantEventArgs> important;

    private string studentName;
    private double grade;

    public string SName
    {
        get 
        {
            return studentName; 
        } 
        set
        {
            studentName = value;
        }
    }
    public double Grade
    {
        get
        {
            return grade;
        }
        set
        {
            this.grade = value;
        }
    }

    public virtual void OnImportantEvent()
    {
        important?.Invoke(this, new ImportantEventArgs(studentName, grade));
    }

    public void checkStudent (Student student)
    {
        studentName = student.Name;
        grade = student.Grade;

        if (grade >= 95)
            OnImportantEvent();
    }
}

public class ImportantNptification
{
    public void send(object sender ,ImportantEventArgs e)
    {
        Console.WriteLine($"Great {e.studentName} your grade is {e.grade}");
    }
}
