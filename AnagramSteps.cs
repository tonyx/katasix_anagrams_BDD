using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace AnagramsKata
{
    [Binding]
    class AnagramSteps
    {
        private Anagrams anagrams;
        private HashSet<String> words;
        private HashSet<String> anagramList;
        
        [Given(@"I have an empty dictionary")]
        public void GivenAnEmptyDictionary()
        {
            words = new HashSet<string>();
            anagrams = new Anagrams(words);
        }

        [When(@"I ask for the anagrams of the word (.*)")]
        public void WhenIAskForTheAnagramsOfTheWord(string word)
        {
            anagramList = anagrams.AnagramsOf(word);
        }

        [Then(@"the result should be an empy set of angrams")]
        public void ThenTheResultShouldBeAnEmptySetOfAnagrams()
        {
            Assert.That(0, Is.EqualTo(anagramList.Count));
        }

        [Given(@"I have dictionary containing the words: (.*)")]
        public void GivenIHaveDictionaryContainingTheWordsFoo(string word)
        {
            words = new HashSet<string>();
            foreach (string singleWord in word.Split(','))
            {
                words.Add(singleWord.Trim());
            }
            anagrams = new Anagrams(words);
        }

        [When(@"I ask for the anagram of the word (.*)")]
        public void WhenIAskForTheAnagramOfWordFoo(string word)
        {
            anagramList = anagrams.AnagramsOf(word);
        }

        [Then(@"the result should be a set containing the words: (.*)")]
        public void ThenTheResultShouldBeASetContainingTheWordsFoo(string word)
        {
            string[] wordList = word.Split(',');
            foreach (string singleWord in wordList)
            {
                Assert.That(anagramList.Contains(singleWord.Trim()));
            }
        }

        [Then(@"the result should not contain the words: (.*)")]
        public void ThenTheResultShouldNotContainTheWords(string word)
        {
            string[] wordList = word.Split(',');
            foreach (string singleWord in wordList)
            {
                Assert.IsFalse(anagramList.Contains(singleWord.Trim()));
            }
        }


       
    }
}
