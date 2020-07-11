
stdin.ReadLine()
let nums = stdin.ReadLine().Split(" ") |> Array.map double
let point = 
  nums 
  |> Array.reduce (+) 
  |> fun x -> x / (Array.length nums |> double)
  |> System.Math.Round

nums 
|> Array.map (fun x -> (x - point) * (x - point))
|> Array.reduce (+)
|> int
|> printfn "%d"