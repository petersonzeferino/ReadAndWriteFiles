using ReadAndWriteFiles.Component;
using ReadAndWriteFiles.Models;
using System;
using System.Collections.Generic;

namespace ReadAndWriteFiles
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
        }

        private static void CreateCSV()
        {
            CreateCSV<FileModel>.WriteCSV(FactoryFileModel());
        }

        private static IEnumerable<FileModel> ReadCSV(string path)
        {
            IEnumerable<FileModel> file = CreateCSV<FileModel>.ReadCSV(path);
            return file;
        }

        private static List<FileModel> FactoryFileModel()
        {
            List<FileModel> list = new List<FileModel>();

            FileModel fileModelOne = new FileModel()
            {
                Nome = "Test One",
                Cpf = 12345678900,
                Telefone = "11234567",
                Celular = "912345678",
                Data = DateTime.Today.ToString()
            };

            FileModel fileModelTwo = new FileModel()
            {
                Nome = "Test Two",
                Cpf = 22345678900,
                Telefone = "21234567",
                Celular = "922345678",
                Data = DateTime.Today.ToString()
            };

            FileModel fileModelThree = new FileModel()
            {
                Nome = "Test Three",
                Cpf = 32345678900,
                Telefone = "31234567",
                Celular = "932345678",
                Data = DateTime.Today.ToString()
            };

            list.Add(fileModelOne);
            list.Add(fileModelTwo);
            list.Add(fileModelThree);

            return list;
        }
    }
}
