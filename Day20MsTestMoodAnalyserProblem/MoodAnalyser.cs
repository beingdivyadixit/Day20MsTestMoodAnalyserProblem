using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day20MsTestMoodAnalyserProblem
{
    public class MoodAnalyser
    {
        //AnalyseMood method
        public string AnalyseMood(string message)
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
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
                return default;
            }
        }
    }
}
