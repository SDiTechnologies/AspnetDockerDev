using System;
using System.Text;

namespace ConsoleApp;

public class Program
{
    public static void Main(string[] args)
    {
        string homeDir = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        string path = $"{homeDir}/Downloads/csharptest/test.txt";
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

        // solution using key prompt for input
        while(true)
        {
                string inputString;

                Console.WriteLine("Press <ESCAPE> to write customers to file and exit -or- Press <ANY KEY> to add a customer");
                ConsoleKeyInfo inputKey = Console.ReadKey();

                if (inputKey.Key == ConsoleKey.Escape)
                {
                    inputString = null;
                    break;
                }
                else
                {
                    Console.Write("Enter Customer Information: ");
                    inputString = Console.ReadLine();
                    customerList.Add(inputString);
                }
        }

        // // solution using string builder; works, kind of?
        // var stringBuilder = new StringBuilder();
        // while(true)
        // {
        //         string inputString;
        //         // while ((input = Console.ReadLine()) != null)
        //         // {
        //         //     customerList.Add(input);
        //         // }
        //         // // Works; Kind of...
        //         ConsoleKeyInfo inputKey = Console.ReadKey();

        //         if (inputKey.Key == ConsoleKey.Enter)
        //         {
        //             inputString = stringBuilder.ToString();
        //             customerList.Add(inputString);
        //             stringBuilder.Clear();
        //         }
        //         else if (inputKey.Key == ConsoleKey.Escape)
        //         {
        //             inputString = null;
        //             break;
        //         }
        //         else
        //         {
        //             stringBuilder.Append(inputKey.KeyChar);
        //         }
        // }

        try
        {

            // write to file
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

            // read from file and print
            using (var fileStream = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                using (var reader = new StreamReader(fileStream))
                {
                    while (!reader.EndOfStream)
                    {
                        Console.WriteLine(reader.ReadLine());
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
