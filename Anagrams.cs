using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnagramsKata
{       
    public class Anagrams
    {
        private HashSet<string> _words;

        public Anagrams(HashSet<string> words)
        {
            _words = words;
        }

        public HashSet<string> AnagramsOf(string aWord)
        {
            HashSet<string> toReturn = new HashSet<string>();
            foreach (string word in _words)
            {
                if (AreAnagrams(aWord, word))
                    toReturn.Add(word);
            }
            return toReturn;
        }

        private bool AreAnagrams(string word1, string word2)
        {
            Dictionary<char,int> occurWord1 = new Dictionary<char, int>();
            Dictionary<char,int> occurWord2 = new Dictionary<char, int>();

            MapOccurrences(word1, occurWord1);
            MapOccurrences(word2, occurWord2);

            if (!SameKeys(occurWord2, occurWord1)) return false;
            if (!SameOccurrences(occurWord2, occurWord1)) return false;

            return true;
        }

        private static bool SameOccurrences(Dictionary<char, int> occurWord2, Dictionary<char, int> occurWord1)
        {
            foreach (char c in occurWord1.Keys)
            {
                if (occurWord2[c] != occurWord1[c])
                    return false;
            }
            return true;
        }

        private static bool SameKeys(Dictionary<char, int> occurWord2, Dictionary<char, int> occurWord1)
        {
            foreach (char c in occurWord1.Keys)
            {
                if (!occurWord2.Keys.Contains(c))
                    return false;
            }
            return true;
        }

        private static void MapOccurrences(string word1, Dictionary<char, int> occurWord1)
        {
            foreach (char c in word1)
            {
                if (!occurWord1.Keys.Contains(c))
                    occurWord1.Add(c, word1.Select(x => x == c).Count());
            }
        }
    }
}
