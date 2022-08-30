using System;
using System.Text;

namespace ConsoleApp;

public class Program
{
    public static void Main(string[] args)
    {
        string path = "/home/lusr/Downloads/csharptest/test.txt";
        var pathDir = Path.GetDirectoryName(path);
        var customerList = new List<string>();


        // create directory if not exists
        if (!Directory.Exists(pathDir))
        {
            Directory.CreateDirectory(pathDir);
        }

        // create file if not exists
        if (!File.Exists(path))
        {
            File.Create(path);
        }

        Console.WriteLine("Provide Input: <Press Escape Key To Exit>");


        var stringBuilder = new StringBuilder();

        while(true)
        {
                string inputString;
                // while ((input = Console.ReadLine()) != null)
                // {
                //     customerList.Add(input);
                // }
                // // Works; Kind of...
                ConsoleKeyInfo inputKey = Console.ReadKey();
                if (inputKey.Key == ConsoleKey.Enter)
                {
                    inputString = stringBuilder.ToString();
                    customerList.Add(inputString);
                    stringBuilder.Clear();
                }
                else if (inputKey.Key == ConsoleKey.Escape)
                {
                    inputString = null;
                    break;
                }
                else
                {
                    stringBuilder.Append(inputKey.KeyChar);
                }
        }

        try
        {
            using (var fileStream = new FileStream(path, FileMode.Append))
            {
                using (var writer = new StreamWriter(fileStream))
                {
                    foreach (string customer in customerList)
                    {
                        writer.WriteLine(customer);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Exception: {ex.Message}");
        }
        finally
        {
            Console.WriteLine($"Yay! Completion!");
        }

    }
}
