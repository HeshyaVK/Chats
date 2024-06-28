using ChartsApi.dbContext;
using ChartsApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChartsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DashboardConfigController : ControllerBase
    {

        private readonly DashboardContext _context;

        public DashboardConfigController(DashboardContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<DashboardWidget>> Get()
        {
            var widgets = _context.DashboardWidgets.ToList();
            return widgets;
        }
      
        //[HttpGet]
        //public ActionResult<IEnumerable<DashboardWidget>> Get()
        //{
        //    var config = new List<DashboardWidget>
        //    {
        //        new DashboardWidget
        //        {
        //            Position = new Position { Row = 0, Col = 0 },
        //            Size = new WidgetSize { Rows = 2, Cols = 3 },
        //            ChartType = "pie",
        //            Data = new ChartData
        //            {
        //                Labels = new[] { "A", "B", "C" },
        //                Datasets = new[]
        //                {
        //                    new Dataset
        //                    {
        //                        Data = new[] { 300, 50, 100 },
        //                        BackgroundColor = new[] { "#FF6384", "#36A2EB", "#FFCE56" }
        //                    }
        //                }
        //            }
        //        },
        //        new DashboardWidget
        //        {
        //            Position = new Position { Row = 0, Col = 9 },
        //            Size = new WidgetSize { Rows = 2, Cols = 3 },
        //            ChartType = "bar",
        //            Data = new ChartData
        //            {
        //                Labels = new[] { "January", "February", "March" },
        //                Datasets = new[]
        //                {
        //                    new Dataset
        //                    {
        //                        Label = "Sales",
        //                        Data = new[] { 65, 59, 80 },
        //                        BackgroundColor = new[] { "#FF6384", "#36A2EB", "#FFCE56" }
        //                    }
        //                }
        //            }
        //        },
        //        new DashboardWidget
        //        {
        //            Position = new Position { Row = 2, Col = 0 },
        //            Size = new WidgetSize { Rows = 2, Cols = 3 },
        //            ChartType = "line",
        //            Data = new ChartData
        //            {
        //                Labels = new[] { "January", "February", "March" },
        //                Datasets = new[]
        //                {
        //                    new Dataset
        //                    {
        //                        Label = "Performance",
        //                        Data = new[] { 65, 59, 80 },
        //                        BackgroundColor = new[] { "#FF6384", "#36A2EB", "#FFCE56" },
        //                        BorderColor = "#FF6384",
        //                        Fill = false
        //                    }
        //                }
        //            }
        //        }
        //    };

        //    return config;
        //}
    }
}
    
