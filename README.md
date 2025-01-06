# C# Static Context Error
This repository demonstrates a common error in C#: attempting to access a non-static member from a static context.  The code in `Bug.cs` showcases the error, while `BugSolution.cs` provides the corrected version.

## Problem
In C#, static members belong to the class itself, not to a specific instance of the class.  Therefore, you cannot directly access non-static members (instance members) from within a static method.

## Solution
The solution involves either making the member static or creating an instance of the class to access the non-static member.
