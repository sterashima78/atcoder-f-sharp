let readInt () = stdin.ReadLine() |> int
let readCharArray () = stdin.ReadLine().ToCharArray()

readInt ()
|> fun x ->
    readCharArray ()
    |> fun y ->
        if Array.length y > x then
            y
            |> Array.take x
            |> System.String
            |> printfn "%s..."
        else
            y |> System.String |> printfn "%s"
