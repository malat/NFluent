﻿namespace NFluent.Tests
{
    using System.Collections.Generic;

    using NUnit.Framework;

    [TestFixture]
    public class IsInstanceOfTests
    {
        #region IsInstanceOf tests

        [Test]
        public void IsInstanceOfWorks()
        {
            const string StringObj = "for unit testing";
            const int IntObj = 23;
            const long LongObj = long.MaxValue;
            const double DoubleObj = 23d;
            var person = new Person();
            List<string> stringList = new List<string>();
            int[] integerArray = new int[10];

            // string
            Check.That(StringObj).IsInstanceOf<string>();

            // numerics
            Check.That(IntObj).IsInstanceOf<int>();
            Check.That(LongObj).IsInstanceOf<long>();
            Check.That(DoubleObj).IsInstanceOf<double>();

            //// objects
            Check.That(person).IsInstanceOf<Person>();

            //// IEnumerable
            Check.That(stringList).IsInstanceOf<List<string>>();
            Check.That(integerArray).IsInstanceOf<int[]>();
        }

        [Test]
        [ExpectedException(typeof(FluentAssertionException),
            ExpectedMessage =
                "[23] is not an instance of the expected type [NFluent.Tests.Person] but of [System.Int32] instead.")]
        public void IsInstanceOfThrowsExceptionWithProperFormatWhenFailsWithInt()
        {
            const int IntObject = 23;
            Check.That(IntObject).IsInstanceOf<Person>();
        }

        [Test]
        [ExpectedException(typeof(FluentAssertionException), ExpectedMessage = @"[""for unit testing""] is not an instance of the expected type [NFluent.Tests.Person] but of [System.String] instead.")]
        public void IsInstanceOfThrowsExceptionWithProperFormatWhenFailsWithString()
        {
            const string StringObj = "for unit testing";
            Check.That(StringObj).IsInstanceOf<Person>();
        }

        #endregion

        #region IsNotInstanceOf tests

        [Test]
        public void IsNotInstanceOfWorks()
        {
            const string StringObj = "for unit testing";
            const int IntObj = 23;
            const long LongObj = long.MaxValue;
            const double DoubleObj = 23d;
            var person = new Person();
            List<string> stringList = new List<string>();
            int[] integerArray = new int[10];

            // string
            Check.That(StringObj).IsNotInstanceOf<int>();

            // numerics
            Check.That(IntObj).IsNotInstanceOf<long>();
            Check.That(LongObj).IsNotInstanceOf<string>();
            Check.That(DoubleObj).IsNotInstanceOf<int>();

            // objects
            Check.That(person).IsNotInstanceOf<NumbersRelatedTests>();

            // IEnumerable
            Check.That(stringList).IsNotInstanceOf<List<int>>();
            Check.That(integerArray).IsNotInstanceOf<string[]>();
        }
        
        [Test]
        public void IsNotInstanceOfWorksWithString()
        {
            const string MotivationalSaying = "Failure is mother of success.";
            Check.That(MotivationalSaying).IsNotInstanceOf<int>();
        }

        [Test]
        [ExpectedException(typeof(FluentAssertionException),
            ExpectedMessage = "[23] is an instance of the type [System.Int32] which is not expected.")]
        public void IsNotInstanceOfThrowsExceptionWithProperFormatWhenFailsWithInt()
        {
            const int IntObject = 23;

            Check.That(IntObject).IsNotInstanceOf<int>();
        }

        [Test]
        [ExpectedException(typeof(FluentAssertionException), ExpectedMessage = @"[""If you don’t want to slip up tomorrow, speak the truth today (Bruce Lee).""] is an instance of the type [System.String] which is not expected.")]
        public void IsNotInstanceOfThrowsExceptionWithProperFormatWhenFailsWithString()
        {
            const string Statement = "If you don’t want to slip up tomorrow, speak the truth today (Bruce Lee).";

            Check.That(Statement).IsNotInstanceOf<string>();
        }

        #endregion

        // TODO: add unit test related to theIsNotInstance error messages (for IEnumerable, object, etc)
    }
}
