let readIntArray _ =
    stdin.ReadLine().Split(" ") |> Array.map int

let readInt _ = stdin.ReadLine() |> int

()
|> readIntArray
|> fun [| n; p; q |] ->
    let map =
        q
        |> Seq.init
        <| readInt
        |> Seq.fold (fun (map: Map<int, int>) x ->
            match map.TryFind x with
            | None -> map.Add(x, 1)
            | Some y -> map.Add(x, y + 1)) Map.empty

    for x in 1 .. n do
        match map.TryFind x with
        | None -> if p - q > 0 then printfn "Yes" else printfn "No"
        | Some y -> if (p + y - q) > 0 then printfn "Yes" else printfn "No"
