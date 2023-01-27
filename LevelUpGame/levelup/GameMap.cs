using System.Drawing;

namespace levelup
{
    public class GameMap
    {
        //public Point currentPosition = new Point(0,0);

        public GameMap()
        {
            
        }

        public Point calculatePosition(Point currentPosition, GameController.DIRECTION direction)
        {
            if (GameController.DIRECTION.NORTH == direction)
            {
                currentPosition.Y += 1;
            }
            else if (GameController.DIRECTION.SOUTH == direction)
            {
                currentPosition.Y -= 1;
            }
            else if (GameController.DIRECTION.WEST == direction)
            {
                currentPosition.X -= 1;
            }
            else if (GameController.DIRECTION.EAST == direction)
            {
                currentPosition.X += 1;
            }
            return currentPosition;

        }
    }
}