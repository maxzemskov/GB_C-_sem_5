Console.Clear();
Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
int sum = 0;

Random rand = new Random();
for (int i = 0; i < array.Length; i++)
   array[i] = rand.Next(); 


for (int i = 0; i < array.Length; i++)
{
	if (i % 2 != 0)
	sum = sum + array[i];
}
Console.WriteLine($"Массив[{string.Join(", ", array)}]");
Console.WriteLine($"Сумма элементов с нечетными индексами = {sum}"); 