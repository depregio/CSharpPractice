//Subscribing to events

//Subscribing to an event means registering a handler method that will be called when the event is raised.
//Events can have multiple handlers, they all execute when the event is raised.

//Use += to add event handlers.
//Use -= to remove a handler when you no longer want notifications.


//The += operator
button.Click += HandleClick;        //Subscribe with a named method

button.Click += (sender) => Console.WriteLine("Clicked!");      //Subscribe with a lambda expression

button.Click += delegate (object sender) { Console.WriteLine("Clicked!"); };        //Subscribe with an anonymous method


//Multiple subscribers
timer.Elapsed += LogToConsole;      //All three methods run when Elapsed fires  
timer.Elapsed += LogToFile;
timer.Elapsed += UpdateUI;


//The -= operator
button.Click -= HandleClick;        //Stop listening



//Test: an OrderProcessor class has two events: OrderReceived and OrderCompleted.
//      Subscribe handlers to both events that print messages when orders are processed.
public delegate void OrderHandler(string orderName);        //custom delegate type

public class OrderProcessor
{
    public event OrderHandler OrderReceived;
    public event OrderHandler OrderCompleted;

    public void ProcessOrder(string orderName)
    {
        OrderReceived?.Invoke(orderName);
        // Simulate processing
        OrderCompleted?.Invoke(orderName);
    }
}

public class Solution
{
    public static void RunOrderSystem(string[] orderNames)
    {
        OrderProcessor processor = new OrderProcessor();

        processor.OrderReceived += (orderName) => Console.WriteLine($"Order received: {orderName}");
        
        processor.OrderCompleted += (orderName) => Console.WriteLine($"Order completed: {orderName}");

        // Process each order
        foreach (string order in orderNames)
        {
            processor.ProcessOrder(order);
        }
    }
}