# _Word Counter Program with MVC_

#### _Week 7 Independent Project for Epicodus, 9.18.2018_

#### By _**Catherine Bradley**_

## Description

_This is a C# program with MVC._

_Word Counter Program allows Users to know how many times a given word appears in a given text. Users enter text and then the program asks the User to enter a word. The program returns a number representing how frequently that word appeared in the text._

### Specifications

* _1) User is greeted by a slash page_
* _2) User navigates to Word Counter app and is able to create a new word counter checker._
* _3) User enters text (first input) and a keyword (second input) and clicks a submit button_
* _5) User sees their first input and second input added to a list along with a number of how frequently their keyword appeared in their text._

  * Example Input(Text): _Hello there, Cat. I love my cat! Where are you, cat? She says she has a 'cat.'_
  * Example Input(second): _cat_
  * Example Output: _Your keyword "cat" appeared 4 time(s)_

_Program can account for capitalization:_
  * Example Input(Text): _cat CAT cAt CaT cAT Cat_
  * Example Input(word): _cat_
  * Example Output: _Your keyword "cat" appeared 6 time(s)_

_Program can account for basic grammar_
  * Example Input(Text): _cat! cat. 'cat' cat? 'cat!'_
  * Example Input(word): _cat_
  * Example Output: _Your keyword "cat" appeared 5 time(s)_

## Setup/Installation Requirements

* _Clone this repository_
* _Navigate to WordCounter.Solution/WordCounter_
* _Run app on localhost:5000_

## Known Bugs

* _Program can not account for words with "double quotes" but can for words with 'single quotes'_
* _Users can only enter one word at a time._
* _Users cannot search for a second keyword after their original text has been entered. User would have to reenter text with a second keyword._

## Support and contact details

_For feedback, please contact Catherine Bradley at catherinetybradley@gmail.com_

## Technologies Used

* _C#_
* _MVC_

### Legal

*NA*
