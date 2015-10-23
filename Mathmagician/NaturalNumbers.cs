using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    public class NaturalNumbers
    {
        //No one can change this
        private int first;

        /* Constructor. 
        Shares the same name as the method of a class. 
        Do not have return types. */
        public NaturalNumbers()
        {
            //internal data method
            first = 1;
        }

        public int GetNext(int x)
        {
            return x + 1;
        }

        public int GetFirst()
        {
            return first;
        }

        public int[] GetSequence()
        {
            return GetSequence(10);
        }

        public int[] GetSequence(int length)
        {
            List<int> output = new List<int>();
            output.Add(GetFirst());
            while (output.Count < length)
            {
                //give me the last thing on the list = output.Last()
                // give me the next number on the next sequence = GetNext(output.Last())
                // adds the output into the list = output.Add(GetNext(output.Last()));
                output.Add(GetNext(output.Last()));
            }

            return output.ToArray();
        }

        public string ToString(int[] array)
        {
            //Method three (The Winner)
            string output = String.Join(" ", array);

            /*
            Method one:
            for (int i = 0; i < array.Length; i++)
             {



                 if (array[i] == array.Last())
                 {
                     output += array[i].ToString();
                 } else
                 {
                     output += array[i].ToString() + " ";
                 }
                
            

        }*/
            /* 
             Method two
             output += array[i].ToString() + " ";
             return output.TrimEnd(); 
             */
            return output;
        }
    }
}
