namespace ChartsApi.Models
{
    public class DashboardWidget
    {
        //{
        //    public Position Position { get; set; }
        //    public WidgetSize Size { get; set; }
        //    public string ChartType { get; set; }
        //    public ChartData Data { get; set; }
        //}

        //public class Position
        //{
        //    public int Row { get; set; }
        //    public int Col { get; set; }
        //}

        //public class WidgetSize
        //{
        //    public int Rows { get; set; }
        //    public int Cols { get; set; }
        //}

        //public class ChartData
        //{
        //    public string[] Labels { get; set; }
        //    public Dataset[] Datasets { get; set; }
        //}

        //public class Dataset
        //{
        //    public int[] Data { get; set; }
        //    public string[] BackgroundColor { get; set; }
        //    public string Label { get; set; }
        //    public string BorderColor { get; set; } 
        //    public bool Fill { get; set; }
        //}

        public int Id { get; set; }
        public string ChartType { get; set; }
        public int PositionRow { get; set; }
        public int PositionCol { get; set; }
        public int SizeRows { get; set; }
        public int SizeCols { get; set; }
        public string[] Labels { get; set; }
        public string DatasetLabel { get; set; }
        public string[] DatasetData { get; set; }
        public string[] BackgroundColor { get; set; }
        public string BorderColor { get; set; }
        public bool? Fill { get; set; }

    }

}
