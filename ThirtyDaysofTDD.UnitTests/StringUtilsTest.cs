using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirtyDaysofTDD.UnitTests
{
    [TestFixture]
    public class StringUtilsTest
    {
        private StringUtils _stringUtils;

        [SetUp]
        public void SetupStringUtilTests()
        {
            _stringUtils = new StringUtils();
        }

        [Test]
        public void ShouldBeAbleToCountNumberOfLettersInSimpleSentence()
        {
            var sentenceToScan = "TDD is awesome!";

            var characterToScanFor = "e";

            var expectedResult = 2;

            //var stringUtils = new StringUtils();

            int result = _stringUtils.FindNumberOfOccurences(sentenceToScan, characterToScanFor);

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void ShouldBeAbleToCountNumberOfLettersInAComplexSentance()
        {
            var sentenceToScan = "Once is unique, twice is a coincidence, three times is a pattern.";

            var characterToScanFor = "n";

            var expectedResult = 5;

            //var stringUtils = new StringUtils();

            int result = _stringUtils.FindNumberOfOccurences(sentenceToScan, characterToScanFor);

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void ShouldGetAnArgumentExceptionWhenCharacterToScanForIsLargerThanOneCharacter()
        {
            var sentenceToScan = "This test should throw an exception";
            var characterToScanFor = "x"; //"xx" will not pass the test
            //var stringUtils = new StringUtils();

            _stringUtils.FindNumberOfOccurences(sentenceToScan, characterToScanFor);
        }

    }
}
