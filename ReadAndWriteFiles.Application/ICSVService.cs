using ReadAndWriteFiles.Domain.Entities.CSV;
using System.Collections.Generic;

namespace ReadAndWriteFiles.Application
{
    public interface ICSVService
    {
        public void CreateCSV(string path);

        public IEnumerable<RequestEntity> ReadCSV(string path);
    }
}
