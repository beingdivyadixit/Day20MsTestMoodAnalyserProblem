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
            //Try and Catch method
            try 
            {
                if (message.ToLower().Contains("happy"))
                {
                    return "happy";
                }
                else
                {
                    return "sad";
                }
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Happy");
                return default;
            }
        }
    }
}
