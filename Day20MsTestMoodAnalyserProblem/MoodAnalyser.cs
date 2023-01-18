using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day20MsTestMoodAnalyserProblem
{
    public class MoodAnalyser
    {
        //Default Constructor
        public MoodAnalyser()
        {

        }
        public string message;
        //  constructor with Parameters
        public MoodAnalyser(string message)
        {
            this.message = message;
        }
        //AnalyseMood method
        public string AnalyseMood()
        {
            try
            {
                if (message.ToLower().Contains("happy"))
                {
                    return "happy";
                }
                else if (message.ToLower().Equals(string.Empty))
                {
                    Console.WriteLine(message);
                    throw new CustomMoodAnalyserException("Message should not be empty", CustomMoodAnalyserException.ExceptionTypes.EMPTY_MESSAGE);
                }
                else
                {
                    return "sad";
                }
            }
            catch (NullReferenceException)
            {
                throw new CustomMoodAnalyserException("Message should not be empty", CustomMoodAnalyserException.ExceptionTypes.EMPTY_MESSAGE);
            }
        }
    }
}
