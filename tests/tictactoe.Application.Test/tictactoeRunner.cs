using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tictactoe.Application.Console;
using tictactoe.Application.Test.Mocks;
using tictactoe.Logic;

namespace tictactoe.Application.Test;

public class GameRunnerTests
{
    [Fact(DisplayName = "Milestone 1 - create board")]
    public Task Run_BoardIsPresented()
    {
        // Arrange
        IConsole consoleMock = new ConsoleWrapperMock();
        IPlayer playerMock = new PlayerMock(){ PlayerMockValue = "X"};
        IGameEngine gameEngine = new GameEngine();
        var sut = new tictactoeRunner(consoleMock, playerMock, gameEngine);
        // Act
        sut.Run();
        // Assert
        string content= ((ConsoleWrapperMock)consoleMock).screenContent.ToString();
        return Verifier.Verify(content);
    }

    [Fact(DisplayName = "Present starting player")]
    public void Run_StarterIsPresented()
    {
        // Arrange
        IConsole consoleMock = new ConsoleWrapperMock();
        IPlayer playerMock = new PlayerMock(){ PlayerMockValue = "X"};
        IGameEngine gameEngine = new GameEngine();
        var sut = new tictactoeRunner(consoleMock, playerMock, gameEngine);
        // Act
        var outout = sut.PresentStarter("X");
        // Assert
        Assert.Equal("The game will start with player X", outout);
        
    }


    [Fact(DisplayName = "Milestone 2 - vertical win")]
    public Task Run_Milestone2VerticalWin()
    {
        // Arrange
        IConsole consoleMock = new ConsoleWrapperMock();
        IPlayer playerMock = new PlayerMock(){ PlayerMockValue = "X"};
        IGameEngine gameEngine = new GameEngine();
        gameEngine.CurrentPlayer = "X";
        // tech debt: not good tests implementation
        gameEngine.SetPeice(0,0); //x
        gameEngine.NextPlayer();
        gameEngine.SetPeice(1,1); //o
        gameEngine.NextPlayer();
        gameEngine.SetPeice(1,0); //x
        gameEngine.NextPlayer();
        gameEngine.SetPeice(2,2); //o
        gameEngine.NextPlayer();
        gameEngine.SetPeice(2,0); //x
        gameEngine.HasWinner();
        var sut = new tictactoeRunner(consoleMock, playerMock, gameEngine);

        // Act
        sut.Run();
        
        // Assert
        string content= ((ConsoleWrapperMock)consoleMock).screenContent.ToString();
        return Verifier.Verify(content);
    }
    
}
