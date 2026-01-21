List<int> points = new List<int> { 98, 78, 66, 23 };

foreach (int item in points)
{
    Console.WriteLine(item);
}

Console.WriteLine();
Console.WriteLine("Sum");
int sum = 0;
foreach (int item in points)
{
    sum += item;
}
Console.WriteLine(sum);
