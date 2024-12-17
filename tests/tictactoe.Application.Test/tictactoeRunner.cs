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
    [Fact]
    public void Run_WelcomeMessageIsPresented()
    {
        // Arrange
        IConsole consoleMock = new ConsoleWrapperMock();
        var sut = new tictactoeRunner(consoleMock);
        // Act
        sut.Run();
        // Assert
        Assert.Equal("Welcome to the tictactoe!", ((ConsoleWrapperMock)consoleMock).LineToWrite);
    }
}
