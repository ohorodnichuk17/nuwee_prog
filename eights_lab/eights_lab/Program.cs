using System.Text.RegularExpressions;

namespace eights_lab;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введіть текст для перевірки:");
        string inputText = Console.ReadLine();

        string ukrainianPattern = @"^[А-ЯІЇЄҐа-яіїєґ\s]+$";

        Regex regex = new Regex(ukrainianPattern);

        if (regex.IsMatch(inputText))
        {
            Console.WriteLine("Український текст.");
        }
        else
        {
            Console.WriteLine("Не український текст.");
        }
    }
}

