let read _ = stdin.ReadLine()

()
|> read
|> function
| "Y" ->
    ()
    |> read
    |> fun c -> c.ToUpper()
| _ -> () |> read
|> printfn "%s"
