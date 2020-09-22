let readInt _ = stdin.ReadLine() |> int

let readFloatArray _ =
    stdin.ReadLine().Split(" ") |> Array.map float

stdin.ReadLine()
|> readFloatArray
|> Array.sumBy (fun x -> 1.0 / x)
|> (/) 1.0
|> printfn "%f"
