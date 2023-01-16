using Day20MsTestMoodAnalyserProblem;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Day20MsTestMoodAnalyserProblemTest
{
    [TestClass]
    public class MoodAnalyserTest
    {

        [TestMethod]
        [DataRow("I am in happy mood", "happy")]
        [DataRow("I am in sad mood", "sad")]
        public void Given_Message_Should_Return_TypesOf_Mood(string message, string expected)
        {
            try
            {
                //AAA methodology
                //Arrange
                MoodAnalyser moodAnalyser = new MoodAnalyser();
                //Act
                string actual = moodAnalyser.AnalyseMood(message);
                //Assert
                if (actual != null)
                    Assert.AreEqual(expected, actual);
            }
            catch (Exception ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }
    }
}
