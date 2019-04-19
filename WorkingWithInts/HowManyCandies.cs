using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithInts
{
    public class HowManyCandies
    {
        public int GetNumberOfCandiesUsedInAll(int numOfKids, int piecesOfCandy)
        {
            int numOfCandies = 0;

            if (numOfKids > piecesOfCandy)
                numOfCandies = 0;

            if (numOfKids < piecesOfCandy)
                numOfCandies = (piecesOfCandy / numOfKids) * numOfKids;

            if (numOfKids == piecesOfCandy)
                numOfCandies = piecesOfCandy;

            return numOfCandies;
        }
    }
}
