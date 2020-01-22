using PersonReader.CSV;

namespace PersonReader.CSV.Tests
{
    // TODO 7-2 :  Faire en sorte que la classe FakeFileLoader implémente l'interface ICSVFileLoader
    public class FakeFileLoader : ICSVFileLoader
    {
        private string dataType;

        public FakeFileLoader(string dataType)
        {
            this.dataType = dataType;
        }

        public string LoadFile()
        {
            switch (dataType)
            {
                case "Good": return TestData.WithGoodRecords;
                case "Mixed": return TestData.WithGoodAndBadRecords;
                case "Bad": return TestData.WithOnlyBadRecords;
                case "Empty": return string.Empty;
                default: return TestData.WithGoodRecords;
            }
        }
    }
}
