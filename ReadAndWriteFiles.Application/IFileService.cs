namespace ReadAndWriteFiles.Application
{
    public interface IFileService
    {
        public void CreateAndReadInFile(int numberRows, string rootPath);
    }
}
