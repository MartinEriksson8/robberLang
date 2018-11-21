using System.Text;
using System;
using System.Linq;

namespace Core
{
    public static class RobberTranslaor
    {
        public static string ToRobber(string raw)
        {
            //Checking if the string is empty. Otherwise we proceed.
            if (string.IsNullOrWhiteSpace(raw))
            {
                return "";
            }
            //else we proceed and make raw lowercase to find the letter easier
            else
            {
                raw = raw.ToLowerInvariant();
            }
           
            var newText = "";
            //We check every character in the string for consonants
            foreach (char c in raw)
            {
                //if c is a consonant we add a O + the consonant to make the Robber language
                if ("bcdfghjklmnpqrstvwxz".Contains(c))
                {
                    newText = newText + c + "o" + c;
                }
                //if c is not a consonant we add it without changes.
                else
                {
                    newText = newText + c;
                }

            }
            return newText;           
        }
    }
}