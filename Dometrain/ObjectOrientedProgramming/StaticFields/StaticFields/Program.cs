//Static Fields

//A static field belongs to the class itself, not to any specific instance.
//All instances share the same static field value, making it perfect for tracking class-wide information.


//Accessing static fields
using System.Reflection.Metadata;

int count = Counter.SharedValue;        //Via class name
int count2 = Counter.GetSharedValue();   //Through a static method (a non static method works too)


//Instance vs static fields
Counter a = new Counter();
Counter b = new Counter();

a.InstanceValue = 5;        //Only affects 'a'
Counter.SharedValue = 10;   //Affects the entire class

public class Counter
{
    public int InstanceValue = 0;       //Each object gets its own copy
    public static int SharedValue = 0;  //All objects share this one value

    public static int GetSharedValue()
    {
        return SharedValue;
    }
}



//Test: Use the Player class to complete the Solution class:
//          GetInstanceCount():         create 3 players(Alice, Bob, Charlie) and return the count
//          CreatePlayers(int count):   create the specified number of players and return the count

public class Solution
{
    public static int GetInstanceCount()
    {
        Player.ResetCount();

        Player alice = new Player("Alice");
        Player bob = new Player("Bob");
        Player charlie = new Player("Charlie");

        return Player.GetCount();
    }

    public static int CreatePlayers(int count)
    {
        Player.ResetCount();

        for(int i = 0; i<count; i++)
        {
            Player genericPlayer = new Player("Player"+(i+1));
        }

        return Player.GetCount();
    }
}

public class Player
{
    private static int instanceCount = 0;

    public string Name { get; private set; }

    public Player(string name)
    {
        Name = name;
        instanceCount++;
    }

    public static int GetCount()
    {
        return instanceCount;
    }

    public static void ResetCount()
    {
        instanceCount = 0;
    }
}