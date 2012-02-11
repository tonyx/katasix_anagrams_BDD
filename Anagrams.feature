Feature: Addition
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

#@mytag
Scenario: An empty dictionary
	Given I have an empty dictionary  
#	And I have entered 70 into the calculator
	When I ask for the anagrams of the word xxx
	Then the result should be an empy set of angrams

Scenario: Dictionary with a single word
	Given I have dictionary containing the words: foo   
#	And I have entered 70 into the calculator
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



#Scenario: Dictionary with three words, two are anagrams and one is not
#	Given I have dictionary containing the words "foo" "oof" "xxx"   
#	And I have entered 70 into the calculator
#	When I ask for the anagram of the words "foo"
#	Then the result should be a set not containing the words "xxx"