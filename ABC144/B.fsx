let readInt () = stdin.ReadLine() |> int
let choice ok ng bool = if bool then ok else ng

readInt ()
|> fun z ->
    [ for x in 1 .. 9 do
        for y in 1 .. 9 -> x * y ]
    |> List.exists ((=) z)
    |> choice "Yes" "No"
    |> printfn "%s"
