//4.Develop a C# console application that simulates browser history using a Stack<string>.
//Provide the following menu options:
//Visit a new webpage, Go Back (pop the latest page), View current page, Display browsing history

int cnt = 1;
Stack<string> stk = new Stack<string>();
stk.Push($"Web Page {cnt}");

Console.WriteLine("Enter 1 to create new Webpage");
Console.WriteLine("Enter 2 to go back to previous one");
Console.WriteLine("Enter 3 to view current page");
Console.WriteLine("Enter 4 to see browsing history");
Console.WriteLine("Enter 5 to Close the browser");

int n = -1;

while (true)
{
    n = Convert.ToInt32(Console.ReadLine());

    switch (n)
    {
        case 1:
            {
                cnt++;
                stk.Push($"Web Page {cnt}");
                Console.WriteLine("New page added");
                break;
            }

        case 2:
            {
                if (stk.Count > 1)
                {
                    Console.WriteLine(stk.Pop() + " closed.");
                }
                else
                {
                    Console.WriteLine("Cannot go back. This is the first page.");
                }
                break;
            }

        case 3:
            {
                Console.WriteLine("Current Page : " + stk.Peek());
                break;
            }

        case 4:
            {
                Console.WriteLine("Browsing History:");

                foreach (string page in stk)
                {
                    Console.WriteLine(page);
                }
                break;
            }

        case 5:
            {
                Console.WriteLine("Browser Closed Successfully");
                return;
            }

        default:
            {
                Console.WriteLine("Invalid Choice");
                break;
            }
    }
}