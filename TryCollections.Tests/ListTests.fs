﻿namespace TryCollections.Tests

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

    [<TestMethod>]
    member __.TryFold2Pass () =
        let result = 
            ([|1; 2|], [|4; 2|])
            ||> Array.tryFold2 (fun x y z -> x + y + z) 0
        Assert.AreEqual(Some 9, result)

    [<TestMethod>]
    member __.TryFold2Fail () =
        let result = 
            ([1], [4; 2])
            ||> List.tryFold2 (fun x y z -> x + y + z) 0
        Assert.AreEqual(None, result)

    [<TestMethod>]
    member __.TryFoldBack2Pass () =
        let result = 
            ([1; 2], [4; 2])
            ||> List.tryFoldBack2 (fun x y z -> x + y + z) 0
        Assert.AreEqual(Some 9, result)

    [<TestMethod>]
    member __.TryFoldBack2Fail () =
        let result = 
            ([1], [4; 2])
            ||> List.tryFoldBack2 (fun x y z -> x + y + z) 0
        Assert.AreEqual(None, result)

    [<TestMethod>]
    member __.TryForall2Pass () =
        let result = 
            ([1; 2], [4; 2])
            ||> List.tryForall2 (=)
        Assert.AreEqual(Some false, result)

    [<TestMethod>]
    member __.TryForall2Fail () =
        let result = 
            ([1], [4; 2])
            ||> List.tryForall2 (=)
        Assert.AreEqual(None, result)

    [<TestMethod>]
    member __.TryIter2Pass () =
        let result = 
            ([1; 2], [4; 2])
            ||> List.tryIter2 (fun x y -> ignore (x, y))
        Assert.AreEqual(Some (), result)

    [<TestMethod>]
    member __.TryIter2Fail () =
        let result = 
            ([1], [4; 2])
            ||> List.tryIter2 (fun x y -> ignore (x, y))
        Assert.AreEqual(None, result)

    [<TestMethod>]
    member __.TryMap2Pass () =
        let result = 
            ([1; 2], [4; 2])
            ||> List.tryMap2 (fun x y -> x + y)
        Assert.AreEqual(Some [5; 4], result)

    [<TestMethod>]
    member __.TryMap2Fail () =
        let result = 
            ([1], [4; 2])
            ||> List.tryMap2 (fun x y -> x + y)
        Assert.AreEqual(None, result)

    [<TestMethod>]
    member __.TryMap3Pass () =
        let result = 
            ([1; 2], [4; 2], [2; 2])
            |||> List.tryMap3 (fun x y z -> x + y + z)
        Assert.AreEqual(Some [7; 6], result)

    [<TestMethod>]
    member __.TryMap3Fail () =
        let result = 
            ([1], [4; 2], [2; 2])
            |||> List.tryMap3 (fun x y z -> x + y + z)
        Assert.AreEqual(None, result)

    [<TestMethod>]
    member __.TryMaxPass () =
        let result = 
            [1.; 4.; 7.]
            |> List.tryMax
        Assert.AreEqual(Some 7., result)

    [<TestMethod>]
    member __.TryMaxFail () =
        let result = 
            List.empty<float>
            |> List.tryMax
        Assert.AreEqual(None, result)

    [<TestMethod>]
    member __.TryMaxByPass () =
        let result = 
            [1.; 4.; 7.]
            |> List.tryMaxBy (fun x -> x * 2.)
        Assert.AreEqual(Some 7., result)

    [<TestMethod>]
    member __.TryMaxByFail () =
        let result = 
            List.empty<float>
            |> List.tryMaxBy (fun x -> x * 2.)
        Assert.AreEqual(None, result)

    [<TestMethod>]
    member __.TryMinPass () =
        let result = 
            [1.; 4.; 7.]
            |> List.tryMin
        Assert.AreEqual(Some 1., result)

    [<TestMethod>]
    member __.TryMinFail () =
        let result = 
            List.empty<float>
            |> List.tryMin
        Assert.AreEqual(None, result)

    [<TestMethod>]
    member __.TryMinByPass () =
        let result = 
            [1.; 4.; 7.]
            |> List.tryMinBy (fun x -> x * 2.)
        Assert.AreEqual(Some 1., result)

    [<TestMethod>]
    member __.TryMinByFail () =
        let result = 
            List.empty<float>
            |> List.tryMinBy (fun x -> x * 2.)
        Assert.AreEqual(None, result)

    [<TestMethod>]
    member __.TryReducePass () =
        let result = 
            [1.; 4.; 7.]
            |> List.tryReduce (+)
        Assert.AreEqual(Some 12., result)

    [<TestMethod>]
    member __.TryReduceFail () =
        let result = 
            List.empty<float>
            |> List.tryReduce (+)
        Assert.AreEqual(None, result)

    [<TestMethod>]
    member __.TryReduceBackPass () =
        let result = 
            [1.; 4.; 7.]
            |> List.tryReduceBack (+)
        Assert.AreEqual(Some 12., result)

    [<TestMethod>]
    member __.TryReduceBackFail () =
        let result = 
            List.empty<float>
            |> List.tryReduceBack (+)
        Assert.AreEqual(None, result)