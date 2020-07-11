let [| h; w |] = stdin.ReadLine().Split(" ") |> Array.map int64

let ans = 
  if h = int64 1 || w = int64 1 then
    int64 1
  else 
    (w * h + int64 1) / int64 2
ans |> printfn "%d"