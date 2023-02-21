namespace ConsoleApp
{
    public interface IDataReader
    {
        void ImportAndPrintData(string fileToImport, bool printData = true);
    }
}