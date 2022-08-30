using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ConsoleApp.Models
{

    public class InputMan
    {
        private FileMan _fileMan;
        public InputMan(FileMan fileMan)
        {
            _fileMan = fileMan;
        }

        public void CustomerInfoPrompt()
        {
            List<string> customerInfo = new List<string>();
            Console.WriteLine("Provide Input: ");
            try
            {
                string input;
                while ((input = Console.ReadLine()) != null)
                {
                    customerInfo.Add(input);
                }

                _fileMan.WriteStringListToFile(customerInfo);


            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
            finally
            {
                // Console.WriteLine($"Value of _customerInfo: {customerInfo}");
            }
        }

    }

}
