stdin.ReadLine().Split(" ")
|> Array.map int
|> Array.map (fun x -> if x = 1 then 14 else x)
|> Array.reduce (-)
|> fun x ->
    if x = 0 then "Draw"
    else if x > 0 then "Alice"
    else "Bob"
|> printfn "%s"
