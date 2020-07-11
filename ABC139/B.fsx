let [| A; B |] = stdin.ReadLine().Split(" ") |> Array.map int

let rec solve rest num = 
  if rest <= 0 then 
    num 
  else
    solve (rest - A + 1) (num + 1)

(if B = 1 then 0 else solve (B - A) 1) |> printfn "%d"