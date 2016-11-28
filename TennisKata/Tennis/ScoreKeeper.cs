using System.Linq;
using System.Collections.Immutable;
using System.Collections.Generic;

namespace Tennis
{
    public enum Player { A, B };

    public class ScoreKeeper {
        private readonly ImmutableList<Player> _pointsWon;

        private readonly ImmutableDictionary<int, string> scoreDescriptions =
            new Dictionary<int, string> {
                {0, "Love"},
                {1, "Fifteen"},
                {2, "Thirty"},
                {3, "Forty"}
            }.ToImmutableDictionary();

        public ScoreKeeper(ImmutableList<Player> pointsWon) {
            _pointsWon = pointsWon;
        }

        public ScoreKeeper(): this(ImmutableList.Create<Player>()) {}

        public ScoreKeeper BallWon(Player winner) {
            string x;
            return new ScoreKeeper(_pointsWon.Add(winner));
        }

        public string Score {
            get {

                var playerAPoints = _pointsWon.Where(player => player == Player.A).Count();
                var playerBPoints = _pointsWon.Where(player => player == Player.B).Count();

                return string.Format("{0}-{1}", scoreDescriptions[playerAPoints], scoreDescriptions[playerBPoints]);
            }
        }
    }
}
