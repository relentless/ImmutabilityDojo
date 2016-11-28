using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Tennis {
    [TestFixture]
    public class ScoreKeeper_Tests {
        [Test]
        public void score_starts_at_love_love() {
            var scorer = new ScoreKeeper();
            Assert.That(scorer.Score, Is.EqualTo("Love-Love"));
        }

        [Test]
        public void player_A_scores_fifteen_love() {
            var scorer = new ScoreKeeper();
            var firstScore = scorer.BallWon(Player.A);
            Assert.That(firstScore.Score, Is.EqualTo("Fifteen-Love"));
        }

        [Test]
        public void player_B_scores_love_fifteen() {
            var scorer = new ScoreKeeper();
            var firstScore = scorer.BallWon(Player.B);
            Assert.That(firstScore.Score, Is.EqualTo("Love-Fifteen"));
        }

        [Test]
        public void second_score_is_thirty() {
            var scorer = new ScoreKeeper();
            var firstScore = scorer.BallWon(Player.A);
            var secondScore = firstScore.BallWon(Player.A);
            Assert.That(secondScore.Score, Is.EqualTo("Thirty-Love"));
        }
    }
}
