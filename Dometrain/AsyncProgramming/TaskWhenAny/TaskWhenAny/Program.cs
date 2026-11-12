//Task.WhenAny

//Task.WhenAny returns as soon as any one of the provided tasks completes, rather than waiting for all of them like Task.WhenAll.

//Common use cases:
//      Racing multiple data sources (use fastest response)
//      Implementing timeouts
//      First-response-wins scenarios


//Basic usage
Task<int> task1 = GetValueAsync(100);  //Takes 100ms
Task<int> task2 = GetValueAsync(50);   //Takes 50ms
Task<int> task3 = GetValueAsync(200);  //Takes 200ms

Task<int> winner = await Task.WhenAny(task1, task2, task3); //Returns the task that finished first (task2)
int result = await winner;  //Gets the actual result of the already-completed task.


//Important: double await pattern
Task<string> firstTask = await Task.WhenAny(tasks); //WhenAny returns a Task<Task<T>>, not Task<T> (when all have same T). It gets the winning task.
string result2 = await firstTask;   //This await is instant. The result is already known because it was the first one to complete.



//Test: create three async tasks that each return a message after a specified delay.
//      Use Task.WhenAny to return the message from whichever task completes first.
public class Solution
{
    public static async Task<string> FirstToCompleteAsync(string message1, int delay1, string message2, int delay2, string message3, int delay3)
    {
        Task<string> msgTask1 = DelayedMessageAsync(message1, delay1);
        Task<string> msgTask2 = DelayedMessageAsync(message2, delay2);
        Task<string> msgTask3 = DelayedMessageAsync(message3, delay3);

        Task<string> winningMsg = await Task.WhenAny(msgTask1, msgTask2, msgTask3);
        return await winningMsg;    //Without the second await you'd return a Task<string> where the method wants a string
                                    //(An async Task<string> method needs the unwrapped string to actually return to complete its "promise")
    }

    //Helper method to create delayed tasks:
    private static async Task<string> DelayedMessageAsync(string message, int delayMs)
    {
        await Task.Delay(delayMs);
        return message;
    }
}