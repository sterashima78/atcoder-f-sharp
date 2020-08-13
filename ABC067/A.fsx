stdin.ReadLine().Split(" ")
|> Array.map int
|> fun x ->
    if x |> Array.exists (fun x -> x % 3 = 0) then "Possible"
    else if x |> Array.reduce (+) |> (fun x -> x % 3 = 0) then "Possible"
    else "Impossible"
|> printfn "%s"
