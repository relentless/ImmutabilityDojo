using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImmutaBots {
    class Examples {
        public void StringsAreImmutable() {

            var text = "Hi mum!";

            text.ToUpper(); // Does nothing

            var uppercaseText = text.ToUpper();
        }

        public void LinqIsImmutable() {

            var numberList = Enumerable.Range(0, 100);

            var doubles = numberList.Select(num => num * 2);
            var reversed = doubles.Reverse();

            // Or

            var newNumbers = numberList
                .Select(num => num * 2)
                .Reverse();
        }
    }
}
