using System.Drawing;

namespace levelup
{
    public class GameMap
    {
        //public Point currentPosition = new Point(0,0);
        public int maxX;
        public int maxY;

        public GameMap()
        {
            this.maxX = 9;
            this.maxY = 9;
        }

        public Point calculatePosition(Point currentPosition, GameController.DIRECTION direction)
        {
            Point startingPosition = currentPosition;
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
            bool validation = this.validatePosition(currentPosition);
            if (validation == false)
            {
                currentPosition = startingPosition;
            }
            return currentPosition;

        }
        public bool validatePosition(Point currentPosition)
        {
            bool blret = true;
            if (currentPosition.X > maxX)
            {
                blret = false;
            }
            else if (currentPosition.Y > maxY)
            {
                blret = false;
            }
            else if (currentPosition.X < 0)
            {
                blret = false;
            }
            else if (currentPosition.Y < 0)
            {
                blret = false;
            }
            return blret;
        }
    }
}