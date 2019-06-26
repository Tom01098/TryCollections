namespace TryCollections.Tests

open Microsoft.VisualStudio.TestTools.UnitTesting

[<TestClass>]
type ListTests () =

    [<TestMethod>]
    member __.TryAveragePass () =
        let result = 
            [1.; 4.; 7.]
            |> List.tryAverage
        Assert.AreEqual(Some 4., result)

    [<TestMethod>]
    member __.TryAverageFail () =
        let result = 
            List.empty<float>
            |> List.tryAverage
        Assert.AreEqual(None, result)

    [<TestMethod>]
    member __.TryAverageByPass () =
        let result = 
            [1.; 4.; 7.]
            |> List.tryAverageBy (fun x -> x * 2.)
        Assert.AreEqual(Some 8., result)

    [<TestMethod>]
    member __.TryAverageByFail () =
        let result = 
            List.empty<float>
            |> List.tryAverageBy (fun x -> x * 2.)
        Assert.AreEqual(None, result)

    [<TestMethod>]
    member __.TryChunkBySizePass () =
        let result = 
            [1.; 4.; 7.]
            |> List.tryChunkBySize 2
        Assert.AreEqual(Some [[1.; 4.]; [7.]], result)

    [<TestMethod>]
    member __.TryChunkBySizeFail () =
        let result = 
            [1.; 4.; 7.]
            |> List.tryChunkBySize 0
        Assert.AreEqual(None, result)

    [<TestMethod>]
    member __.TryExactlyOnePass () =
        let result = 
            [1]
            |> List.tryExactlyOne
        Assert.AreEqual(Some 1, result)

    [<TestMethod>]
    member __.TryExactlyOneFail () =
        let result = 
            [1.; 4.; 7.]
            |> List.tryExactlyOne
        Assert.AreEqual(None, result)

    [<TestMethod>]
    member __.TryExists2Pass () =
        let result = 
            ([1; 2], [4; 2])
            ||> List.tryExists2 (fun x y -> x + y = 5)
        Assert.AreEqual(Some true, result)

    [<TestMethod>]
    member __.TryExists2Fail () =
        let result = 
            ([1; 3], [2])
            ||> List.tryExists2 (fun x y -> x + y = 5)
        Assert.AreEqual(None, result)