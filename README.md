## Word Counter Application Pt. 2

#### Epicodus C#:  7/6/2018

#### By Ryan Putman

## A MVC web application that allows users to enter a singular word and a string of words.  The program will compare the two values and return the number of times the singular word can be found in the string of words.

### Specs
| Spec | Input | Output |
| :-------------     | :------------- | :------------- |
| **User inputs singular word that is stored in a new string variable**| Input: "Dog!" | Output: "Dog!" |
| **User inputs list of words to compare against singular word. List of words is stored in new string.**| Input: "Is your dog happ$y" | Output: "Is your dog happ$y" |
| **Program checks that “singular” word input contains only one word**| Input: "Dog! " | Output: true |
| **Program checks that “singular” word does not contain any special characters**| Input: "Dog!" | Output: "False" |
| **Program checks that string of words does not contain any special characters**| Input: "Is your dog happ$y" | Output: "False" |
| **Program removes any spaces and special characters from “singular” word (if exists)**| Input: "Dog!" | Output: "Dog" |
| **Program removes special characters from string of words (if exists)**| Input: "Is your dog happ$y" | Output: "Is your dog happy" |
| **Program converts singular word to lowercase new string for matching**| Input: "Dog" | Output: "dog" |
| **Program converts string of words to lowercase new string for matching**| Input: "Is your dog happy" | Output: "is your dog happy" |
| **If program finds match, program will return number of times matched word appears in string of words.**| Input: "dog" | is your dog happy" | Output: "1" |

## Setup/Contribution Requirements

1. Follow the instructions for downloading C#, .NET Core 1.1 and Mono from: https://www.learnhowtoprogram.com/c/getting-started-with-c/installing-c
1. Clone the repo at https://github.com/putman10/Word-Counter-pt2
1. Make a new branch
1. Open project in Microsoft Visual Studio and click run to build web app.
1. Navigate to localserver:5000
1. Enter a singular word and string of words and hit Enter
1. Alternative you can navigate to project with terminal and run dotnet restore then dotnet build to run the project without Microsoft Visual Studio

## Technologies Used

* .NET Core 1.1 SDK
* .NET runtime
* Mono

## Links

* _[Here](https://github.com/putman10/Word-Counter) is the link to the Word Counter repository._

## License

This software is licensed under the MIT license.

Copyright (c) 2018 **Ryan Putman**
