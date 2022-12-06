Console.Clear();
Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
int sum = 0;

Random rand = new Random();
for (int i = 0; i < array.Length; i++)
   array[i] = rand.Next(100, 999); 

Console.WriteLine($"[{string.Join(", ", array)}]");

for (int i = 0; i < array.Length; i++)
    if ( array[i] % 2 == 0 )
    sum = sum + array[i];

Console.WriteLine(sum);