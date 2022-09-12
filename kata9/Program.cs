using System;
using System.Collections.Generic;


//What is an anagram ? Well,
//two words are anagrams of each other if they both contain the same letters. For example:

//'abba' & 'baab' == true

//'abba' & 'bbaa' == true

//'abba' & 'abbba' == false

//'abba' & 'abca' == false

//Write a function that will find all the anagrams of a word from a list. 
//You will be given two inputs a word and an array with words.
//You should return an array of all the anagrams or an empty array if there are none. For example:

//anagrams('abba', ['aabb', 'abcd', 'bbaa', 'dada']) => ['aabb', 'bbaa']

//anagrams('racer', ['crazer', 'carer', 'racar', 'caers', 'racer']) => ['carer', 'racer']

//anagrams('laser', ['lazing', 'lazy', 'lacer']) => []

namespace kata9
{
    public static class Kata
    {
        public static List<string> Anagrams(string word, List<string> words)
        {
            List<string> answer = new List<string>();
            string s = string.Empty;
            string p = string.Empty;


            foreach (string wor in words)
            // { "carer", "arcre", "carre", "racrs", "racers", "arceer", "raccer", "carrer", "cerarr" }
            {
                // string q = wor;
                if (wor.Length != word.Length)
                    continue;
                else
                {

                    foreach (char l in wor)
                    {

                        if (word.Contains(l))
                        {
                            s = s + l;
                        }
                        else if (wor.Length != word.Length)

                        {
                            s = string.Empty;
                            break;
                        }
                        else
                        {
                            s = string.Empty;
                            break;
                        }
                        
                    }
                }
                if (s != string.Empty)
                {
                    answer.Add(s);
                    s = string.Empty;
                }

            }


            foreach (string x in answer)
            {
                Console.WriteLine(x);
                // "carer", "arcre", "carre"
            }

            return answer;



        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.Anagrams("racer", new List<string> { "carer", "arcre", "carre", "racrs", "racers", "arceer", "raccer", "carrer", "cerarr" }));
        }
    }
}
