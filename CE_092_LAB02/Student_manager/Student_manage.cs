List<String> list = new List<String>();
Console.WriteLine("1 :- To Add Student");
Console.WriteLine("2 :- To Remove Student");
Console.WriteLine("3 :-  Display All Student");
Console.WriteLine("4 :- Search The Student By Name");
Console.WriteLine("5 :- Update An Existing Student");
Console.WriteLine("6 :- Exit the loop");
int n = 1;
do
{
    Console.WriteLine("Select Any Option:- ");
    n = Convert.ToInt32(Console.ReadLine());
    switch (n)
    {
        case 1:
            String na2;
            Console.WriteLine("Enter the student name");
            na2 = Console.ReadLine();
            list.Add(na2);
            break;
        case 2:
            String na3;
            Console.WriteLine("Enter the student name");
            na3 = Console.ReadLine();
            list.Remove(na3);
            break;
        case 3:
            Console.WriteLine("All Student List:-");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i] + " ");
            }
            break;
        case 4:
            String na4;
            Console.WriteLine("Enter the student name");
            na4 = Console.ReadLine();
            if (list.Contains(na4))
            {
                Console.WriteLine("Student " + na4 + "is in the Student List");
            }
            else
            {
                Console.WriteLine("Student " + na4 + "is not in the Student List");
            }
            break;
        case 5:
            String na;
            Console.WriteLine("Enter the Student name you want to update");
            na = Console.ReadLine();
            String na1;
            Console.WriteLine("Enter the student updated name ");
            na1 = Console.ReadLine();
            if (list.Contains(na))
            {
                list[list.IndexOf(na)] = na1;
            }
            else
            {
                Console.WriteLine(na + "Name not exits in the list");
            }
            break;
        case 6:
        default:
            break;
    }

} while (n != 6);
