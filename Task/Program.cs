

string a;
Console.WriteLine("Enter a massive element: ");
a = Console.ReadLine();

string b;
Console.WriteLine("Enter a massive element: ");
b = Console.ReadLine();

string c;
Console.WriteLine("Enter a massive element: ");
c = Convert.ToString(Console.ReadLine());

string d;
Console.WriteLine("Enter a massive element: ");
d = Console.ReadLine();

string e;
Console.WriteLine("Enter a massive element: ");
e = Console.ReadLine();

Console.WriteLine("  ");
string[] array1 = new string[5] {a, b, c, d, e,};
string[] array2 = new string[array1.Length];
void SecondArrayWithIF(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
SecondArrayWithIF(array1, array2);
PrintArray(array2);