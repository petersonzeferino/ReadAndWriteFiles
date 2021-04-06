using ReadAndWriteFiles.Domain.Component;
using ReadAndWriteFiles.Domain.Entities.CSV;
using System;
using System.IO;

namespace ReadAndWriteFiles.Application.Services
{
    public class ExcelService : IExcelService
    {
        private readonly RequestEntity _entity = new RequestEntity();
        private readonly String _path;
        private readonly String _typeExcel = ".xlsx";        

        public ExcelService()
        {
            Random randomValue = new Random();
            _path = $"{Directory.GetCurrentDirectory()}\\MyFile_{DateTime.Now.ToString("yyyy-MM-dd_HH_mm_ss")}_{randomValue.Next()}";
        }

        public void WriteExcel()
        {
            ExcelComponent.WriteExcel(_entity.FactoryRequestEntity(), $"{_path}{_typeExcel}");
        }
    }
}
