let rec solve num target =
  if num * num > target then
    "No"
  else if num * num = target then
    "Yes"
  else
    solve (num + 1) target
stdin.ReadLine().Split(" ") |> String.concat "" |> int |> solve 1 |> printfn "%s"