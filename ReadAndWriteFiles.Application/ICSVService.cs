using ReadAndWriteFiles.Domain.Entities.CSV;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReadAndWriteFiles.Application
{
    public interface ICSVService
    {
        public void CreateCSV(string path);

        public IEnumerable<RequestEntity> ReadCSV(string path);
    }
}
