namespace TryCollections.Tests

open Microsoft.VisualStudio.TestTools.UnitTesting

[<TestClass>]
type ArrayTests () =

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

    [<TestMethod>]
    member __.TryGetPass () =
        let result = 
            Array.tryGet [|1.; 4.; 7.|] 2
        Assert.AreEqual(Some 7., result)

    [<TestMethod>]
    member __.TryGetFail () =
        let result = 
            Array.tryGet [|1.; 4.; 7.|] 3
        Assert.AreEqual(None, result)

    [<TestMethod>]
    member __.TryGetFail2 () =
        let result = 
            Array.tryGet [|1.; 4.; 7.|] -1
        Assert.AreEqual(None, result)

    [<TestMethod>]
    member __.TryMaxPass () =
        let result = 
            [|1.; 4.; 7.|]
            |> Array.tryMax
        Assert.AreEqual(Some 7., result)

    [<TestMethod>]
    member __.TryMaxFail () =
        let result = 
            Array.empty<float>
            |> Array.tryMax
        Assert.AreEqual(None, result)

    [<TestMethod>]
    member __.TryMaxByPass () =
        let result = 
            [|1.; 4.; 7.|]
            |> Array.tryMaxBy (fun x -> x * 2.)
        Assert.AreEqual(Some 7., result)

    [<TestMethod>]
    member __.TryMaxByFail () =
        let result = 
            Array.empty<float>
            |> Array.tryMaxBy (fun x -> x * 2.)
        Assert.AreEqual(None, result)

    [<TestMethod>]
    member __.TryMinPass () =
        let result = 
            [|1.; 4.; 7.|]
            |> Array.tryMin
        Assert.AreEqual(Some 1., result)

    [<TestMethod>]
    member __.TryMinFail () =
        let result = 
            Array.empty<float>
            |> Array.tryMin
        Assert.AreEqual(None, result)

    [<TestMethod>]
    member __.TryMinByPass () =
        let result = 
            [|1.; 4.; 7.|]
            |> Array.tryMinBy (fun x -> x * 2.)
        Assert.AreEqual(Some 1., result)

    [<TestMethod>]
    member __.TryMinByFail () =
        let result = 
            Array.empty<float>
            |> Array.tryMinBy (fun x -> x * 2.)
        Assert.AreEqual(None, result)

    [<TestMethod>]
    member __.TryReducePass () =
        let result = 
            [|1.; 4.; 7.|]
            |> Array.tryReduce (+)
        Assert.AreEqual(Some 12., result)

    [<TestMethod>]
    member __.TryReduceFail () =
        let result = 
            Array.empty<float>
            |> Array.tryReduce (+)
        Assert.AreEqual(None, result)

    [<TestMethod>]
    member __.TryReduceBackPass () =
        let result = 
            [|1.; 4.; 7.|]
            |> Array.tryReduceBack (+)
        Assert.AreEqual(Some 12., result)

    [<TestMethod>]
    member __.TryReduceBackFail () =
        let result = 
            Array.empty<float>
            |> Array.tryReduceBack (+)
        Assert.AreEqual(None, result)

    [<TestMethod>]
    member __.TrySubPass () =
        let result = 
            Array.trySub [|1.; 4.; 7.|] 1 2
        Assert.AreEqual(Some [|4.; 7.|], result)

    [<TestMethod>]
    member __.TrySubFail () =
        let result = 
            Array.trySub [|1.; 4.; 7.|] -1 2
        Assert.AreEqual(None, result)

    [<TestMethod>]
    member __.TrySub2Fail () =
        let result = 
            Array.trySub [|1.; 4.; 7.|] 0 4
        Assert.AreEqual(None, result)

    [<TestMethod>]
    member __.TryZipPass () =
        let result = 
            Array.tryZip [|1|] [|2|]
        Assert.AreEqual(Some [|1, 2|], result)

    [<TestMethod>]
    member __.TryZipFail () =
        let result = 
            Array.tryZip [|1; 2|] [|2|]
        Assert.AreEqual(None, result)

    [<TestMethod>]
    member __.TryZip3Pass () =
        let result = 
            Array.tryZip3 [|1|] [|2|] [|3|]
        Assert.AreEqual(Some [|1, 2, 3|], result)

    [<TestMethod>]
    member __.TryZip3Fail () =
        let result = 
            Array.tryZip3 [|1; 2|] [|2|] [|3|]
        Assert.AreEqual(None, result)