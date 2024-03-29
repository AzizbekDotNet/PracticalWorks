// 3 - topshiriq
// 1-masala
Console.Write("1-sonni kiriting: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("2-sonni kiriting: ");
int b = Convert.ToInt32(Console.ReadLine());
int sum = 0,A,B;
B = a>b?a:b;
A = a<b?a:b;
while (A < B)
{
	if (A % 2 != 0)
	{
		sum += A;
	}
	A++;
}
Console.WriteLine($"{a}; {b} oralig'ida bolgan toq sonlar yig'indisi: {sum}");


// 2-masala
Console.Write("Probel bilan sonlarni kiriting: ");
string[] Str = Console.ReadLine().Split();
int[] list = new int[Str.Length];
for (int i = 0; i < Str.Length; i++)
{
	list[i] = Convert.ToInt32(Str[i]);
}
int max = list[0], min = list[0];
for (int i = 0; i < list.Length; i++)
{
	if (list[i] > max)
	{
		max = list[i];
	}
	if (list[i] < min)
	{
		min = list[i];
	}
}
Console.WriteLine($"max = {max} min = {min}");
Console.WriteLine($"{max} * {min} = {max * min}");


// 3-masala
Console.Write("Son kiritng: ");
int n = Convert.ToInt32(Console.ReadLine());
int faktarial = 1;
for (int i = 1; i <= n; i++)
{
	faktarial *= i;
}
Console.WriteLine($"n! = {faktarial}");


