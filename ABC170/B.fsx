let readIntArray () =
    stdin.ReadLine().Split(" ") |> Array.map int

let choice ok ng bool = if bool then ok else ng

readIntArray ()
|> fun [| x; all |] ->
    [ 0 .. x ]
    |> List.map (fun y -> y * 2 + (x - y) * 4)
    |> List.exists (fun x -> x = all)
    |> choice "Yes" "No"
    |> printfn "%s"
