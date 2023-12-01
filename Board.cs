﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        //private Point currentNodeId;//當前的棋子點位座標

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

        private Point FindTheCloseNode(int x, int y)//取得nodeId的方法
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

        private int ConnectRangeConverter(int nodeId, ConnectRangeDirection direction)
        {
            //TODO:將點位編號丟進連線範圍轉換()進行可能連線的範圍上下限的取值，例如:x+-4，並且規定範圍在0~8之間
            switch (direction)
            {
                case ConnectRangeDirection.Max:
                    int nodeIdMax;
                    if (nodeId + 4 > 8)
                        nodeIdMax = 8;
                    else
                        nodeIdMax = nodeId + 4;
                    return nodeIdMax;

                case ConnectRangeDirection.Min:
                    int nodeIdMin;
                    if (nodeId - 4 < 0)
                        nodeIdMin = 0;
                    else
                        nodeIdMin = nodeId - 4;
                    return nodeIdMin;
            }
            return -1;
        }

        public void ConnectCheck(int cursorX, int cursorY)//輸入當前棋子位於棋盤矩陣的編號
        {
            ConnectCheck(cursorX,cursorY, Direction.Horizontal);
            ConnectCheck(cursorX, cursorY, Direction.Vertical);
            //ConnectCheck(cursorX, cursorY, Direction.Backslash);
            //ConnectCheck(cursorX, cursorY, Direction.Slash);
        }

        private void ConnectCheck(int cursorX, int cursorY, Direction direction)
        {
            bool bugLogSwitch = false;
            //方法
            int connectCounter = 0;
            bool disconnectChecker = true;
            //TODO:取得點擊當下的棋盤座標轉換成棋子的點位座標(pieceArr[x,y])
            Point currentPiece = FindTheCloseNode(cursorX, cursorY);

            int nodeIdXBegin;//檢測棋子的起始X座標
            int nodeIdYBegin;//檢測棋子的起始Y座標
            int nodeIdXEnd;//被測棋子的終點X座標
            int nodeIdYEnd;//被測棋子的終點Y座標
            int nextX;//檢測棋子的下一個X座標加減
            int nextY;//檢測棋子的下一個Y座標加減
            //Point PiecesForComparison;
            //Point PiecesToBeCompared;

            
            switch(direction)
            {
                case Direction.Horizontal:
                    //TODO:將點位編號丟進連線範圍轉換()進行可能連線的範圍上下限的取值，例如:x+-4，並且規定範圍在0~8之間
                    nodeIdXBegin = ConnectRangeConverter(currentPiece.X, ConnectRangeDirection.Min);
                    nodeIdYBegin = currentPiece.Y;
                    nodeIdXEnd = ConnectRangeConverter(currentPiece.X, ConnectRangeDirection.Max);
                    nodeIdYEnd = currentPiece.Y;
                    nextX = 1;
                    nextY = 0;
                    break;

                case Direction.Vertical:
                    nodeIdXBegin = currentPiece.X;
                    nodeIdYBegin = ConnectRangeConverter(currentPiece.Y, ConnectRangeDirection.Min);
                    nodeIdXEnd = currentPiece.X;
                    nodeIdYEnd = ConnectRangeConverter(currentPiece.Y, ConnectRangeDirection.Max);
                    nextX = 0;
                    nextY = 1;
                    break;

                /*case Direction.Backslash:
                    if (ConnectRangeConverter(currentPiece.X, ConnectRangeDirection.Min) <= ConnectRangeConverter(currentPiece.Y, ConnectRangeDirection.Min))
                    {
                        nodeIdXBegin = ConnectRangeConverter(currentPiece.X, ConnectRangeDirection.Min);
                        currentPieceXorY = currentPiece.X;
                    }
                    else
                    {
                        nodeIdXBegin = ConnectRangeConverter(currentPiece.Y, ConnectRangeDirection.Min);
                        currentPieceXorY = currentPiece.Y;
                    }
                    if (ConnectRangeConverter(currentPiece.X, ConnectRangeDirection.Max) >= ConnectRangeConverter(currentPiece.Y, ConnectRangeDirection.Max))
                    {
                        nodeIdMax = ConnectRangeConverter(currentPiece.X, ConnectRangeDirection.Max);
                    }
                    else
                    {
                        nodeIdMax = ConnectRangeConverter(currentPiece.Y, ConnectRangeDirection.Max);
                    }
                    nextY = 1;
                    break;

                case Direction.Slash:
                    if (ConnectRangeConverter(currentPiece.X, ConnectRangeDirection.Min) <= ConnectRangeConverter(currentPiece.Y, ConnectRangeDirection.Min))
                    {
                        nodeIdXBegin = ConnectRangeConverter(currentPiece.X, ConnectRangeDirection.Min);
                        currentPieceXorY = currentPiece.X;
                    }
                    else
                    {
                        nodeIdXBegin = ConnectRangeConverter(currentPiece.Y, ConnectRangeDirection.Min);
                        currentPieceXorY = currentPiece.Y;
                    }
                    if (ConnectRangeConverter(currentPiece.X, ConnectRangeDirection.Max) >= ConnectRangeConverter(currentPiece.Y, ConnectRangeDirection.Max))
                    {
                        nodeIdMax = ConnectRangeConverter(currentPiece.X, ConnectRangeDirection.Max);
                    }
                    else
                    {
                        nodeIdMax = ConnectRangeConverter(currentPiece.Y, ConnectRangeDirection.Max);
                    }
                    nextY = -1;
                    break;
                */
                default:  
                    nodeIdXBegin = 0;//給予默認值，for迴圈需要給定值
                    nodeIdYBegin = 0;
                    nodeIdXEnd = 8;//給予默認值，for迴圈需要給定值
                    nodeIdYEnd = 8;//給予默認值，for迴圈需要給定值
                    nextX = 0;//給予默認值，for迴圈需要給定值
                    nextY = 0;//給予默認值，for迴圈需要給定值
                    break;
            }
            //TODO:用迴圈一次判斷每一顆棋子(pieceArr[x,y])和對應的行、列以及對角有沒有連續重複
            //TODO:檢測範圍是當前棋子的前後4個延伸，但檢測的棋子只要停在當前棋子就好，如果檢測方向已經到當前棋子後還沒有連線，就不可能再連下去了，因為剩下的棋子不足五顆
            //TODO:因此最多檢測五顆就好，每個方向五顆，四個方向檢測40顆最多(正中心)，最少檢測3個方向，檢測3顆(左上角)

            for (int iX = nodeIdXBegin, iY = nodeIdYBegin; iX <= currentPiece.X && iY <= currentPiece.Y; iX += nextX, iY += nextY)//i是應檢棋子的編號
            {
                for (int jX = iX + nextX, jY = iY + nextY; jX <= nodeIdXEnd && jY <= nodeIdYEnd && jX <= iX + 4; jX += nextX, jY += nextY)//j是被檢的棋子的編號
                {
                    /*
                    switch (direction)
                    {
                        case Direction.Horizontal:
                            PiecesForComparison = new Point(iX, iY);
                            PiecesToBeCompared = new Point(jX, jY);
                            break;

                        case Direction.Vertical:
                            PiecesForComparison = new Point(iX, iY);
                            PiecesToBeCompared = new Point(jX, jY);
                            break;

                        case Direction.Backslash:
                            PiecesForComparison = new Point(i, i);
                            PiecesToBeCompared = new Point(j, j);
                            break;

                        case Direction.Slash:
                            PiecesForComparison = new Point(i, i);
                            PiecesToBeCompared = new Point(j, j);
                            break;

                        default:
                            PiecesForComparison = new Point(currentPiece.X, currentPiece.Y);//給予默認值，for迴圈需要給定值
                            PiecesToBeCompared = new Point(currentPiece.X, currentPiece.Y);//給予默認值，for迴圈需要給定值
                            break;
                    }*/
                    if (piecesArr[iX, iY] != null && piecesArr[jX, jY] != null)
                    {
                        if (GetPieceType(iX, iY) == GetPieceType(jX, jY))
                        {
                            //BugLog("該行的" + i + "號有應檢棋子且它的右邊第" + (j - i) + "個位子有棋", bugLogSwitch);
                            //BugLog("應檢棋子與它的右邊第" + (j - i) + "顆同色", bugLogSwitch);
                            //TODO:每次顏色一樣的話，連線計數器(connectCounter)就+1
                            connectCounter++;
                            disconnectChecker = false;
                            //BugLog("目前累積連線顆數:" + (1 + connectCounter) + "顆", bugLogSwitch);
                        }
                        else
                        {
                            //BugLog("應檢棋子與它的右邊第" + (j - i) + "顆不同色", bugLogSwitch);
                            break;
                        }
                        if (disconnectChecker != true && connectCounter == 4)
                        {
                            BugLog("贏了", bugLogSwitch, true);
                            break;
                        }
                    }
                }
                //TODO:如果遇到不同顏色的話(包含沒有棋子)，斷線檢查器(disconnectChecker)就設定為true
                connectCounter = 0;
                disconnectChecker = true;
            }
        }

        private void BugLog(string txt,bool enable)//debug小工具
        {
            if (enable)
            {
                MessageBox.Show(txt);
            }
        }
        private void BugLog(string txt, bool enable,bool independent)//debug小工具overload
        {
            enable = independent;
            if (enable)
            {
                MessageBox.Show(txt);
            }
        }
    }
}
