let [| sA; sB |] = stdin.ReadLine().Split(" ")

let [| a; b |] =
    stdin.ReadLine().Split(" ") |> Array.map int

stdin.ReadLine()
|> (fun x -> if sA = x then (a - 1, b) else (a, b - 1))
|> (fun (x, y) -> printfn "%d %d" x y)
