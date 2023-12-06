using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gomoku
{
    internal class GameManager
    {
        private Board board = new Board();

        public PieceType currentPlayer = PieceType.BLACK;

        public bool CanBePlace(int cursorX, int cursorY)
        {
            return board.CanBePlace(cursorX, cursorY);
        }

        public Piece PlaceAPiece(int cursorX, int cursorY)
        {
            Piece piece = board.PlaceAPiece(cursorX, cursorY,currentPlayer);
            if (piece != null)
            {
                if (currentPlayer == PieceType.BLACK) 
                    currentPlayer = PieceType.WHITE; //換色
                else if (currentPlayer == PieceType.WHITE) 
                    currentPlayer = PieceType.BLACK;//換色
                return piece;
            }
            else 
                return null;
        }

        
        public PieceType CheckWinner(int x,int y)
        {
            return board.ConnectCheck(x,y);
        }
        /*
        public void CleanBoard()
        {
            board.CleanBoard();
        }
        */
    }
}
