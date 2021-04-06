using ReadAndWriteFiles.Domain.Component;
using ReadAndWriteFiles.Domain.Entities.CSV;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ReadAndWriteFiles.Application.Services
{
    public class CSVService : ICSVService
    {
        private readonly RequestEntity _entity = new RequestEntity();
        private readonly String _path;
        private readonly String _typeCSV = ".xlsx";

        public CSVService()
        {
            Random randomValue = new Random();
            _path = $"{Directory.GetCurrentDirectory()}\\MyFile_{DateTime.Now.ToString("yyyy-MM-dd_HH_mm_ss")}_{randomValue.Next()}";
        }

        public void CreateCSV(string path)
        {
            CSVComponent<RequestEntity>.WriteCSV(_entity.FactoryRequestEntity(), $"{_path}{_typeCSV}");
        }

        public IEnumerable<RequestEntity> ReadCSV(string path)
        {
            IEnumerable<RequestEntity> file = CSVComponent<RequestEntity>.ReadCSV($"{_path}{_typeCSV}");
            return file;
        }

    }
}
