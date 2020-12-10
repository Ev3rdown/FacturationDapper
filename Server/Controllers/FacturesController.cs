using Facturation.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;

namespace Facturation.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FacturesController : ControllerBase
    {
        private readonly ILogger<FacturesController> logger;
        private readonly IBusinessData data;

        public FacturesController(ILogger<FacturesController> logger)
        {
            this.logger = logger;
        }

        [HttpGet]
        public IEnumerable<Facture> Get()
        {
            return data.Factures;
        }

        [HttpGet("{reference}")]
        public ActionResult<Facture> Get(string reference)
        {
            var facture = data.Factures.Where(inv => inv.NumeroFacture == reference).FirstOrDefault();

            if (facture != null)
            {
                return facture;
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public ActionResult<Facture> Post([FromQuery] Facture newFacture)
        {
            if (ModelState.IsValid)
            {
                return Created($"factures/{newFacture.NumeroFacture}", newFacture);
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
