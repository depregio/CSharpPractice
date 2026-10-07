/*
Software testing:

    Software testing categories can be organized under the types of testing, the approaches to testing, or a combination of both.

    One way to categorize the types of testing is to split testing into Functional and Non-functional testing.
    The functional and nonfunctional categories each include subcategories of testing. 
    For example, functional and nonfunctional testing could be divided into the following subcategories:
        
        Functional testing - Unit testing - Integration testing - System testing - Acceptance testing
        Non-functional testing - Security testing - Performance testing - Usability testing - Compatibility testing

    Although software testing is its own specialized discipline, some level of testing is expected before a developer hands off their work. 
    When developers are assigned a formal role in the testing process, it's often at the level of unit testing.


Exception handling:
    
    In C# development, the errors that occur while the application is running are referred to as exceptions.
    **The term "exception handling" refers to the process that a developer uses to manage those runtime exceptions within their code.**

    If an application generates an exception, and that exception isn't managed in code, it can result in the application being shut down.
    C# provides a way for you to "try" the code that you know might generate an exception, and a way for you to "catch" any exceptions that do occur.

    Handling exceptions is definitely a responsibility of the developer.

    Errors that occur during the build process are referred to as errors, and aren't part of the exception handling process.


Code debugging:

    **Code debugging is a process that developers use to isolate an issue and identify one or more ways to fix it.**
    The issue could be related to either code logic or an exception. 
    Either way, you work on debugging your code when it isn't working the way you want it to. 
    
    Generally speaking, the term debugging is reserved for runtime issues that aren't easy to isolate. 
    Therefore, fixing syntax issues such as a missing ";" at the end of a code statement, isn't normally considered debugging.
    Code debugging tries to avoid exceptions. Exception handling finds a way to work with them.

    Code debugging is definitely a developer responsibility as well.

    For example:
*/
        string[] students = new string[] {"Sophia", "Nicolas", "Zahirah", "Jeong"};
        int studentCount = students.Length;
        Console.WriteLine("The final name is: " + students[studentCount]);
/*
    At first glance, everything seems fine. However, this code generates an exception when attempting to print the student name to the console. 
    The developer forgot that arrays are zero-based. The final name in the array should be accessed using students[studentCount - 1].

    There are tools and approaches that you can use to track down issues that are hard to find.


Debugger:
    
    A debugger is a software tool used to observe and control the execution flow of your program with an analytical approach.
    Debuggers help you isolate the cause of a bug and help you resolve it. A debugger connects to your code using one of two approaches:

        By hosting your program in its own execution process.
        By running as a separate process that's attached to your running program.


    Debuggers come in different flavors. Some work directly from the command line while others come with a graphical user interface. 
    For an intro to Visual Studio debugger tools: https://learn.microsoft.com/en-us/visualstudio/debugger/debugger-feature-tour?view=visualstudio

    Every debugger has its own set of features. The two most important features that come with almost all debuggers are:

        Control of your program execution:
            You can pause your program and run it step by step, which allows you to see what code is executed and how it affects your program's state.
        Observation of your program's state: 
            You can look at the value of your variables and function parameters and more at any point during your code execution.

    **Mastering the use of a code debugger is an important skill. Unfortunately, it's a skill that developers often overlook.**


Using Exceptions:

    You can think of an exception as a variable (an object) that has extra capabilities. 
    You can do the same type of things with exceptions that you do with variables, for example:

        You can create different types of exceptions.
        You can access the contents of an exception.

    This means that you can write code that accesses the exception and take corrective action.
    
    At runtime, exceptions are "thrown" (created) by code that encounters an error.
    You can "catch" (manage) them with your code and take corrective action to mitigate the error.
*/

