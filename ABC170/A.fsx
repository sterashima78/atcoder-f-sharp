stdin.ReadLine().Split(" ")
|> Array.map int
|> Array.findIndex (fun x -> x = 0)
|> (+) 1
|> printfn "%d"
