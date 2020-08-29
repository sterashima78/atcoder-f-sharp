let readCharArray () = stdin.ReadLine().ToCharArray()

let rec solve min query target =
    if (target |> List.length) < (query |> List.length) then
        min
    else
        target
        |> List.take (query |> List.length)
        |> List.zip query
        |> List.filter (fun (a, b) -> a <> b)
        |> List.length
        |> fun x -> if min <= x then min else x
        |> fun x -> solve x query (target |> List.tail)

let target = readCharArray () |> Array.toList

readCharArray ()
|> Array.toList
|> fun query -> solve (query |> List.length) query target
|> printfn "%d"
