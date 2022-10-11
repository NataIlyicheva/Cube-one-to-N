void GetNumber (int Number)
{
    Console.WriteLine($" {Number} - ");
    for (int i = 1; i <= Number; i++)

        {
            double cube = Math.Pow(i, 3);
            Console.WriteLine($"{cube}. ");
        }
}

Console.WriteLine("Введите число: ");
int Number = int.Parse(Console.ReadLine()!);
GetNumber(Number);