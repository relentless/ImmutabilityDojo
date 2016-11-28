
using System.Linq;
using System.Collections.Generic;

namespace Greetings
{
    public class Friend
    {
        public static string Greet(params string[] names) {

            var notNullNames = names ?? new string[] { "Friend" };
            var joinedNames = notNullNames.Length > 1 ? JoinLastTwoNames(notNullNames) : notNullNames;
            var flattenedNames = string.Join(", ", joinedNames);

            if (AllUppercase(flattenedNames)) {
                return string.Format("HELLO {0}!", flattenedNames);
            }
            else {
                return string.Format("Hello, {0}", (flattenedNames ?? "Friend"));
            }
        }

        private static IEnumerable<string> JoinLastTwoNames(string[] notNullNames) {
            return notNullNames.ToList()
                .Take(notNullNames.Length - 2)
                .Concat(new List<string> { string.Format("{0} and {1}",
                                        notNullNames[notNullNames.Length - 2],
                                        notNullNames[notNullNames.Length - 1]) });
        }

        private static bool AllUppercase(string text) {
            return text != null 
                && text.ToUpper() == text;
        }
    }
}
