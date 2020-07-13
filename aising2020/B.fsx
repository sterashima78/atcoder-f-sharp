stdin.ReadLine()
stdin.ReadLine().Split(" ") 
|> Array.map int
|> Array.indexed
|> Array.filter (fun (index, num)-> index % 2 = 0 && num % 2 = 1)
|> Array.length
|> printfn "%d"