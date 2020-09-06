let readInt () = stdin.ReadLine() |> int

readInt ()
|> fun x ->
    if x < 100 then "00"
    else if x <= 5000 then x * 10 / 1000 |> sprintf "%02d"
    else if x <= 30000 then x / 1000 + 50 |> sprintf "%d"
    else if x <= 70000 then (x / 1000 - 30) / 5 + 80 |> sprintf "%d"
    else "89"
|> printfn "%s"
