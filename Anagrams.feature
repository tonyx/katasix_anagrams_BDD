Feature: KataSix anagrams
	In order to improve my vocabulary knowledge
	As a curious guy
	I want to be told how many anagrams of a given word are present in a dictionary

Scenario: An empty dictionary
	Given I have an empty dictionary  
	When I ask for the anagrams of the word xxx
	Then the result should be an empy set of angrams

Scenario: Dictionary with a single word
	Given I have dictionary containing the words: foo   
	When I ask for the anagram of the word foo
	Then the result should be a set containing the words: foo

Scenario: Dictionary with two words that are anagrams each other
	Given I have dictionary containing the words: foo, oof  
	When I ask for the anagram of the word foo
	Then the result should be a set containing the words: foo, oof

Scenario: Dictionary with three words that are no all anagrams 
	Given I have dictionary containing the words: foo, oof, xxx
	When I ask for the anagram of the word foo
	Then the result should not contain the words: xxx

Scenario: Dictionary with four words that are no all anagrams 
	Given I have dictionary containing the words: foo, oof, xxx, yyy
	When I ask for the anagram of the word foo
	Then the result should not contain the words: xxx, yyy

Scenario: Dictionary with few words that are no all anagrams 
	Given I have dictionary containing the words: foo, oof, ofo, xxx, yyy
	When I ask for the anagram of the word ofo
	Then the result should be a set containing the words: foo, oof,  ofo


