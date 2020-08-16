let readInt () = stdin.ReadLine() |> int64

let rec solve year v target =
    if target <= v then year else solve (year + 1L) (v + v / 100L) target

readInt () |> solve 0L 100L |> printfn "%d"
