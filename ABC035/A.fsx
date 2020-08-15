let readFloatArray () =
    stdin.ReadLine().Split(" ") |> Array.map float

readFloatArray ()
|> Array.rev
|> Array.reduce (/)
|> fun x -> if x = 0.75 then "4:3" else "16:9"
|> printfn "%s"
