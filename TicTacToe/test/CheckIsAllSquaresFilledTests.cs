using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicTacToe;

namespace UnitTests
{
    [TestClass]
    public class CheckIsAllSquaresFilledTests
    {
        [TestMethod]
        public void TestAllSquaresX()
        {
            Board board = new Board();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board.PlaceMark(Player.X, i, j);
                }
            }
            Assert.IsTrue(board.CheckIsAllSquaresFilled());
        }

        [TestMethod]
        public void TestAllSquaresO()
        {
            Board board = new Board();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board.PlaceMark(Player.O, i, j);
                }
            }
            Assert.IsTrue(board.CheckIsAllSquaresFilled());
        }

        [TestMethod]
        public void TestEmptyBoard()
        {
            Board board = new Board();
            Assert.IsFalse(board.CheckIsAllSquaresFilled());
        }

        [TestMethod]
        public void TestMixedXAndO()
        {
            Board board = new Board();
            bool flag = true;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (flag)
                    {
                        board.PlaceMark(Player.X, i, j);
                        flag = !flag;
                    } else
                    {
                        board.PlaceMark(Player.O, i, j);
                        flag = !flag;
                    }
                }
            }
            Assert.IsTrue(board.CheckIsAllSquaresFilled());
        }

        [TestMethod]
        public void TestOneEmptyColumn()
        {
            Board board = new Board();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    board.PlaceMark(Player.X, i, j);
                }
            }
            Assert.IsFalse(board.CheckIsAllSquaresFilled());
        }

        [TestMethod]
        public void TestOneEmptyRow()
        {
            Board board = new Board();
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board.PlaceMark(Player.X, i, j);
                }
            }
            Assert.IsFalse(board.CheckIsAllSquaresFilled());
        }
    }
}
