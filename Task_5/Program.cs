Console.Clear();
Console.Write("Введите количество дней, когда Вася получал оценки: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];

int c = 0;
int d = 0;
int four = 0;
int three = 0;

for (int i = 0; i < array.Length; i++)
{
Console.Write("Введите элемент массива: ");
array[i] = Convert.ToInt32(Console.ReadLine());
}

for (int b = 0; b < array.Length; b++)
{
	if (array[b] % 2 == 0)
		four++;
	else

		three++;
	
}

int[] array4 = new int[four];
int[] array3 = new int[three];
for (int b = 0; b < array.Length; b++)
{
	if (array[b] % 2 == 0)
	{
	array4[c] = array[b];
	c++;	
	}
	else
	{
		array3[d] = array[b];
		d++;
	}
}

Console.WriteLine($"[{string.Join(", ", array3)}]");
Console.WriteLine($"[{string.Join(", ", array4)}]");
if (four >= three)
Console.WriteLine("Вася получит 4");
else
Console.WriteLine("Вася получит 3");