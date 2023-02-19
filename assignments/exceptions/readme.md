# exceptions

Exceptions are used to capture situations where there is something wrong with the data that we're using. 
Exceptions are for dealing with the unexpected, especially where users are concerned, always expect the unexpected. 
They should not replace validation entirely, but they are useful

An exception itself is generated using the `throw` keyword, in the code where a problem might occur we use the keywords `try` and `catch` - we can catch several different types of exception. 
You can throw a new instance of any class inherited from the basic Exception class. 

There are many built in one, but you might find that it makes sense to define your own. 
As such new types of Exceptions can be defined, inheriting from the base `Exception` class. 

The Microsoft docs are, as always, a good place to start for more [information](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/exceptions/). 

## Exercise

The exercise for this week is [here](https://docs.google.com/document/d/1ZlUwGcGaMwo86b0umgmhspt93YluULvytHqSs-LXcDM/edit?usp=sharing). 
