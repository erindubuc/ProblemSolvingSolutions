using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bool_WillYouBeLoved
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        /*  Once Mary heard a famous song, and a line from it stuck in her head. 
         *  That line was "Will you still love me when I'm no longer young and 
         *  beautiful?". Mary believes that a person is loved if and only if he/she 
         *  is both young and beautiful, but this is quite a depressing thought, 
         *  so she wants to put her belief to the test.

            Knowing whether a person is young, beautiful and loved, find out if they contradict Mary's belief.

            A person contradicts Mary's belief if one of the following statements is true:

            1. they are young and beautiful but not loved;
            2. they are loved but not young or not beautiful.
        */

        bool WillYouBeLoved(bool young, bool beautiful, bool loved)
        {

            if (beautiful && young)
            {
                if (loved)
                    return false;
            }

            if (!beautiful && !young)
            {
                if (loved)
                    return true;

                return false;
            }

            if (!beautiful && young || beautiful && !young)
            {
                if (!loved)
                    return false;
            }
            return true;
        }
    }
}
