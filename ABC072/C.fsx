let readIntArray _ =
    stdin.ReadLine().Split(" ") |> Array.map int

stdin.ReadLine()
|> readIntArray
|> Array.collect (fun x -> [| x - 1; x; x + 1 |])
|> Array.countBy id
|> Array.maxBy snd
|> snd
|> printfn "%d"
