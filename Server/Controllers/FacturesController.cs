using Facturation.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;

namespace Invoicing.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FacturesController : ControllerBase
    {
        private readonly ILogger<FacturesController> _logger;
        private readonly IBusinessData _data;

        public FacturesController(ILogger<FacturesController> logger, IBusinessData data)
        {
            _logger = logger;
            _data = data;
        }

        [HttpGet]
        public IEnumerable<Facture> Get()
        {
            return _data.Factures;
        }

        [HttpGet("{reference}")]
        public ActionResult<Facture> Get(string reference)
        {
            var invoice = _data.Factures.Where(inv => inv.NumeroFacture == reference).FirstOrDefault();

            if (invoice != null)
            {
                return invoice;
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
                // TODO : Ajouter la nouvelle facture à la collection
                return Created($"factures/{newFacture.NumeroFacture}", newFacture);
            }
            else
            {
                return BadRequest(ModelState.Values);
            }
        }
    }
}
