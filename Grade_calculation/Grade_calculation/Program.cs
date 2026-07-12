int[] marks = new int[5];

Console.WriteLine("Enter the marks of the student");
int n = marks.Length;
int total_marks = 0;

for (int i = 0; i < n; i++)
{
    Console.Write("Enter the marks of the Subject" + (i + 1) + " : ");
    int mark = Convert.ToInt32(Console.ReadLine());
    marks[i] = mark;
    total_marks += mark;
}

Console.WriteLine();

Console.WriteLine("Total marks obtained by the student is : " + total_marks);

double percentage = (double)total_marks / n;
Console.WriteLine("The percentage obtained by the student is : " + percentage);

if (percentage >= 90)
{
    Console.WriteLine("The grade obtained by the student is : " + 'A');
}
else if (percentage >= 80)
{
    Console.WriteLine("The grade obtained by the student is : " + 'B');
}
else if (percentage >= 70)
{
    Console.WriteLine("The grade obtained by the student is : " + 'C');
}
else if (percentage >= 60)
{
    Console.WriteLine("The grade obtained by the student is : " + 'D');
}
else
{
    Console.WriteLine("The grade obtained by the student is : " + 'F');
}