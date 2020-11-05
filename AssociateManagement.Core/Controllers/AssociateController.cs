using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging; 

using AssociateManagement.Services;
using AssociateManagement.Models.AssociateInfo;

namespace AssociateManagement.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class AssociateController : ControllerBase
    {
        private readonly ILogger<AssociateController> _logger;
        private readonly IDatabaseService<Associate> _dbService;

        public AssociateController(ILogger<AssociateController> logger, IDatabaseService<Associate> dbService)
        {
            _logger = logger;
            _dbService = dbService;
        }

        [HttpPost]
        public ActionResult<Associate> Create(Associate inAssociate)
        {

            var associate = _dbService.Create(inAssociate);
            if(associate == null) {
                return Conflict();
            }
            return associate;
            
        }

        [HttpGet]
        public ActionResult<List<Associate>> Get()
        {
            return _dbService.Get();
        }

    }
}