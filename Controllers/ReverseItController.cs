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
    public class ReverseItController : ControllerBase
    {
        private readonly ReverseItService _reverseItService;

        public ReverseItController(ReverseItService reverseItService)
        {
            _reverseItService = reverseItService;
        }

        [HttpGet]
        [Route("Reverse/{enterToReverse}")]

        public string ReverseIt(string enterToReverse)
        {
            return _reverseItService.ReverseIt(enterToReverse);
        }

    }
}