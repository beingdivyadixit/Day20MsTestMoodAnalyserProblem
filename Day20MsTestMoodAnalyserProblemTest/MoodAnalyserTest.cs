using Day20MsTestMoodAnalyserProblem;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Day20MsTestMoodAnalyserProblemTest
{
    [TestClass]
    public class MoodAnalyserTest
    {

        [TestMethod]
        //T.C.1
        [DataRow("I am in happy mood","happy")]
        [DataRow("I am in sad mood","sad")]
        //T.C.2
        //T.C.2.1
        [DataRow(null, "Happy")]
        public void Given_Message_Should_Return_TypesOf_Mood(string message, string expected)
        {
            try
            {
                //AAA methodology
                //Arrange
                MoodAnalyser moodAnalyser = new MoodAnalyser(message);
                //Act
                string actual = moodAnalyser.AnalyseMood();
                //Assert
                if (actual != null)
                    Assert.AreEqual(expected, actual);
            }
            catch (Exception)
            {
                Assert.AreEqual(expected, "Happy");
            }
        }
        [TestMethod]
        //T.C.3.1[Null Message]
        //T.C.3.2[Empty Message]
        public void Given_Message_Should_Return_Custom_Exception()
        {
            string expected = "Message should not be empty";
            try
            {
                //arrange
                string message = "";
                MoodAnalyser moodAnalyser = new MoodAnalyser(message);
                //Act
                string actual = moodAnalyser.AnalyseMood();
                if (actual != null)
                    Assert.AreEqual(expected, actual);
            }
            catch (CustomMoodAnalyserException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }
    }
}
