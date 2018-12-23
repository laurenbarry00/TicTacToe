using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicTacToe;

namespace UnitTests
{
    [TestClass]
    public class PlaceMarkTests
    {
        /* Test placing based on column */
        [TestMethod]
        public void TestPlaceXOnColumnOne()
        {
            Board board = new Board();
            board.PlaceMark(Player.X, 0, 0);
            Assert.AreEqual(Player.X, board.GetSquare(0, 0));
        }

        [TestMethod]
        public void TestPlaceXOnColumnTwo()
        {

            Board board = new Board();
            board.PlaceMark(Player.X, 0, 1);
            Assert.AreEqual(Player.X, board.GetSquare(0, 1));
        }

        [TestMethod]
        public void TestPlaceXOnColumnThree()
        {

            Board board = new Board();
            board.PlaceMark(Player.X, 0, 2);
            Assert.AreEqual(Player.X, board.GetSquare(0, 2));
        }

        [TestMethod]
        public void TestPlaceOOnColumnOne()
        {

            Board board = new Board();
            board.PlaceMark(Player.O, 0, 0);
            Assert.AreEqual(Player.O, board.GetSquare(0, 0));
        }

        [TestMethod]
        public void TestPlaceOOnColumnTwo()
        {
            Board board = new Board();
            board.PlaceMark(Player.O, 0, 1);
            Assert.AreEqual(Player.O, board.GetSquare(0, 1));
        }

        [TestMethod]
        public void TestPlaceOOnColumnThree()
        {
            Board board = new Board();
            board.PlaceMark(Player.O, 0, 2);
            Assert.AreEqual(Player.O, board.GetSquare(0, 2));
        }


        /* Test placing based on row */
        [TestMethod]
        public void TestPlaceXOnRowOne()
        {
            Board board = new Board();
            board.PlaceMark(Player.X, 0, 0);
            Assert.AreEqual(Player.X, board.GetSquare(0, 0));
        }

        [TestMethod]
        public void TestPlaceXOnRowTwo()
        {
            Board board = new Board();
            board.PlaceMark(Player.X, 1, 0);
            Assert.AreEqual(Player.X, board.GetSquare(1, 0));
        }

        [TestMethod]
        public void TestPlaceXOnRowThree()
        {
            Board board = new Board();
            board.PlaceMark(Player.X, 2, 0);
            Assert.AreEqual(Player.X, board.GetSquare(2, 0));
        }

        [TestMethod]
        public void TestPlaceOOnRowOne()
        {
            Board board = new Board();
            board.PlaceMark(Player.O, 0, 0);
            Assert.AreEqual(Player.O, board.GetSquare(0, 0));
        }

        [TestMethod]
        public void TestPlaceOOnRowTwo()
        {
            Board board = new Board();
            board.PlaceMark(Player.O, 1, 0);
            Assert.AreEqual(Player.O, board.GetSquare(1, 0));
        }

        [TestMethod]
        public void TestPlaceOOnRowThree()
        {
            Board board = new Board();
            board.PlaceMark(Player.O, 2, 0);
            Assert.AreEqual(Player.O, board.GetSquare(2, 0));
        }
    }
}
