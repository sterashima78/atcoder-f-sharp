let readIntArray () =
    stdin.ReadLine().Split(" ") |> Array.map int

stdin.ReadLine()

()
|> readIntArray
|> Array.zip
<| (() |> readIntArray)
|> Array.map (fun (v, c) -> v - c)
|> Array.filter ((<) 0)
|> Array.sum
|> printfn "%d"
