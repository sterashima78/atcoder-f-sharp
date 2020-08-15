let readInt () = stdin.ReadLine() |> int

readInt () |> (-) <| 1 |> printfn "%d"
