let readInt _ = stdin.ReadLine() |> int

let readIntArray _ =
    stdin.ReadLine().Split(" ") |> Array.map int

()
|> readInt
|> fun num ->
    let map =
        ()
        |> readIntArray
        |> Array.fold (fun map x ->
            map
            |> Map.tryFind x
            |> fun z ->
                match z with
                | None -> map.Add(x, 1)
                | Some y -> map.Add(x, y + 1)) Map.empty

    for x in 1 .. num do
        match map.TryFind x with
        | None -> printfn "0"
        | Some z -> printfn "%d" z
