let [| n; k |] = stdin.ReadLine().Split(" ") |> Array.map int64

let rec solve k current : int64 = 
  let absVal = abs(k - current) |> int64
  if current > absVal then
    solve k absVal
  else
    current

n % k 
|> int64
|> solve k 
|> string
|> printfn "%s"