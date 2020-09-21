let readIntArray _ =
    stdin.ReadLine().Split(" ") |> Array.map int

let readInt _ = stdin.ReadLine() |> int

()
|> readIntArray
|> fun [| l; r |] ->
    ()
    |> readInt
    |> fun x -> [ 1 .. x ]
    |> List.map readInt
    |> List.map (fun x ->
        if x < l then l - x
        elif r < x then -1
        else 0)
    |> List.map string
    |> String.concat "\n"
    |> printfn "%s"
