
using System;

namespace PlayerTimer.Core.Domain
{
    public sealed class Game
    {
        public Game(TimeSpan maximumTimePerPlayer) =>
            MaximumTimePerPlayer = maximumTimePerPlayer;

        public TimeSpan MaximumTimePerPlayer { get; }
    }
}