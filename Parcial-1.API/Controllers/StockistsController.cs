using Microsoft.AspNetCore.Mvc;
using Parcial_1.API.Data;

namespace Parcial_1.API.Controllers
{
    [ApiController]
    [Route("/api/stockists")]
    public class StockistsController : ControllerBase
    {
        private readonly DataContext dataContext;

        public StockistsController(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
    }
}
