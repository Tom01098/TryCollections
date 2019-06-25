[<RequireQualifiedAccess>]
module Array
    
let inline tryAverage array =
    if Array.length array = 0 then None
    else array |> Array.average |> Some