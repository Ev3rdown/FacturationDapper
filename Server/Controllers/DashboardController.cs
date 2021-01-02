using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Facturation.Shared;
using Microsoft.Extensions.Logging;

namespace Facturation.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DashboardController : ControllerBase
    {
        private readonly ILogger<DashboardController> _logger;
        private readonly IBusinessData _data;
        public DashboardController(ILogger<DashboardController> logger, IBusinessData data)
        {
            _logger = logger;
            _data = data;
        }

        [HttpGet]
        public Dashboard Get()
        {
            Tuple<double, double> tup = _data.CalculerTotalAttenduEtReel(DateTime.Today.Month, DateTime.Today.Year);
            Dashboard dash = new Dashboard(tup.Item1,tup.Item2);
            return dash;
        }
    }
}
