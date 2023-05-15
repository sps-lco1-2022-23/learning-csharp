# Peter's Pumps

This is based on a (very) old AS Level paper. There are several moving parts for the requirements of this assignment, as laid out in points 1-6 in the PDF and (optionally) saving in somewhere. 

(In those old days, you were given this specification and allowed to take in code into the exam. You were then asked questions, for which your prepared work might have been useful.) 

Your solution should have multiple projects:
- a class library containing the useful objects and the calculations/logic 
- a unit test project to test the concrete aspects of the classes 
- a Console App that offfers the core functionality on the command line
- (optionally) a GUI application to contain the window that uses the objects (see below). 

You should also consider storing data in a text file / JSON / Database (?!) to be able to save and load sessions. 

## The UI 

A definitely tough part here is the live visualisation of the output via an app (perhaps a GUI as introduced in the WinForms OOPDraw work) perhaps using "simple" line drawing to mimic the 7-segment LEDs or some other visual analogy, e.g. using [ASCII line art](https://en.wikipedia.org/wiki/Box-drawing_character); redrawing live on a command line is not impossible (e.g. [1](https://stackoverflow.com/questions/24918768/progress-bar-in-console-application) [2](https://www.nuget.org/packages/ShellProgressBar) [3](https://blog.elmah.io/building-a-command-line-tool-with-progress-bar-in-net-core/)). 

A much harder option you might choose to use either one form or window split into multiple sections for the pump and output console or, better, in completely separate windows. You are free to use whichever graphics library you wish - WinForms, WPF, [JavaScript inside a web page](https://dotnet.microsoft.com/en-us/apps/aspnet/web-apps), or even Microsoft's new(ish) [MAUI](https://learn.microsoft.com/en-us/dotnet/maui/what-is-maui).   

You will therefore need to: 

- handling events to mimic the actions in the GUI 
- sketch/wireframe the possible windows 
- how to test it is working 

### Possibly useful GUI links

- [.NET Core GUIs are not easy](https://www.reddit.com/r/dotnet/comments/5o59tz/easiest_way_to_put_a_gui_on_net_core_app/?onetap_auto=true)
- [Drawing a line in C# WinForms](http://stackoverflow.com/questions/5278149/draw-line-in-c-sharp)
- [More general C# drawing](https://docs.microsoft.com/en-us/dotnet/desktop/winforms/advanced/graphics-and-drawing-in-windows-forms?view=netframeworkdesktop-4.8)
- [WPF Hello World](https://docs.microsoft.com/en-us/visualstudio/get-started/csharp/tutorial-wpf?view=vs-2022)
- [Mac UI](https://docs.microsoft.com/en-us/xamarin/mac/get-started/hello-mac)
