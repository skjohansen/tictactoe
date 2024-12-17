using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tictactoe.Application.Console;
using tictactoe.Application.Test.Mocks;

namespace tictactoe.Application.Test;

public class GameRunnerTests
{
    [Fact(DisplayName = "Milestone 1 - create board")]
    public Task Run_BoardIsPresented()
    {
        // Arrange
        IConsole consoleMock = new ConsoleWrapperMock();
        IPlayer playerMock = new PlayerMock(){ PlayerMockValue = "C"};
        
        var sut = new tictactoeRunner(consoleMock, playerMock);
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
        IPlayer playerMock = new PlayerMock(){ PlayerMockValue = "C"};
        var sut = new tictactoeRunner(consoleMock, playerMock);
        // Act
        var outout = sut.PresentStarter("X");
        // Assert
        Assert.Equal("The game will start with player X", outout);
        
    }
}
