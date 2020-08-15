let readInt () = stdin.ReadLine() |> int

readInt ()
|> fun x ->
    if x % 2 = 1 then
        x / 2 + 1 |> printfn "%d"
        printfn "%d" 1
    else
        x / 2 |> printfn "%d"
    [ 1 .. x / 2 ]
    |> List.map (fun _ -> printfn "%d" 2)
