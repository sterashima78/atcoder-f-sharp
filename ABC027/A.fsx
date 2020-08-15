let readIntArray () =
    stdin.ReadLine().Split(" ") |> Array.map int

readIntArray ()
|> Array.groupBy id
|> Array.filter (fun (_, arr) ->
    let l = Array.length arr
    l = 1 || l = 3)
|> Array.head
|> fun (x, _) -> x |> printfn "%d"
