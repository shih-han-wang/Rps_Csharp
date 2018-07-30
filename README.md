Rock, Paper, Scissors
====================

This is a console application written in c#.
A match takes place between 2 players and is made up of 3 games, with the overall winner being the first player to win 2 games (i.e. best of 3).
Each game consists of both players selecting one of Rock, Paper or Scissors.

![rps_console](https://user-images.githubusercontent.com/36331920/43415423-68189368-942d-11e8-8674-62addd467cea.png)

## Table of content

- [Usage](#usage)
- [Test](#test)
- [My approach](#my-approach)
- [Improvement](#improvement)

## Usage

- Clone this repo, run: 
```
git clone https://github.com/shihhanwang/Rps_Csharp.git
```
- Compile in Visual Studio 20xx and run the program.

## Test

- Testing tool: [NUnit](https://nunit.org/)

![rps_tests](https://user-images.githubusercontent.com/36331920/43415425-6877c00e-942d-11e8-8e2d-9f374b2a82ef.png)

## My Approach

- As I had no experience with C# prior to this tech test, I spent a while on C# tutorials and understanding how to use Visual Studio for Mac.
- I started by breaking down the big task into small segments and planning the logical interactions between the classes. 
- Using TDD approach, I started to write the `Player` and `Game` classes as they are the main objects of this program. At the same time, I wrote the `Message` class for the console program messages and the `Helper` for console readline validation and conversion. 
- Then I started to write `AIMove` class, which would deal with the choice of computer, with the method of returning random choice. After allocating 2 players' choice, I wrote the `Rule` class, which would define the turn winner. 
- Then I combined all the logics into program and then wrote the new method for `AIMove` of returning tactical choice. 
- The match is made up for 3 games by default, but it can be changed into any odd numbers and the logics of the game would still work. In `Program.cs`, you can add the third arg as the turn time into `Game game = new Game(p1, p2);`. For example:

5 games match
```
Game game = new Game(p1, p2, 5);
```
7 games match
```
Game game = new Game(p1, p2, 7);
```

## Improvement

- Mocking tests. 
  - I tried to use [Moq](https://github.com/Moq/moq4/wiki/Quickstart) to mock the objects but I was faced with a `System.NotSupportedException` error. I decided to move on without mocking the objects and will try different mocking approach after completing the requirements. 

- As C# is a completly new language for me, I believe some of the syntax and structure of the code could be improved and refactored.
