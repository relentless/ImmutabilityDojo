using NUnit.Framework;

namespace Greetings {
    [TestFixture]
    public class Friend_Tests {
        [Test]
        public void Greet_GivenName_SaysHello() {
            var greeting = Friend.Greet("Bob");
            Assert.That(greeting, Is.EqualTo("Hello, Bob"));
        }

        [Test]
        public void Greet_GivenNull_SaysHelloWithStandIn() {
            var greeting = Friend.Greet(null);
            Assert.That(greeting, Is.EqualTo("Hello, Friend"));
        }

        [Test]
        public void Greet_NameShouted_ShoutsBack() {
            var greeting = Friend.Greet("BOB");
            Assert.That(greeting, Is.EqualTo("HELLO BOB!"));
        }

        [Test]
        public void Greet_TwoNames_GreetsBoth() {
            var greeting = Friend.Greet("Bob", "Sue");
            Assert.That(greeting, Is.EqualTo("Hello, Bob and Sue"));
        }

        [Test]
        public void Greet_MultipleNames_GreetsAll() {
            var greeting = Friend.Greet("Rita", "Sue", "Bob");
            Assert.That(greeting, Is.EqualTo("Hello, Rita, Sue and Bob"));
        }
    }
}
