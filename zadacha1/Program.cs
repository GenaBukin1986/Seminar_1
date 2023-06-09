Console.Clear();
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
if (a == Convert.ToInt32(Math.Pow(b, 2)))
{
Console.WriteLine("Да");
} else {
Console.WriteLine("Нет");
}