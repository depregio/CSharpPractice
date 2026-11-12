//Task.WhenAll

//Task.WhenAll allows you to run multiple async operations in parallel and wait for all of them to complete.
//This is much faster than awaiting each task sequentially.

//If any task faults, await WhenAll throws only the first exception and the others remain hidden.
//Inspect resultTask.Exception to see them all (AggregateException).


//Sequential vs parallel execution
var result1 = await GetDataAsync(1);        //Sequential. Each task waits for the previous one (slow).
var result2 = await GetDataAsync(2);        //Total time: delay1 + delay2 + delay3.
var result3 = await GetDataAsync(3);

var task1 = GetDataAsync(1);                //Parallel. All tasks run at the same time (fast).
var task2 = GetDataAsync(2);                //Total time: max(delay1, delay2, delay3).
var task3 = GetDataAsync(3);                            //Here var is Task<T>
var results = await Task.WhenAll(task1, task2, task3);  //Here var is T[]


//Using Task.WhenAll
Task<string> nameTask = FetchNameAsync();
Task<string> cityTask = FetchCityAsync();
                                                            //With tasks that return the same type:
string[] results2 = await Task.WhenAll(nameTask, cityTask); //You get an array of results, in the same order as the tasks you passed in     
string name = results2[0];
string city = results2[1];


Task<string> countryTask = FetchCountryAsync();
Task<int> ageTask = FetchAgeAsync();
                                            //With tasks that return the different types:
await Task.WhenAll(countryTask, ageTask);   //Await them together, then read each result.
string country = await countryTask;         //Already finished, so this returns right away. 
int age = await ageTask;                    //The per-task awaits below just unwrap values found by the WhenAll line.



//Test: implement SumOfThreeDelaysAsync that runs three async operations in parallel using Task.WhenAll.
//      Each operation uses the provided ProcessValueAsync helper which doubles a value after a delay.
//              Start three calls to ProcessValueAsync with each value/delay pair
//              Use Task.WhenAll to wait for all three to complete simultaneously
//              Return the sum of all three results
public class Solution
{
    public static async Task<int> SumOfThreeDelaysAsync(int value1, int delay1, int value2, int delay2, int value3, int delay3)
    {
        Task<int> numTask1 = ProcessValueAsync(value1, delay1);
        Task<int> numTask2 = ProcessValueAsync(value2, delay2);
        Task<int> numTask3 = ProcessValueAsync(value3, delay3);

        int[] numTaskResults = await Task.WhenAll(numTask1, numTask2, numTask3);

        return numTaskResults[0] + numTaskResults[1] + numTaskResults[2];
    }

    //Helper method to simulate an async operation
    private static async Task<int> ProcessValueAsync(int value, int delayMs)
    {
        await Task.Delay(delayMs);
        return value * 2;
    }
}