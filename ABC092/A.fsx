[| (stdin.ReadLine() |> int, stdin.ReadLine() |> int)
   (stdin.ReadLine() |> int, stdin.ReadLine() |> int) |]
|> Array.map (fun (a, b) -> if a > b then b else a)
|> Array.reduce (+)
|> printfn "%d"
