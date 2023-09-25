// MIS 3033 002
// September 25, 2023
// Exam 1 practice
// Braden Fisher 113492081
using a;

Console.WriteLine("Exam 1 practice");

string menuStr = @"
******************************************************
Menu Options
1. Add one new student
2. Show all students
3. Search one student for given ID
4. Edit one student for given ID
5. Delete one student for given ID
6. Student with hgiest grade
7. Show the average grade
Press other keys to exit
******************************************************


";
StudentDB db;
db = new StudentDB();

while (true)
{
    Console.WriteLine(menuStr);
    string userChoiceStr;
    Console.Write("Enter your option: ");
    userChoiceStr = Console.ReadLine();

    if (userChoiceStr == "1")
    {// add a new student
        Console.WriteLine("ADd a new student");

        Console.Write("ID: ");
        string id = Console.ReadLine();// string

        Console.Write("Name: ");
        string nameStr = Console.ReadLine();

        Console.Write("Grade: ");
        string gradeStr = Console.ReadLine();
        double gradeDbl = Convert.ToDouble(gradeStr);

        Student stu;
        stu = new Student() {ID = id, name = nameStr, grade = gradeDbl };
        stu.GetGradeLevel();// get the grade level

        db.stuTbl.Add(stu);// in the computer memory
        db.SaveChanges();// persist

        Console.WriteLine(stu);
    }
    else if (userChoiceStr == "2")
    {// show all student
        Console.WriteLine("All students information: ");

        List<Student> stuList = db.stuTbl.ToList();
        for (int i = 0; i < stuList.Count; i++)
        {
            Console.WriteLine(stuList[i]);
        }
    }
    else if (userChoiceStr == "3")
    {// search all student by ID
        Console.WriteLine("Search for a student");
        Console.Write("ID: ");
        string id = Console.ReadLine();

        Student stu = db.stuTbl.Where(s => s.ID == id).FirstOrDefault();// where is collection

        if (stu == null)
        {
            Console.WriteLine($"Student {id} does not exist in the database!");
        }
        else
        {
            Console.WriteLine(stu);
        }
    }
    else if (userChoiceStr == "4")
    {// edit one student
        Console.WriteLine("Edit one student");
        Console.Write("ID: ");
        string id = Console.ReadLine();

        Student stu = db.stuTbl.Where(s => s.ID == id).FirstOrDefault();// where is collection

        if (stu == null)
        {
            Console.WriteLine($"Student {id} does not exist in the database!");
        }
        else
        {
            Console.WriteLine("The current infor is: ");
            Console.WriteLine(stu);

            Console.Write("New Name: ");
            string name = Console.ReadLine();

            Console.Write("New Grade: ");
            string gradeStr = Console.ReadLine();
            double gradeDbl = Convert.ToDouble(gradeStr);

            stu.name = name;
            stu.grade = gradeDbl;
            stu.GetGradeLevel();// computer memory

            db.SaveChanges();// persist
            Console.WriteLine("New Info is: ");
            Console.WriteLine(stu);
        }

    }
    else if(userChoiceStr == "5")
    {// delete one student
        Console.WriteLine("Delete one student");
        Console.Write("ID: ");
        string id = Console.ReadLine();

        Student stu = db.stuTbl.Where(s => s.ID == id).FirstOrDefault();// where is collection

        if (stu == null)
        {
            Console.WriteLine($"Student {id} does not exist in the database!");
        }
        else
        {
            db.stuTbl.Remove(stu);
            db.SaveChanges();// persist
            Console.WriteLine("Student deleted successfully");
            Console.WriteLine(stu);
        }
    }
    else if (userChoiceStr == "6") 
    {// student with highest grade
        Console.WriteLine("Student with the highest grade: ");

        Student stu = db.stuTbl.ToList().MaxBy(s => s.grade);
        Console.WriteLine(stu);
    }
    else if (userChoiceStr == "7")
    {// average grade
        Console.WriteLine("Average grade: ");
        double avgGrade = db.stuTbl.Average(s => s.grade);
        Console.WriteLine($"{avgGrade:F2}");
    }
    else
    {
        Console.WriteLine("Thank you and goodbye!");
        db.Dispose();// disconnect the database
        break;
    }
}

