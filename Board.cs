using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gomoku
{
    internal class Board
    {
        private static readonly Point NO_MATCH_NODE = new Point(-1, -1);
        private static readonly int NODE_COUNT = 9;

        private Piece[,] piecesArr = new Piece[9, 9];

        private static readonly int BOUNDARY = 75;
        private static readonly int NODE_RADIUS = 10;
        private static readonly int NODE_DISTANACE = 75;

        public PieceType GetPieceType(int nodeIdX, int nodeIdY)
        {
            if (piecesArr[nodeIdX, nodeIdY] == null)
                return PieceType.NONE;
            else
                return piecesArr[nodeIdX, nodeIdY].GetPieceType();
        }

        public bool CanBePlace(int cursorX, int cursorY)
        {
            //ToDo: 計算滑鼠離哪個交叉點比較近
            Point nodeId = FindTheCloseNode(cursorX, cursorY);
            //TODO: 如果否，回傳false
            if (nodeId == NO_MATCH_NODE)
                return false;
            if (piecesArr[nodeId.X, nodeId.Y] != null)
                return false;
            else
                return true;
            //ToDo: 判斷該點上有沒有棋子，
            //TODO: 如果是，回傳false
            //ToDo: 如果否，回傳交叉點座標並生成棋子
        }
        public Piece PlaceAPiece(int cursorX, int cursorY, PieceType type)
        {
            Point nodeId = FindTheCloseNode(cursorX, cursorY);

            if (nodeId == NO_MATCH_NODE)
                return null;
            if (piecesArr[nodeId.X,nodeId.Y] != null)
                return null;

            Point formPos = ConverToFormPosition(nodeId);
            if (type == PieceType.BLACK)
            {
                piecesArr[nodeId.X, nodeId.Y] = new Black_Piece(formPos.X, formPos.Y);
            }
            else if (type == PieceType.WHITE)
            {
                piecesArr[nodeId.X, nodeId.Y] = new White_Piece(formPos.X, formPos.Y);
            }
            return piecesArr[nodeId.X, nodeId.Y];

        }
        private Point ConverToFormPosition(Point nodeId)
        {
            Point formPosition = new Point();
            formPosition.X = BOUNDARY + nodeId.X * NODE_DISTANACE;
            formPosition.Y = BOUNDARY + nodeId.Y * NODE_DISTANACE;
            return formPosition;
        }

        private Point FindTheCloseNode(int x, int y)
        {
            int nodeIdX = FindTheCloseNode(x);
            int nodeIdY = FindTheCloseNode(y);
            if (nodeIdX == -1 || nodeIdX >= NODE_COUNT)
            {
                return NO_MATCH_NODE;
            }
            if (nodeIdY == -1 || nodeIdY >= NODE_COUNT)
            {
                return NO_MATCH_NODE;
            }
            return new Point(nodeIdX, nodeIdY);
        }
        private int FindTheCloseNode(int pos)
        {
            //ToDo: 取得各項距離數據 e.g. 視窗邊界到棋盤邊界的距離、每條線的距離
            if (pos < BOUNDARY - NODE_RADIUS)
            {
                return -1;
            }

            pos -= BOUNDARY;
            int quotient = pos / NODE_DISTANACE;
            int remainder = pos % NODE_DISTANACE;

            if (remainder <= NODE_RADIUS)
            {
                return quotient;
            }
            else if (remainder >= NODE_DISTANACE - NODE_RADIUS)
            {
                return quotient + 1;
            }
            else
            {
                return -1;
            }
        }
    }
}
