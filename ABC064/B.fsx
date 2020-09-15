let readIntArray _ =
    stdin.ReadLine().Split(" ") |> Array.map int

stdin.ReadLine()
|> readIntArray
|> Array.sort
|> fun x -> (x |> Array.last) - (x |> Array.head)
|> printfn "%d"
