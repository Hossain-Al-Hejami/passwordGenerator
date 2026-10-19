using System.Security.Cryptography;

namespace passwordGenerator;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Secure Password Generator ===");
        Console.WriteLine();

        Console.Write("Password length ");
        int length = int.Parse(Console.ReadLine() ?? "16");

        Console.Write("Include uppercase? (y/n): ");
        bool useUppercase = Console.ReadLine()?.ToLower() == "y";

        Console.Write("Include lowercase? (y/n): ");
        bool useLowercase = Console.ReadLine()?.ToLower() == "y";

        Console.Write("Include numbers? (y/n): ");
        bool useNumbers = Console.ReadLine()?.ToLower() == "y";

        Console.Write("Include special chars? (y/n): ");
        bool useSpecialChars = Console.ReadLine()?.ToLower() == "y";

        Console.WriteLine();

        string password = GeneratePassword(
            length,
            useUppercase,
            useLowercase,
            useNumbers,
            useSpecialChars
        );

        Console.WriteLine($"Generated password: {password}");
    }

    static string GeneratePassword(
        int length,
        bool useUppercase,
        bool useLowercase,
        bool useNumbers,
        bool useSpecialChars
        )

    {
        string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string lowercase = "abcdefghijklmnopqrstuvwxyz";
        string numbers = "0123456789";
        string specialChars = "!@#$%^&*()-_=+[]{}<>?";
        string characterPool = "";

        if (useUppercase)
        {
            characterPool += uppercase;
        }
        if (useLowercase)
        {
            characterPool += lowercase;
        }
        if (useNumbers)
        {
            characterPool += numbers;
        }
        if (useSpecialChars)
        {
            characterPool += specialChars;
        }

        if (characterPool.Length == 0)
        {
            return "Error: Du måste välja minst en tecken.";
        }

        string password = "";

        for (int i = 0; i < length; i++)
        {
            int randomIndex = RandomNumberGenerator.GetInt32(characterPool.Length);

            password += characterPool[randomIndex];
        }

        return password;
    }
}
