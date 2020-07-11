let rec solve num upper = 
  if num * 2 <= upper then
    solve (num * 2) upper
  else
    num
stdin.ReadLine() |> int |> solve 1 |> printfn "%d"