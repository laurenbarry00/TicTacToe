using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicTacToe;

namespace UnitTests
{
    [TestClass]
    public class CheckVictoryTests
    {
        [TestMethod]
        public void TestCheckVictoryHorizontalWinForX()
        {
            Board board = new Board();
            board.PlaceMark(Player.X, 0, 0);
            board.PlaceMark(Player.X, 0, 1);
            board.PlaceMark(Player.X, 0, 2);
            Assert.AreEqual(Player.X, board.CheckVictory());
        }

        [TestMethod]
        public void TestCheckVictoryVerticalWinForX()
        {
            Board board = new Board();
            board.PlaceMark(Player.X, 0, 0);
            board.PlaceMark(Player.X, 1, 0);
            board.PlaceMark(Player.X, 2, 0);
            Assert.AreEqual(Player.X, board.CheckVictory());
        }

        [TestMethod]
        public void TestCheckVictoryDiagonalWinForX()
        {
            Board board = new Board();
            board.PlaceMark(Player.X, 0, 0);
            board.PlaceMark(Player.X, 1, 1);
            board.PlaceMark(Player.X, 2, 2);
            Assert.AreEqual(Player.X, board.CheckVictory());
        }

        [TestMethod]
        public void TestCheckVictoryOtherDiagonalWinForX()
        {
            Board board = new Board();
            board.PlaceMark(Player.X, 0, 2);
            board.PlaceMark(Player.X, 1, 1);
            board.PlaceMark(Player.X, 2, 0);
            Assert.AreEqual(Player.X, board.CheckVictory());
        }

        [TestMethod]
        public void TestCheckVictoryHorizontalWinForO()
        {
            Board board = new Board();
            board.PlaceMark(Player.O, 0, 0);
            board.PlaceMark(Player.O, 0, 1);
            board.PlaceMark(Player.O, 0, 2);
            Assert.AreEqual(Player.O, board.CheckVictory());
        }

        [TestMethod]
        public void TestCheckVictoryVerticalWinForO()
        {
            Board board = new Board();
            board.PlaceMark(Player.O, 0, 0);
            board.PlaceMark(Player.O, 1, 0);
            board.PlaceMark(Player.O, 2, 0);
            Assert.AreEqual(Player.O, board.CheckVictory());
        }

        [TestMethod]
        public void TestCheckVictoryDiagonalWinForO()
        {
            Board board = new Board();
            board.PlaceMark(Player.O, 0, 0);
            board.PlaceMark(Player.O, 1, 1);
            board.PlaceMark(Player.O, 2, 2);
            Assert.AreEqual(Player.O, board.CheckVictory());
        }

        [TestMethod]
        public void TestCheckVictoryOtherDiagonalWinForO()
        {
            Board board = new Board();
            board.PlaceMark(Player.O, 0, 2);
            board.PlaceMark(Player.O, 1, 1);
            board.PlaceMark(Player.O, 2, 0);
            Assert.AreEqual(Player.O, board.CheckVictory());
        }
    }
}
