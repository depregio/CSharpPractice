//Events in C#

//Events provide a way for a class to notify other classes when something of interest occurs.
//They follow the publisher-subscriber pattern where one class publishes an event and other classes subscribe to receive notifications.

//An event is a list of methods that gets called when something happens. It’s a delegate with one safety restriction.
//The publisher keeps a list of methods. Subscribers add their method to the list with +=.
//When something happens, the publisher calls everything on the list.

//Event = when the publisher fires it, every subscribed method is called in order, then control returns to the publisher.

//The key point is that the publisher doesn’t know who is listening.
//Button has no idea what should happen on a click. It just says “I was clicked” to whoever signed up.
//This means you can add or remove reactions without changing Button.

//EventHandler is the standard delegate type for events in .NET.EventHandler<T> allows you to pass custom data with the event.


//The event Keyword
public event EventHandler MyEvent;                  //Declares an event using a delegate type
                                                    //Events can only be raised from within the class that declares them.
public event EventHandler<string> MessageReceived;  //Declare an event with custom data using EventHandler<T>


//EventHandler delegate type
public class Button
{
    public event EventHandler Clicked;  //EventHandler signature:       void EventHandler(object sender, EventArgs e)
                                        //EventHandler<T> signature:    void EventHandler<T>(object sender, T e)
    public void OnClick()
    {
        Clicked?.Invoke(this, EventArgs.Empty);     //Use ?. to safely invoke (handles null if no subscribers)
    }
}


//Subscribing to events
var button = new Button();
                                                                            //Subscribe using a lambda
button.Clicked += (sender, e) => Console.WriteLine("Button was clicked!");  //Use += to subscribe and -= to unsubscribe from events.

button.Clicked += HandleClick;                                              //Or subscribe using a method

void HandleClick(object sender, EventArgs e)
{
    Console.WriteLine("Handling click!");
}



//Test: create a TemperatureMonitor class with an event that fires when the temperature reaches a critical level (>= 100 degrees).
//          Declare a TemperatureAlert event using EventHandler<int>
//          In CheckTemperature(), raise the event if temperature >= 100
//          In RunTemperatureMonitor(), subscribe to the event and print an alert message
public class TemperatureMonitor
{
    public event EventHandler<int> TemperatureAlert;    //1 - The list of listeners

    public void CheckTemperature(int temperature)       //2 - Called when the click happens
    {
        if(temperature >= 100)
            TemperatureAlert?.Invoke(this, temperature);    //3 - Calls every method on the list and pass the arguments
    }
}

public class Solution
{
    public static void RunTemperatureMonitor(int[] temperatures)
    {
        var monitor = new TemperatureMonitor();


        monitor.TemperatureAlert += (sender, temperature) =>    //4 - Adds a method to the list
        Console.WriteLine($"ALERT: Temperature is {temperature} degrees!");

        foreach (int temp in temperatures)
        {
            monitor.CheckTemperature(temp);
        }
    }
}



/*
An easy example of everyting:

public class Button
{
    public event EventHandler Clicked;      // empty list, Clicked is null

    public void SimulateClick()             // stands in for "the user clicked"
    {
        Console.WriteLine("Button: firing event");
        Clicked?.Invoke(this, EventArgs.Empty);
        Console.WriteLine("Button: done firing");
    }
}

// Program
var button = new Button();                  // step 1: create the publisher

button.Clicked += SayHi;                    // step 2: subscribe (adds to list)
button.Clicked += (s, e) => Console.WriteLine("Lambda ran");

Console.WriteLine("Before click");
button.SimulateClick();                     // step 3: something happens
Console.WriteLine("After click");

void SayHi(object sender, EventArgs e) => Console.WriteLine("SayHi ran");
*/