using ReadAndWriteFiles.Component;
using ReadAndWriteFiles.Models;
using System;
using System.Collections.Generic;
using System.IO;

namespace ReadAndWriteFiles
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Random randomValue = new Random();
          
            string path = $"{Directory.GetCurrentDirectory()}\\MyFile_{DateTime.Now.ToString("yyyy-MM-dd_HH_mm_ss")}_{randomValue.Next()}";
            CreateCSV(path);
        }

        #region Excel

        private static void WriteExcel(string path)
        {
            string typeExcel = ".xlsx";
            ExcelComponent.WriteExcel(FactoryFileModel(), $"{path}{typeExcel}");
        }

        #endregion

        #region CSV

        private static void CreateCSV(string path)
        {
            string typeCSV = ".csv";
            CSVComponent<FileModel>.WriteCSV(FactoryFileModel(),$"{path}{typeCSV}");
        }

        private static IEnumerable<FileModel> ReadCSV(string path)
        {
            string typeCSV = ".csv";
            IEnumerable<FileModel> file = CSVComponent<FileModel>.ReadCSV($"{path}{typeCSV}");
            return file;
        }

        #endregion

        #region Factory

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

        #endregion

    }
}
