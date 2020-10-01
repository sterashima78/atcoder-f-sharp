let readIntArray _ =
    stdin.ReadLine().Split(" ") |> Array.map int

let rec count c i =
    if i % 2 = 0 then count (c + 1) (i / 2) else c

stdin.ReadLine()
|> readIntArray
|> Array.sumBy (count 0)
|> printfn "%d"
