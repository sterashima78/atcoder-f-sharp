let readIntArray () =
    stdin.ReadLine().Split(" ") |> Array.map int

readIntArray ()
|> Array.reduce (-)
|> fun x -> if x < 0 then "Better" else "Worse"
|> printfn "%s"
