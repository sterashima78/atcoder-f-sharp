let readFloatArray () =
    stdin.ReadLine().Split(" ") |> Array.map float

stdin.ReadLine()

()
|> readFloatArray
|> Array.filter ((<) 0.0)
|> Array.average
|> System.Math.Ceiling
|> int
|> printfn "%d"
