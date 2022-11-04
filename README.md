# AnagramChecker

This console based program will ask the user for a user name, then for two words to compare as potential anagrams. 

Validation of the words should exclude special characters or numbers and is not case sensitive. 

If the user does not input the words (assumption is made for Latin characters), they will be asked to repeat their inputs.

The words are first compared by length to filter out cases where an anagram would be impossible.

They are then sorted via a character array and compared for matches, returning a boolean outcome

The console should then output to the user if the two words are anagrams of each other or not before writing the words (if unique) to an array that is stored as a text file with future disctinct inputs appended to it.

