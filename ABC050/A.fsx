stdin.ReadLine().Split(" ")
|> fun x -> if x.[1] = "+" then (int x.[0]) + (int x.[2]) else (int x.[0]) - (int x.[2])
|> printfn "%d"
