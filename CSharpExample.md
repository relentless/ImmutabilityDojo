# Immutable C# Example

### Immutable Class

    public class ImmutaBot {
        
####// All members should be readonly or const 
        private const int initialEnergy = 100; // Consts are truly immutable and can never be changed
        private readonly int _energy; // Readonly variables can only be changed in the constructor
        private readonly ImmutablePoint _location; // Any reference types used must also be immutable
        
####// If you need a collection, try something from System.Collections.Immutable (on NuGet)
        
####// Everything must be passed into, and set from, the constructor
        public ImmutaBot(ImmutablePoint location, int energy) {
            _location = location;
            _energy = energy;
        }
        
####// It can be useful to have multiple constructors to make things easier for the user
        public ImmutaBot(ImmutablePoint location):
          this(location, initialEnergy) {}

####// Methods which need to change values must return a new instance of the class
        public ImmutaBot MoveBy(int moveX, int moveY) {
            var newX = _location.XPos + moveX;
            var newY = _location.YPos + moveY;
            return new ImmutaBot(new ImmutablePoint(newX, newY), _energy);
        }
        
        public ImmutaBot Recharge() {
            return new ImmutaBot(_location, _energy + 1);
        }
        
####// Properties can only be getters, not setters (private setters *may* be OK)
        public Energy {
            get {
                 return _energy;
             }
        }
    }
    
### Immutable Code

    public void Run() {
    
####// New variables must be used each time an object is changed
        var myBot = new ImmutaBot(new ImmutablePoint( xPos: 99, yPos: 99));
        var movedBot = bot2.MoveBy(-2, -1);
        var rechargedBot = attackedBot.Recharge();
        
####// A variable must be given a value when initialised.
        string message;  // NO!
        string message = "Hi mum!" // Better
        
####// Once a variable has been given a value, it cannot be changed.
        string message += " How are you?" // Not cool!
        
####// Loops generally a bad idea - use Linq methods instead
        var result = 0;
        foreach(var number in myList) {
            result += number * 2; // CLEARLY NOT ALLOWED!
        }
        
        result = lyList.Select(number => number * 2).Sum(); // Better
        
####// Conditional operator can be useful as it returns a value directly, unlike the If statement
        return (DistanceTo(attacker) < 50) ?  new ImmutaBot(_location, _energy - 10) : this;
    }
