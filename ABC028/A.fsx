let readInt () = stdin.ReadLine() |> int

readInt ()
|> fun x ->
    if x = 100 then "Perfect"
    else if x >= 90 then "Great"
    else if x >= 60 then "Good"
    else "Bad"
    |> printfn "%s"
