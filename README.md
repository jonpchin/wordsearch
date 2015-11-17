# Scrabble
Scrabble Game in C#


Hello team,

We will be making Scrabble(word game) in C# using Visual Studio. I currently have Visual Studio 2015 Community edition as its free. I recommend we all use the same version. The project will have a main goal of supporting player vs computer. We will eventually support multiplayer using a server but that is a long way off.

Game Details:

    For the Scrabble board we have two options. Option one, our Scrabble game will have a 15x15 2D static array for backend to interact with the front end. Option two, we use object oriented style(using getter and setters) and have each Scrabble piece(an object) contain the score and letter. We most likely will have to do both options to have more flexibility to do advanced things later on.

    We will use a wordList to help aide the computer make a good decision on what words he should try to go for. We will be using Edit distance algorithm for this. I have a good word list of about 150,000 words on my laptop I'll look for it and upload it to the repo.

    We need a function to randomize the Scrabble letters and randomly select the player or computer to go first. This is usually done by someone picking a letter closest to A first for their first tile draw

    Another function to randomly distribute to the player and computer the seven starting tiles. The computers hand will not be shown obviously.

    Two levels of easy and hard. Easy will just randomly select tiles for the computer to place down while hard will use the edit algorithm.

    The Scrabble game will have a total of 100 tiles and 2 of those tiles are blank which are wild tiles.

    During a players turn, a player can do three options, place at least one tile on the board, exchange 1 or all of his tiles for new tiles, or pass. The computer also has these three options.

    Tiles can only be placed horizontally or vertically, not diagonally. The words must read from left to right or top to bottom.

    The game is won when all 100 tiles are used and the player/computer with the highest score wins.
    If any player/computers passes twice in a row the game will end and the person with the highest score wins.

Scoring:
Below are the point values for each letter that is used in a Scrabble game.

0 Points - Blank tile.

1 Point - A, E, I, L, N, O, R, S, T and U.

2 Points - D and G.

3 Points - B, C, M and P.

4 Points - F, H, V, W and Y.

5 Points - K.

8 Points - J and X.

10 Points - Q and Z.

Extra point values are awarded for multiple words and for placing tiles on the colored bonus point squares.
