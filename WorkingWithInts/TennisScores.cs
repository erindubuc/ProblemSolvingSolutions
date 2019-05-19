using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithInts
{
    class TennisScores
    {
        /*
        Given two integers score1 and score2, your task is to 
        determine if it is possible for a tennis set to be finished 
            with a final score of score1 : score2.
        */

        bool WillTennisSetBeFinishedWithThisFinalScore(int score1, int score2)
        {
            if ((score1 == 6 && score2 < 5) || (score2 == 6 && score1 < 5))
                return true;

            if ((score1 == 7 && score2 >= 5 && score2 < score1) || (score2 == 7 && score1 >= 5 && score1 < score2))
            {
                if (score1 != score2)
                    return true;
                else
                    return false;

            }

            return false;
        }
    }
}
