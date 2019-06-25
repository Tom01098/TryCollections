namespace TryCollections.Tests

open System
open Microsoft.VisualStudio.TestTools.UnitTesting

[<TestClass>]
type TestClass () =

    [<TestMethod>]
    member __.TryAveragePass () =
        let result = 
            [|1.; 4.; 7.|]
            |> Array.tryAverage
            
        Assert.AreEqual(Some 4., result)

    [<TestMethod>]
    member __.TryAverageFail () =
        let result = 
            Array.empty<float>
            |> Array.tryAverage
            
        Assert.AreEqual(None, result)
