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
    public Task Run_BoardIsPresented()
    {
        // Arrange
        IConsole consoleMock = new ConsoleWrapperMock();
        var sut = new tictactoeRunner(consoleMock);
        // Act
        sut.Run();
        // Assert
        string content= ((ConsoleWrapperMock)consoleMock).screenContent.ToString();
        return Verifier.Verify(content);
    }
}
