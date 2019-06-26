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
    else array |> Array.exactlyOne |> Some

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

let trySet array index value =
    if index >= Array.length array || index < 0 then None
    else value |> Array.set array index |> Some

let trySub array startIndex count =
    if startIndex < 0 
        || startIndex + count > Array.length array
        || count < 1 
    then None
    else Array.sub array startIndex count |> Some

let tryZip array1 array2 =
    if Array.length array1 = Array.length array2
    then Array.zip array1 array2 |> Some
    else None

let tryZip3 array1 array2 array3 =
    if Array.length array1 <> Array.length array2
        || Array.length array1 <> Array.length array3
    then None
    else Array.zip3 array1 array2 array3 |> Some