using System.Drawing;

namespace levelup
{
    public class GameController
    {
        // TODO: If your stakeholder wants to call this CHARACTER, change var name for
        // low representational gap
        public readonly string DEFAULT_CHARACTER_NAME = "Character";

        public record struct GameStatus(
            // TODO: Add other status data
            String characterName,
            Point currentPosition,
            Int32 MoveCount
        );

        // TODO: Ensure this AND CLI commands match domain model
        public enum DIRECTION
        {
            NORTH, SOUTH, EAST, WEST
        }

        public GameStatus status = new GameStatus();

        public GameController()
        {
            status.characterName = DEFAULT_CHARACTER_NAME;
            status.currentPosition = new Point(-1,-1);
        }

        public void SetCharacterPosition(Point coordinates)
        {
            //TO DO

        }

        // Pre-implemented to demonstrate ATDD
        // TODO: Update this if it does not match your design
        public void CreateCharacter(String name)
        {
            if (name != null && !name.Equals(""))
            {
                this.status.characterName = name;
            }
            else
            {
                this.status.characterName = DEFAULT_CHARACTER_NAME;
            }
            charObj = new Character(this.status.characterName);  
            TestCharacterName = charObj.Name;                                
        }
        public string TestCharacterName;
        public Character charObj;
        

        public void StartGame()
        {
            // TODO: Implement startGame - Should probably create tiles and put the character
            // on them?
            // TODO: Should also update the game status?
        }

        public GameStatus GetStatus()
        {
            return charObj.GetStatus();
        }

        public void Move(DIRECTION directionToMove)
        {
            //TODO: Implement move - should call something on another class
            //TODO: Should probably also update the game status
        }




    }
}