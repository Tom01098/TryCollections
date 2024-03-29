﻿[<RequireQualifiedAccess>]
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

let tryForall2 predicate list1 list2 =
    if List.length list1 <> List.length list2 then None
    else (list1, list2) ||> List.forall2 predicate |> Some

let tryIter2 action list1 list2 =
    if List.length list1 <> List.length list2 then None
    else (list1, list2) ||> List.iter2 action |> Some

let tryMap2 mapping list1 list2 =
    if List.length list1 <> List.length list2 then None
    else (list1, list2) ||> List.map2 mapping |> Some

let tryMap3 mapping list1 list2 list3 =
    if List.length list1 <> List.length list2 || List.length list1 <> List.length list3 then None
    else (list1, list2, list3) |||> List.map3 mapping |> Some

let tryMax list =
    if List.isEmpty list then None
    else list |> List.max |> Some

let tryMaxBy projection list =
    if List.isEmpty list then None
    else list |> List.maxBy projection |> Some

let tryMin list =
    if List.isEmpty list then None
    else list |> List.min |> Some

let tryMinBy projection list =
    if List.isEmpty list then None
    else list |> List.minBy projection |> Some

let tryReduce reduction list =
    if List.isEmpty list then None
    else list |> List.reduce reduction |> Some

let tryReduceBack reduction list =
    if List.isEmpty list then None
    else list |> List.reduceBack reduction |> Some