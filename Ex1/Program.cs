Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
string[] array = new string[n];
string[] newarray = new string[array.Length];
int c = 0;

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите элемент массива под индексом {i} ");
    array[i] = Console.ReadLine();
}
Console.WriteLine("Массив: ");
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}
Console.WriteLine();
Console.WriteLine("Массив из элементов <=3 ");



for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        newarray[c] = array[i];
        c++;
    }
}

for (int i = 0; i < newarray.Length; i++)
{
    Console.WriteLine($"{newarray[i]} ");
}
Console.WriteLine();
