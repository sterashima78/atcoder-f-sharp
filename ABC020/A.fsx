let readInt () = stdin.ReadLine() |> int

readInt ()
|> fun x -> if x = 1 then "ABC" else "chokudai"
|> printfn "%s"
