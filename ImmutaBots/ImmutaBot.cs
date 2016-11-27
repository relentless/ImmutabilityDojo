namespace ImmutaBots {
    public class ImmutaBot: Robot {
        private readonly ImmutablePoint _location;
        private readonly int _power;

        private const int defaultPower = 100;

        public ImmutaBot(ImmutablePoint initialLocation):
            this(initialLocation, defaultPower) {}

        public ImmutaBot(ImmutablePoint initialLocation, int initialPower) {
            _location = initialLocation;
            _power = initialPower;
        }

        public ImmutaBot MoveBy(int moveX, int moveY) {
            var newX = _location.XPos + moveX;
            var newY = _location.YPos + moveY;
            return new ImmutaBot(new ImmutablePoint(newX, newY), _power);
        }

        public ImmutaBot ReceiveAttackFrom(MutaBot target) {
            if (DistanceTo(target) < 50) {
                return new ImmutaBot(_location, _power - 10);
            }
            else {
                return this;
            }
        }

        public ImmutaBot Recharge() {
            return new ImmutaBot(_location, _power + 1);
        }
    }
}
