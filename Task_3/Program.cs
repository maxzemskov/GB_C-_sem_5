Console.Clear();
Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
int upperBound = 100;
double ValueMax = 0;
double ValueMin = upperBound;
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
   array[i] = rand.NextDouble() * upperBound; 
for (int i = 0; i < array.Length; i++)
	if (array[i] > ValueMax)
	ValueMax = array[i];
for (int i = 0; i < array.Length; i++)
	if (array[i] < ValueMin)
	ValueMin = array[i];


Console.WriteLine($"Массив[{string.Join(", ", array)}]");
Console.WriteLine($"Максимальное значение = {ValueMax}");
Console.WriteLine($"Минимальное значение = {ValueMin}");

Console.WriteLine($"Разница между максимальным и минимальным значением = {ValueMax - ValueMin}");
