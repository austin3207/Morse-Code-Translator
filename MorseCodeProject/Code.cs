using System;
using System.Collections.Generic;
using System.Text;

namespace MorseCodeProject
{
    class Code
    {
        public static string sentToMorse(string[,] morseCode, string sentence)
        {
            string translatedSentence = "";
            foreach (char c in sentence)
            {
                string temp = c.ToString();
                if(c == ' ')    //Adds 3 spaces between new words
                {
                    translatedSentence += "   ";
                }
                else
                {
                    for(int i = 0; i < 36; i++) //Runs through array until match is found
                    {                           //Then adds on the morse tranlation to the new sentence 
                        if(temp.Equals(morseCode[i,0]))
                        {
                            translatedSentence += morseCode[i, 1] + " "; //Also adds space between each morse character
                            break;
                        }
                    }
                }
            }
            return translatedSentence;
        }

    }
}
