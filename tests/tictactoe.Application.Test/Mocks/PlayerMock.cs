using System;

namespace tictactoe.Application.Test.Mocks;

public class PlayerMock : IPlayer
{
    public string PlayerMockValue { get; set; }
    public string RandomPlayer()
    {
        return PlayerMockValue;
    }
}
