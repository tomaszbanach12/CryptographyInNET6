using System.Security.Cryptography;

Console.WriteLine("Random number demonstration in .NET");
Console.WriteLine("-----------------------------------");
Console.WriteLine();

for (int i = 0; i < 10; i++)
{
    var randomNumbers = RandomNumberGenerator.GetBytes(32);
    Console.WriteLine($"Random number {i}: {Convert.ToBase64String(randomNumbers)}");
}

Console.WriteLine();