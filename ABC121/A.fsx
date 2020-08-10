stdin.ReadLine().Split(" ")
|> Array.map int
|> fun x ->
    stdin.ReadLine().Split(" ")
    |> Array.map int
    |> Array.zip x
    |> Array.map (fun (a, b) -> a - b)
    |> Array.reduce (*)
    |> printfn "%d"
