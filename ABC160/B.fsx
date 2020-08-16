let readInt () = stdin.ReadLine() |> int

readInt ()
|> fun x ->
    let a = x / 500 * 1000
    let b = (x % 500) / 5 * 5
    a + b |> printfn "%d"
