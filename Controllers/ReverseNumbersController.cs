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
    public class ReverseNumbersController : ControllerBase
    {
        private readonly ReverseNumbersService _reverseNumbersService;

        public ReverseNumbersController(ReverseNumbersService reverseNumbersService)
        {
            _reverseNumbersService = reverseNumbersService;
        }

        [HttpGet]
        [Route("Reverse/{reverseNumbers}")]

        public string ReverseNumbers(string reverseNumbers)
        {
            return _reverseNumbersService.ReverseNumbers(reverseNumbers);
        }
    }
}