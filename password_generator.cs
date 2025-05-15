using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите длину пароля: ");
        int length = int.Parse(Console.ReadLine());
        
        string password = GeneratePassword(length);
        Console.WriteLine($"Сгенерированный пароль: {password}");
    }

    static string GeneratePassword(int length)
    {
        const string validChars = "abcdefghijklmnopqrstuvwxyz";
        Random random = new Random();
        char[] passwordChars = new char[length];

        for (int i = 0; i < length; i++)
        {
            passwordChars[i] = validChars[random.Next(validChars.Length)];
        }

        return new string(passwordChars);
    }
}
