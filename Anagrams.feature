Feature: Addition
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

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



