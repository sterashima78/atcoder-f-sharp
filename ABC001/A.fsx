let readInt () = stdin.ReadLine() |> int

readInt () |> (-) <| readInt () |> printfn "%d"
