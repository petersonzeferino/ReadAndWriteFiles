using ReadAndWriteFiles.Domain.Component;
using ReadAndWriteFiles.Domain.Entities.CSV;
using System.Collections.Generic;

namespace ReadAndWriteFiles.Application.Services
{
    public class CSVService : ICSVService
    {
        private readonly RequestEntity _entity = new RequestEntity();

        public void CreateCSV(string path)
        {
            CSVComponent<RequestEntity>.WriteCSV(_entity.FactoryRequestEntity(), path);
        }

        public IEnumerable<RequestEntity> ReadCSV(string path)
        {
            IEnumerable<RequestEntity> file = CSVComponent<RequestEntity>.ReadCSV(path);
            return file;
        }
    }
}
