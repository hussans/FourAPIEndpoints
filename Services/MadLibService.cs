using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiveToSevenEndPoints.Services
{
    //In the ${inputs[0]} village, a ${inputs[1]} ${inputs[2]} named ${name} set out on a quest to find the ${inputs[4]}. After many trials, ${name} returned home victorious, bringing prosperity to the village.`;

    public class MadLibService
    {
        public string MadLibGame(string villageName, string characterAdj, string classType, string characterName, string questYear, string theTreasureName, string mentorName, string companionName, string villainName, string keyEventLocation)
        {
            string story = $"In the {villageName} village, a {characterAdj} {classType} named {characterName} set out on a quest in the year {questYear} to find the {theTreasureName}. Along the way, {characterName} was guided by their mentor, {mentorName}, and accompanied by their loyal companion, {companionName}. The journey was fraught with challenges, including a fierce battle with the villain, {villainName}, at {keyEventLocation}. After many trials, {characterName} returned home victorious, bringing prosperity to the village and ensuring that {villageName} would forever be remembered for this legendary tale.";

            return story;
        }
    }
}