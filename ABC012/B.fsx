let readInt () = stdin.ReadLine() |> int

readInt ()
|> fun x -> printfn "%02d:%02d:%02d" (x / 3600) (x % 3600 / 60) (x % 3600 % 60)
