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