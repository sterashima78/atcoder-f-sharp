let readIntArray () =
    stdin.ReadLine().Split(" ") |> Array.map int

let choice ok ng bool = if bool then ok else ng

readIntArray ()
|> fun [| h; n |] ->
    readIntArray ()
    |> Array.sortDescending
    |> Array.take n
    |> Array.reduce (+)
    |> (<=) h
    |> choice "Yes" "No"
    |> printfn "%s"
