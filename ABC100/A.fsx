stdin.ReadLine().Split(" ")
|> Array.filter (fun x -> int x <= 8)
|> fun x -> if Array.length x = 2 then "Yay!" else ":("
|> printfn "%s"
