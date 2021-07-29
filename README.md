# MostlyGhostlyTextGame
This is a console text game that should run in Visual Studio by running MostlyGhostlyTextGame.cs. It is meant to meet the following features requirements:<br>
1.) Create a dictionary or list, populate it with several values, retrieve at least one value, and use it in your program (lines 188-194 ).<br>
2.) Use a LINQ query to retrieve information from a data structure (such as a list or array) or file (lines 198-200).<br>
3.) Build a conversion tool that converts user input to another type of and displays it (ex: converts cups to grams) (lines 236-237, 245-248).<br>

In gameplay, the dictionary and LINQ features are displayed in a randomly selected sentence on a screen before a promp asking the player if they will help the ghost and appears as: "The ghost _key_ / _value_."

The conversion tool appears if the player fails to guess the ghost's age and asks for the user to input their age, then converts that age to "ghost age," "years to complete unfinished business," and "frequency of ghost supervisor visits."

Options 1. "dark woods" and 2."spooky house" lead straight to "gameOver" and answering negatively ("no" or returning a false value) also leads to gameOver. The exception to this is the conversion tool in "public static void purgatory."

The path to winning the game is through option 3/hitchhiker, answer "yes" to her request for help, then correctly guess her randomly-generated age. Incorrectly guessing her age leads to the conversion tool, which then eventually leads to the "win" screen.

The win screen generates a random bit of doggerel from a series of arrays as a prize.


