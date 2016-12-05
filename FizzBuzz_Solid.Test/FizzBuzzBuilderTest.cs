using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz_Solid.Test
{
    [TestClass]
    public class FizzBuzzBuilderTest
    {
        private FizzBuzzBuilder builder;

        [TestInitialize]
        public void Setup()
        {
             builder = new FizzBuzzBuilder(new KataRules());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "rules cannot be null")]
        public void NullRulesInConstructor()
        {
            new FizzBuzzBuilder(null);
        }

        [TestMethod]
        public void FizzBuzz_Process_Method_Returns_Fizz_When_Number_Is_Divisible_By_Only_3()
        {

            // Assert
            Assert.AreEqual(builder.build(3), "Fizz");
            Assert.AreEqual(builder.build(6), "Fizz");
            Assert.AreEqual(builder.build(9), "Fizz");
        }

        [TestMethod]
        public void FizzBuzz_Process_Method_Returns_Buzz_When_Number_Is_Divisible_By_Only_5()
        {
            // Assert
            Assert.AreEqual(builder.build(5), "Buzz");
            Assert.AreEqual(builder.build(10),"Buzz");
            Assert.AreEqual(builder.build(20),"Buzz");
        }

        [TestMethod]
        public void FizzBuzz_Process_Method_Returns_FizzBuzz_When_Number_Is_Divisible_By_3_And_5()
        {
            // Assert
            Assert.AreEqual(builder.build(15), "FizzBuzz");
            Assert.AreEqual(builder.build(30), "FizzBuzz");
            Assert.AreEqual(builder.build(45), "FizzBuzz");
        }

        [TestMethod]
        public void FizzBuzz_Process_Method_Returns_Number_When_Number_Is_Not_Divisible_By_3_Or_5()
        {
            // Assert
            Assert.AreEqual(builder.build(1), "1");
            Assert.AreEqual(builder.build(7), "7");
            Assert.AreEqual(builder.build(17),"17");

        }
    }
}
