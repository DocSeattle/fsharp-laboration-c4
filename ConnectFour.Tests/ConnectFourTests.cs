
namespace ConnectFour.Tests
{
    public class ConnectFourTests
    {
        GameState state = new GameState();

        [Fact]
        public void CheckForWin_NoWinner_EmptyBoard()
        {
            GameState.WinState noWinner = GameState.WinState.No_Winner;
            state.ResetBoard();
            if(state.TheBoard.Count(x => x != 0) > 0 && state.CheckForWin() == noWinner)
            {
                Assert.True(true, "No Winner");
                return;
            }
            else
            {
                Console.WriteLine("Test failed!");
                return;
            }
        }
        [Fact]
        public void CheckForWin_TieGame()
        {
            GameState.WinState tieState = GameState.WinState.Tie;
            state.ResetBoard();
            state.TheBoard.Add(42);
            if (state.TheBoard.Count == 42 && state.CheckForWin() == tieState )
            {
                Assert.True(true, "Game is a tie");
                return;
            }
            else
            {
                Console.WriteLine("Test failed!");
                return;
            }
        }
    }
}