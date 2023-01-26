
using TechTalk.SpecFlow;
using System;
using NUnit.Framework;
using FluentAssertions;
using levelup;

namespace DotNetExample.Tests.Steps
{
    [Binding]
    public class MoveSteps
    {
        // private readonly ScenarioContext _scenarioContext;
        
        GameController testObj = new GameController();
int startX, startY, endX, endY;
GameController.DIRECTION direction;
Point currentPosition;

        private String characterName = "";

        public MoveSteps(ScenarioContext scenarioContext)
        {
            //   _scenarioContext = scenarioContext;
        }

        

           
    }
}