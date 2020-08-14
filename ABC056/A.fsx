stdin.ReadLine().Split(" ")
|> Array.map (fun x -> if x = "H" then 1 else -1)
|> Array.reduce (*)
|> fun x -> if x = 1 then "H" else "D"
|> printfn "%s"
