using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ConsoleApp.Models
{

    public class FileMan
    {
        private string _path;
        // resist the urge to bloat
        public FileMan() {}

        public FileMan(string path)
        {
            _path = path;
        }

        public void CreateDirIfNotExists()
        {
            // If the directory doesn't exist, then the file doesn't exist either
            try
            {
                var pathDir = Path.GetDirectoryName(_path);
                if (!Directory.Exists(pathDir))
                {
                    Directory.CreateDirectory(pathDir);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }

        public void CreateFileIfNotExists()
        {
            try
            {
                if (!File.Exists(_path))
                {
                    File.Create(_path);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }

        public void WriteStringListToFile(List<string> input)
        {
            try
            {
                using (var fs = new FileStream(_path, FileMode.Append))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        foreach (string item in input)
                        {
                            sw.WriteLine(item);
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
                // Console.WriteLine($"{sw}");
            }
        }


    }

}
