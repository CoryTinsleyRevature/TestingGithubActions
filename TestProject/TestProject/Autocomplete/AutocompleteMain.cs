using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.Autocomplete
{
    class AutocompleteMain
    {

        public static void Autocomplete()
        {
            //SECTION 1: Read in the inputs from Sample Input.
            //Have a variable to store the incomplete word
            string input = "";                //incomplete word
            input = Console.ReadLine();       //reading incomplete word
            int lengthOfInput = input.Length; //grabbing the amount of characters the incomplete word has

            List<string> solutions = new List<string>();//the words that contain the prefix

            //Reading the possible completed words
            List<string> allInputs = new List<string>();//a list of all possible corrections (correct or incorrect)
            string currentInput = "";  //the current word beind added
            bool flag = true;
            while (flag)
            {
                currentInput = Console.ReadLine();
                if (currentInput.Length == 0)
                {
                    break;
                }
                else
                {
                    allInputs.Add(currentInput);
                }
            }

            //We will check each character of the input to each character of allInputs


            for (int i = 0; i < allInputs.Count; i++)
            {
                //check each char of input to each char of the current solutionQuery
                bool flag1 = true;
                for (int j = 0; j < lengthOfInput; j++)
                {
                    if (input[j] == allInputs[i][j])  //input = "do"  allInputs = {"dog","cat","donut",...}
                    {
                        continue;
                    }
                    else
                    {
                        flag1 = false;
                    }
                }
                if (flag1 == true)
                {
                    solutions.Add(allInputs[i]);
                }
            }

            //order the solutions alphabetically
            solutions.Sort();
            //dog\n       dog\n
            //donut\n     donut\n
            //dough\n     dough
            for (int k = 0; k < solutions.Count; k++)
            {
                if (k == solutions.Count - 1)
                {
                    Console.Write(solutions[k]);
                }
                else
                {
                    Console.WriteLine(solutions[k]);
                }
            }
        }



        public void Autocomplete2()
        {
            string sampleInput, sampleInput2;
            sampleInput = Console.ReadLine();

            List<string> newstringArray = new List<string>();
            sampleInput2 = Console.ReadLine();

            while (!string.IsNullOrEmpty(sampleInput2))
            {
                if (sampleInput2.Substring(0, sampleInput.Length).Equals(sampleInput))
                    newstringArray.Add(sampleInput2);
                sampleInput2 = Console.ReadLine();
            }
            foreach (string x in newstringArray)
            {
                Console.WriteLine(x);
            }

        }
    }
}


