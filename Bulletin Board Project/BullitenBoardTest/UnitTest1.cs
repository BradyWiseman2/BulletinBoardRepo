namespace BullitenBoardTest;
using Bulletin_Board_Project;
using Newtonsoft.Json;

[TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        Board board1 = new Board("board1");
        string temp = JsonConvert.SerializeObject(board1);
        Board board2 = JsonConvert.DeserializeObject<Board>(temp);
        Assert.AreEqual(board1.BoardName, board2.BoardName);
        }
    }
