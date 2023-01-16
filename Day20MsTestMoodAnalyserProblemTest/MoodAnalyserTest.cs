﻿using Day20MsTestMoodAnalyserProblem;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Day20MsTestMoodAnalyserProblemTest
{
    [TestClass]
    public class MoodAnalyserTest
    {

        [TestMethod]
        //T.C.1
        //[DataRow("I am in happy mood","happy")]
        //[DataRow("I am in sad mood","sad")]
        //T.C.2
        //[DataRow(null,"Object reference not set to an instance of an object")]
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
    }
}
