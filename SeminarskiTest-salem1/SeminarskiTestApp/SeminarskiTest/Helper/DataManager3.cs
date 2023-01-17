namespace SeminarskiTest.Helper
{
    public class DataManager3
    {
        public static List<ChartModel3> GetData()
        {
            var r = new Random();
            return new List<ChartModel3>()
        {
            new ChartModel3 { Data = new List<int> { r.Next(1, 40) }, Label = "Data1", BackgroundColor = "#5491DA" },
            new ChartModel3 { Data = new List<int> { r.Next(1, 40) }, Label = "Data2", BackgroundColor = "#E74C3C" },
            new ChartModel3 { Data = new List<int> { r.Next(1, 40) }, Label = "Data3", BackgroundColor = "#82E0AA" },
            new ChartModel3 { Data = new List<int> { r.Next(1, 40) }, Label = "Data4", BackgroundColor = "#E5E7E9" }
        };
        }
    }
}

