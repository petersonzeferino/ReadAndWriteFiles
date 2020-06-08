using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace ReadAndWriteFiles.Component
{
    public static class CSVComponent<T>
    {
        public static void WriteCSV(IList<T> records, string path = "")
        {
            using (var writer = new StreamWriter(path))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.Configuration.Delimiter = ";";
                csv.WriteRecords(records);
            }
        }

        public static IEnumerable<T> ReadCSV(string path)
        {
            using (var reader = new StreamReader(path))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                return csv.GetRecords<T>().ToArray();
            }
        }

    }
}
