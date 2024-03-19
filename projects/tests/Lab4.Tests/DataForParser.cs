using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab4.Tests;

public static class DataForParser
{
    public static IEnumerable<object[]> TestData()
    {
        return new List<object[]>
        {
            new object[]
            {
                "connect /Users/artemzovnir -m local",
                "file show /Users/artemzovnir/Lab4/Fold2/FileTwo.txt -m console",
                "file move /Users/artemzovnir/Lab4/Fold2/FileTwo.txt /Users/artemzovnir/Lab4/Fold1/FileTwo.txt",
                "file copy /Users/artemzovnir/Lab4/Fold1/FileOne.txt /Users/artemzovnir/Lab4/Fold2/FileOne.txt",
                "file delete /Users/artemzovnir/Lab4/Fold2/FileOne.txt",
                "file rename /Users/artemzovnir/Lab4/Fold2/FileTwo.txt NewFileTwo.txt",
            },
        };
    }
}