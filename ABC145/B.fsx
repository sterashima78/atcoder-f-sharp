let readInt () = stdin.ReadLine() |> int
let readCharArray () = stdin.ReadLine().ToCharArray()
let choice ok ng bool = if bool then ok else ng

readInt ()
|> fun x ->
    if x % 2 = 1 then
        "No"
    else
        readCharArray ()
        |> fun y ->
            let pre = y |> Array.take (x / 2) |> System.String

            let post =
                y
                |> Array.rev
                |> Array.take (x / 2)
                |> Array.rev
                |> System.String

            (pre = post) |> choice "Yes" "No"
|> printfn "%s"
