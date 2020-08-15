let readInt () = stdin.ReadLine() |> int

readInt () |> (*) 2 |> printfn "%d"
