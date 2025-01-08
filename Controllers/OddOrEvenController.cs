using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FiveToSevenEndPoints.Services;
using Microsoft.AspNetCore.Mvc;

namespace FiveToSevenEndPoints.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OddOrEvenController : ControllerBase
    {
        private readonly OddOrEvenService _oddOrEvenService;

        public OddOrEvenController(OddOrEvenService oddOrEvenService)
        {
            _oddOrEvenService = oddOrEvenService;
        }
        
        [HttpGet]
        [Route("Check/{enterNumber}")]

        public string OddOrEven(int enterNumber)
        {
            return _oddOrEvenService.OddOrEven(enterNumber);
        }
    }
}