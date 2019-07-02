[<RequireQualifiedAccess>]
module List

let inline tryAverage list =
    if List.isEmpty list then None
    else list |> List.average |> Some

let inline tryAverageBy projection list =
    if List.isEmpty list then None
    else list |> List.averageBy projection |> Some

let tryChunkBySize chunkSize list =
    if chunkSize < 1 then None
    else list |> List.chunkBySize chunkSize |> Some

let tryExactlyOne list =
    if List.length list <> 1 then None
    else list |> List.exactlyOne |> Some

let tryExists2 predicate list1 list2 =
    if List.length list1 <> List.length list2 then None
    else List.exists2 predicate list1 list2 |> Some

let tryFold2 folder state list1 list2 =
    if List.length list1 <> List.length list2 then None
    else (list1, list2) ||> List.fold2 folder state |> Some

let tryFoldBack2 folder state list1 list2 =
    if List.length list1 <> List.length list2 then None
    else List.foldBack2 folder list1 list2 state |> Some