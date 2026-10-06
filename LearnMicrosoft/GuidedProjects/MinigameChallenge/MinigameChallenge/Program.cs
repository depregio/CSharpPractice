/*
Project description:
 
    - The code declares the following variables:
        - Variables to determine the size of the Terminal window.
        - Variables to track the locations of the player and food.
        - Arrays `states` and `foods` to provide available player and food appearances
        - Variables to track the current player and food appearance
    
    - The code provides the following methods:
        - A method to determine if the Terminal window was resized.
        - A method to display a random food appearance at a random location.
        - A method that changes the player appearance to match the food consumed.
        - A method that temporarily freezes the player movement.
        - A method that moves the player according to directional input.
        - A method that sets up the initial game state.
    
    - The code doesn't call the methods correctly to make the game playable. The following features are missing:
        - Code to determine if the player has consumed the food displayed.
        - Code to determine if the food consumed should freeze player movement.
        - Code to determine if the food consumed should increase player movement.
        - Code to increase movement speed.
        - Code to redisplay the food after it's consumed by the player.
        - Code to terminate execution if an unsupported key is entered.
        - Code to terminate execution if the terminal was resized.
*/
Random random = new Random();
Console.CursorVisible = false;
int height = Console.WindowHeight - 1;
int width = Console.WindowWidth - 5;
bool shouldExit = false;

// Console position of the player
int playerX = 0;
int playerY = 0;

// Console position of the food
int foodX = 0;
int foodY = 0;

// Available player and food strings
string[] states = { "('-')", "(^-^)", "(X_X)" };
string[] foods = { "@@@@@", "$$$$$", "#####" };

// Current player string displayed in the Console
string player = states[0];

// Index of the current food
int food = 0;

InitializeGame();

while (!shouldExit)
{
    if (TerminalResized())  //You could put this check inside Move(), but that would make said method do more than what it was planned for. 
    {
        Console.Clear();
        Console.WriteLine("Console was resized. Program exiting.");
        shouldExit = true;
    }
    else
    {
        Move(exitOnOtherKey: true);

        if(FoodConsumed())
        {
            ClearFood();
            ShowFood();
            ChangePlayer();
        }

    }
}


//
bool FoodConsumed ()    //return playerX==foodX && playerY==foodY; considers only if player eats the first food character
{
    return 
        playerY == foodY
        && playerX < foodX + foods[food].Length
        && foodX < playerX + player.Length;
}
// Returns true if the Terminal was resized 
bool TerminalResized()
{
    return height != Console.WindowHeight - 1 || width != Console.WindowWidth - 5;
}

// Displays random food at a random location
void ShowFood()
{
    // Update food to a random index
    food = random.Next(0, foods.Length);

    // Update food position to a random location            //Food can never spawn in same column or row as player.
    foodX = random.Next(0, width - player.Length);
    foodY = random.Next(0, height - 1);

    // Display the food at the location
    Console.SetCursorPosition(foodX, foodY);
    Console.Write(foods[food]);
}

//Clears the old food string displayed in case only a part of it was eaten.
void ClearFood()                    //Needed because partial overlap can leave old food on screen, which wouldn't be interactable anymore.
{
    Console.SetCursorPosition(foodX, foodY);
    for (int i = 0; i < foods[food].Length; i++)
    {
        Console.Write(" ");         //Mind you this also deletes player character since they overlap position. Redraw the player afterward.
    }
}
// Changes the player to match the food consumed
void ChangePlayer()
{
    player = states[food];
    Console.SetCursorPosition(playerX, playerY);
    Console.Write(player);
}

// Temporarily stops the player from moving
void FreezePlayer()
{
    System.Threading.Thread.Sleep(1000);
    player = states[0];
}

// Reads directional input from the Console and moves the player
void Move(bool exitOnOtherKey = false)  //For bool variable names you can use is, has, can, should, on.
{                                             //The official solution doesn't make sense here. It's wrong.
    int lastX = playerX;
    int lastY = playerY;

    switch (Console.ReadKey(true).Key)      //This is where the game waits.
    {
        case ConsoleKey.UpArrow:
            playerY--;
            break;
        case ConsoleKey.DownArrow:
            playerY++;
            break;
        case ConsoleKey.LeftArrow:
            playerX--;
            break;
        case ConsoleKey.RightArrow:
            playerX++;
            break;
        case ConsoleKey.Escape:
            shouldExit = true;
            Console.Clear();
            return;              //Doesn't return anything, exits the method in advance to terminate game.
        default:                
            if (exitOnOtherKey)  //If any other key is pressed while requested to check, exit game.
            {
                shouldExit = true;
                Console.Clear();
                return;         
            }
            break;
    }

    // Clear the characters at the previous position
    Console.SetCursorPosition(lastX, lastY);
    for (int i = 0; i < player.Length; i++)
    {
        Console.Write(" ");
    }

    // Keep player position within the bounds of the Terminal window
    playerX = (playerX < 0) ? 0 : (playerX >= width ? width : playerX);
    playerY = (playerY < 0) ? 0 : (playerY >= height ? height : playerY);

    // Draw the player at the new location
    Console.SetCursorPosition(playerX, playerY);
    Console.Write(player);
}

// Clears the console, displays the food and player
void InitializeGame()
{
    Console.Clear();
    ShowFood();
    Console.SetCursorPosition(0, 0);
    Console.Write(player);
}