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
    public class MadLibController : ControllerBase
    {
        private readonly MadLibService _madLibService;
        
        public MadLibController(MadLibService madLibService)
        {
            _madLibService = madLibService;
        }

        [HttpGet]
        [Route("Adventure/{villageName}/{classType}/{characterAdj}/{characterName}/{questYear}/{theTreasureName}/{mentorName}/{companionName}/{villainName}/{keyEventLocation}")]

        public string MadLibGame(string villageName, string characterAdj, string classType, string characterName, string questYear, string theTreasureName, string mentorName, string companionName, string villainName, string keyEventLocation)
        {
            return _madLibService.MadLibGame(villageName, characterAdj, classType, characterName, questYear, theTreasureName, mentorName, companionName, villainName, keyEventLocation);
        }
    }
}