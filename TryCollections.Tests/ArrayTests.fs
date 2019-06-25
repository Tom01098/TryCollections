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

    [<TestMethod>]
    member __.TryAverageByPass () =
        let result = 
            [|1.; 4.; 7.|]
            |> Array.tryAverageBy (fun x -> x * 2.)
        Assert.AreEqual(Some 8., result)

    [<TestMethod>]
    member __.TryAverageByFail () =
        let result = 
            Array.empty<float>
            |> Array.tryAverageBy (fun x -> x * 2.)
        Assert.AreEqual(None, result)

    [<TestMethod>]
    member __.TryChunkBySizePass () =
        let result = 
            [|1.; 4.; 7.|]
            |> Array.tryChunkBySize 2
        Assert.AreEqual(Some [|[|1.; 4.|]; [|7.|]|], result)

    [<TestMethod>]
    member __.TryChunkBySizeFail () =
        let result = 
            [|1.; 4.; 7.|]
            |> Array.tryChunkBySize 0
        Assert.AreEqual(None, result)
