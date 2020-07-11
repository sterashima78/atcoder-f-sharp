let [| n; m; c; |] = stdin.ReadLine().Split(" ") |> Array.map int
let B = stdin.ReadLine().Split(" ") |> Array.map int |> Array.toList
[1 .. n]
|> List.map (
  fun _ -> 
    stdin.ReadLine().Split(" ") 
    |> Array.map int 
    |> Array.toList 
    |> List.zip B
    |> List.map (fun (a,b) -> a*b)
    |> List.reduce (+)
  )
|> List.filter (fun x -> x + c > 0)
|> List.length
|> printfn "%d"