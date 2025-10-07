using System;

internal class ValueChecker
{
    public void CheckType(object input) {
        Console.WriteLine(input.GetType().Name);
    }

}