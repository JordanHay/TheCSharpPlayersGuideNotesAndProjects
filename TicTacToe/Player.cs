using System;
namespace TicTacToe
{
    public class Player
    {
        public Position GetPosition(Board board)
        {
            int position = Convert.ToInt32(Console.ReadLine());
            Position desiredCoordinate = PositionForNumber(position);
            return desiredCoordinate;
        }

        private Position PositionForNumber(int position)
        {
            switch (position)
            {
                case 1: return new Position(2, 0); //bottom left
                case 2: return new Position(2, 1); //bottom middle
                case 3: return new Position(2, 2); //bottom right
                case 4: return new Position(1, 0); //middle left
                case 5: return new Position(1, 1); //middle middle
                case 6: return new Position(1, 2); //middle right
                case 7: return new Position(0, 0); //top left
                case 8: return new Position(0, 1); //top middle
                case 9: return new Position(0, 2); //top right
                default: return null;

            }
        }
    }
}
