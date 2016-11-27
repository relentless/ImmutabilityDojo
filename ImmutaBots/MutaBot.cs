namespace ImmutaBots {
    public class MutaBot: Robot {

        public Point Location { get; set; }

        private int _power;

        public MutaBot() {
            _power = 100;
        }

        public void MoveBy(int moveX, int moveY) {
            Location.XPos += moveX;
            Location.YPos += moveY;
        }

        public void Recharge() {
            _power += 1;
        }

        public void ReceiveAttackFrom(Robot attacker) {
            if (DistanceTo(attacker) < 50) {
                _power -= 10;
            }
        }
    }
}
