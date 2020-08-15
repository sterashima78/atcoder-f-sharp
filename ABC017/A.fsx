let readFloatArray () =
    stdin.ReadLine().Split(" ") |> Array.map float

[ 1 .. 3 ]
|> List.map (fun _ -> readFloatArray ())
|> List.map (fun [| a; b |] -> a * b / 10.0)
|> List.reduce (+)
|> int
|> printfn "%d"
