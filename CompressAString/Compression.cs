using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompressAString
{
    class Compression
    {
        //Member Variables
        //Constructor
        //Methods
        public void Compressor(string stringToCompress)
        {
            int counterForCurrentLetter = 1;
            string result = "";
            for(int index = 0; index < stringToCompress.Length - 1; index++)
            {
                if(stringToCompress[index] == stringToCompress[index + 1])
                {
                    //goes here if they match
                    counterForCurrentLetter++;
                }
                else
                {
                    //if they dont match go here
                    result += counterForCurrentLetter.ToString() + stringToCompress[index].ToString();
                    counterForCurrentLetter = 1;
                }
            }

            //handle last letter here
            result += counterForCurrentLetter.ToString() + stringToCompress[stringToCompress.Length - 1].ToString();

            Console.WriteLine(result);
            //start with a string
            //loop through my string
                //compare current letter to next letter
                //if they match, keep counting
                //if they dont match, save progress, reset counter
            //end with the compressed string
        }
    }
}
