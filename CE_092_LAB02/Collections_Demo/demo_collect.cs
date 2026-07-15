List<int> num_list = [1, 2, 3, 4, 5];
Console.Write("List of numbers : ");
foreach (int num in num_list)
{
    Console.Write(num + "  ");
}

Console.WriteLine("\n\nDictionary");
Dictionary<int, string> dic = new Dictionary<int, string>();
dic.Add(1, "one");
dic.Add(2, "two");
dic.Add(3, "three");
dic.Add(4, "four");
dic.Add(5, "five");

Console.WriteLine("Int numbers with string : ");
foreach (KeyValuePair<int, string> pair in dic)
{
    Console.WriteLine(pair.Key + ": " + pair.Value);
}

Console.WriteLine("\n");
Stack<int> stk = new Stack<int>();
stk.Push(1);
stk.Push(2);
stk.Push(3);
stk.Push(4);
stk.Push(5);
stk.Push(6);
Console.Write("Stack Elements: ");
foreach (int s in stk)
{
    Console.Write(s + " ");
}
Console.WriteLine("\n\n");

Console.Write("Queue ELements : ");

Queue<int> queue = new Queue<int>();
queue.Enqueue(1);
queue.Enqueue(2);
queue.Enqueue(3);
queue.Enqueue(4);
queue.Enqueue(5);

foreach (int s in queue)
{
    Console.Write(s + " ");
}
Console.WriteLine("\n\n");
