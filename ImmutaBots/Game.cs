using System.Collections.Generic;

namespace ImmutaBots {
    public class Game {

        public void Run() {

            var bot1 = new MutaBot();
            // state of bot1?
            bot1.Location = new Point { XPos = 0, YPos = 0 } ;

            var bot2 = new ImmutaBot(new ImmutablePoint( xPos: 99, yPos: 99));

            // ...

            bot1.MoveBy(2, 4);
            bot1.ReceiveAttackFrom(bot2);
            bot1.Recharge();

            var movedBot = bot2.MoveBy(-2, -1);
            var attackedBot = movedBot.ReceiveAttackFrom(bot1);
            var rechargedBot = attackedBot.Recharge();

            // Or

            var updatedBot = bot2
                .MoveBy(-2, -1)
                .ReceiveAttackFrom(bot1)
                .Recharge();

        }
    }
}
