stdin.ReadLine().Split(" ")
|> Array.map int
|> Array.groupBy id
|> Array.filter (fun (_, arr) ->
    arr
    |> Array.length
    |> fun x -> x = 1)
|> Array.head
|> fun (x, _) -> x
|> printfn "%d"
