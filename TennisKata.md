# Immutable Tennis Kata

Create a program which scores tennis games in real time.  Informed of which player won each ball, it should output the result in a textual format, using typical tennis scoring.

Only games are scored, not sets or matches.

#### Example

    var scorer = new ScoreKeeper();
    scorer.BallWon(Player.A);
    scorer.BallWon(Player.B);
    scorer.BallWon(Player.A);
    Assert.That(scorer.Score, Is.EqualTo("Thirty-Fifteen"));
    
#### Tennis Scoring Rules

* A game is won by the first player to have won at least four points in total and at least two points more than the opponent.
* The running score of each game is described in a manner peculiar to tennis: scores from zero to three points are described as “Love”, “Fifteen”, “Thirty”, and “Forty” respectively.
* If at least three points have been scored by each player, and the scores are equal, the score is “Deuce”.
* If at least three points have been scored by each side and a player has one more point than his opponent, the score of the game is “Advantage” for the player in the lead (e.g. "Advantage Player A")

#### Kata Rules

* All code should be immutable.  (The example above is not.)
* The code's API is up to you, but it must use a separate call for each ball scored.
* Assume input will always be valid, and the program used in the correct way.  (Error checking & validation are not needed).
* Unit tests are not required, but are highly recommended.
* If the requirements are not clear, make a decision and continue or ask the facilitator.
* The point of this exercise if to learn immutable code, not to finish the solution.

Good luck!