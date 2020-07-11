stdin.ReadLine()
let K = stdin.ReadLine() |> int

stdin.ReadLine().Split(" ") 
|> Array.map int
|> Array.map (fun x -> if x > abs (x - K) then abs (x - K) * 2 else x * 2)
|> Array.reduce (+)
|> printfn "%d"