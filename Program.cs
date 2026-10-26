using System.Security.Cryptography.X509Certificates;

namespace CollectionsGenericasDelegatesEvents_MiniProject
{
    internal class Program
    {
        public delegate void Notify(string m);
        static void Main(string[] args)
        {
            StudentManager studentManager = new StudentManager();
            ImportanatEvent e = new ImportanatEvent();
            ImportantNptification not = new ImportantNptification();

            e.important += not.send;

            bool input;
            do
            {

                Console.WriteLine("1-Add Student.");
                Console.WriteLine("2-Remove Student.");
                Console.WriteLine("3-Display Student.");
                Console.WriteLine("4-Filter Student.");
                Console.WriteLine("5-Exit.");

                Console.WriteLine("Please enter number between 1 and 5: ");

                int choise;
                input = int.TryParse(Console.ReadLine(), out choise);

                switch (choise)
                {
                    case 1:
                        Console.WriteLine("Please enter your name: ");
                        string name = Console.ReadLine();

                        Console.WriteLine("Please enter your id: ");
                        int id;
                        input = int.TryParse(Console.ReadLine(), out id);
                        foreach(Student st in studentManager.G.list)
                        {
                            while (id == st.Id)
                            {
                                Console.WriteLine("ID is already taken!!");
                                Console.WriteLine("Please enter your id: ");
                                input = int.TryParse(Console.ReadLine(), out id);
                            }
                        }

                        Console.WriteLine("Please enter your grade: ");
                        double grade = 0;
                        input = double.TryParse(Console.ReadLine(), out grade);

                        Student s = new Student(id, name, grade);
                        studentManager.addStudent(s);
                        e.checkStudent(s);

                        Console.WriteLine("Student was added successfully!!");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 2:
                        Console.WriteLine("Please enter your id: ");
                        int rID;
                        input = int.TryParse(Console.ReadLine(), out rID);
                        Student studentRemove = null;
                        foreach (var student in studentManager.G.list)
                        {
                            if (rID == student.Id)
                                studentRemove = student;
                        }
                        studentManager.removeStudent(studentRemove);

                        Console.WriteLine("Student was removed successfully!!");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        studentManager.display();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        Console.WriteLine("1- Sussess Filter.");
                        Console.WriteLine("2- Failure Filter.");
                        Console.WriteLine("3- Above 90 grade Filter.");
                        Console.WriteLine("================================");

                        Console.WriteLine("Please enter number between 1 and 3: ");
                        int num;
                        input = int.TryParse(Console.ReadLine(), out num);

                        if (num == 1)
                        {
                            Notify n = (m) => studentManager.SuccessFilter("Susseccful students.");
                            n(" ");
                        }
                        else if (num == 2)
                        {
                            Notify n = (m) => studentManager.FailureFilter("Failure students.");
                            n(" ");
                        }
                        else if (num == 3)
                        {
                            Notify n = (m) => studentManager.GradeFilter("Excllent students!");
                            n(" ");
                        }
                        else
                        {
                            Console.WriteLine("Invalid choise!");
                        }

                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Invalid choise!!");
                        break;
                }
            } while (input);
        }
    }
}
