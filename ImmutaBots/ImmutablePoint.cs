using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImmutaBots {

    public class ImmutablePoint {
        // Not *actually* immutable

        public ImmutablePoint(int xPos, int yPos) {
            XPos = xPos;
            YPos = yPos;
        }

        public int XPos { get; private set; }
        public int YPos { get; private set; }

    }
}
