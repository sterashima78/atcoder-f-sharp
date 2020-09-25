let readIntArray _ =
    stdin.ReadLine().Split(" ") |> Array.map int

let readInt _ = stdin.ReadLine() |> int


()
|> readInt
|> readIntArray
|> fun p ->
    p
    |> Array.fold (fun (min, count) x -> if x < min then (x, count + 1) else (min, count)) (p.[0], 1)
    |> snd
    |> printfn "%d"
