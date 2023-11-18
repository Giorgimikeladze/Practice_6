

int numb;
Console.Write("Enter integer value: ");
bool is_parsed = Int32.TryParse(Console.ReadLine(), out numb);

if (is_parsed && numb >= 1)
{
    Console.Write($"Divisors of {numb} are: ");
    for (int i = 1; i <= numb; i++)
	{
       
        if (numb%i==0) {
            Console.Write($" {i} ");
        }
	}
}
else {
    Console.WriteLine("invlid value!!!");
}