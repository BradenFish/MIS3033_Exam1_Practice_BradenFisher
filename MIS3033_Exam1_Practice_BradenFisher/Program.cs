// MIS 3033 002
// September 25, 2023
// Exam 1 practice
// Braden Fisher 113492081
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
******************************************************t


";

while (true)
{
    Console.WriteLine(menuStr);
    string userChoiceStr;
    Console.Write("Enter your option: ");
    userChoiceStr = Console.ReadLine();

    if (userChoiceStr == "1")
    {// add a new student

    }
    else if (userChoiceStr == "2")
    {// show all student

    }
    else if (userChoiceStr == "3")
    {// search all student by ID

    }
    else if (userChoiceStr == "4")
    {// edit one student

    }
    else if(userChoiceStr == "5")
    {// delete one student

    }
    else if (userChoiceStr == "6") 
    {// student with highest grade

    }
    else if (userChoiceStr == "7")
    {// average grade

    }
    else
    {
        Console.WriteLine("Thank you and goodbye!");
        break;
    }
}

