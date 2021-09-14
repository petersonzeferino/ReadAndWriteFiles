using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace ReadAndWriteFiles.Application.Services
{
    public class FileService : IFileService
    {
        public void CreateAndReadInFile(int numberRows = 1_000_000, string rootPath = @"C:\")
        {
            var fileName = GenerateFile(rootPath, numberRows);

            Console.WriteLine("##########");
            Console.WriteLine("Try to find a row in a large file");
            string path = Path.Combine(rootPath, fileName);

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            bool contains = File.ReadLines(path).Contains("91820988163");
            stopwatch.Stop();
            Console.WriteLine("Time elipsed to try find a value: {0}", stopwatch.ElapsedMilliseconds);
            Console.WriteLine($"Find something: {0}", contains);
        }

        private string GenerateFile(string rootPath, int numRows)
        {
            string filename = $"file_{numRows}_rows.txt";
            string path = Path.Combine(rootPath, filename);

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            string[] lista = new string[numRows];

            Random rnd = new Random();

            for (int i = 0; i < numRows; i++)
            {
                lista[i] = rnd.Next(1000).ToString();
            }

            File.WriteAllLines(path, lista);

            stopwatch.Stop();

            Console.WriteLine("Time elipsed to generate test file: {0}", stopwatch.ElapsedMilliseconds);

            return filename;
        }
    }
}