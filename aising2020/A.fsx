let [| l; r; d |] = stdin.ReadLine().Split(" ") |> Array.map int
[l..r] 
|> List.filter (fun x -> x % d = 0)
|> List.length
|> printfn "%d"