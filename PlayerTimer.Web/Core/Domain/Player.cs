
using System;

namespace PlayerTimer.Core.Domain
{
    public sealed class Player
    {
        public Player(string name, string avatarUrl) =>
            (Name, AvatarUrl) = (name, avatarUrl);

        public string Name { get; }

        public string AvatarUrl { get; }

        public TimeSpan TimeTaken { get; set; } = TimeSpan.Zero;
    }
}