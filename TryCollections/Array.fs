[<RequireQualifiedAccess>]
module Array
    
let inline tryAverage array =
    if Array.isEmpty array then None
    else array |> Array.average |> Some

let inline tryAverageBy projection array =
    if Array.isEmpty array then None
    else array |> Array.averageBy projection |> Some

let tryChunkBySize chunkSize array =
    if chunkSize < 1 then None
    else array |> Array.chunkBySize chunkSize |> Some

let tryExactlyOne array =
    if Array.length array <> 1 then None
    else array |> Array.exactlyOne

let tryGet array index =
    if index >= Array.length array || index < 0 then None
    else Array.get array index |> Some

let tryMax array =
    if Array.isEmpty array then None
    else array |> Array.max |> Some

let tryMaxBy projection array =
    if Array.isEmpty array then None
    else array |> Array.maxBy projection |> Some

let tryMin array =
    if Array.isEmpty array then None
    else array |> Array.min |> Some

let tryMinBy projection array =
    if Array.isEmpty array then None
    else array |> Array.minBy projection |> Some

let tryReduce reduction array =
    if Array.isEmpty array then None
    else array |> Array.reduce reduction |> Some

let tryReduceBack reduction array =
    if Array.isEmpty array then None
    else array |> Array.reduceBack reduction |> Some