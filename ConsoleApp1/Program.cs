using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] inputs)
        {
            if(inputs == null || inputs.Length == 0)
            {
                inputs = new string[2];
                inputs[0] = "geeks";
                inputs[1] = "for";
            }

            foreach (string input in inputs)
            {
                string output = Sort(input.ToCharArray());
                output = Reverse(output.ToCharArray());
                Console.WriteLine(output.ToString());
            }
        }

        static string Sort(char[] input)
        {
            //bubble sort for simplicity and brevity of code
            bool notSorted = true;
            while (notSorted)
            {   notSorted = false;
                for(int i = 0; i < input.Length -1; i++)
                {
                    if (input[i] > input[i+1])
                    {
                        char tmp = input[i];
                        input[i] = input[i+1];
                        input[i+1] = tmp;
                        notSorted = true;
                    }   
                } 
            }
            return new string(input);
        }

        static string Reverse(char[] input)
        {
            for (int i = 0; i < input.Length / 2; i++)
            {
                char tmp = input[i];
                input[i] = input[input.Length - 1 - i];
                input[input.Length - 1 - i] = tmp;
            }
            return new string(input);
        }
    }
}
