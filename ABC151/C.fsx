let readIntArray _ =
    stdin.ReadLine().Split(" ") |> Array.map int

()
|> readIntArray
|> fun [| _; m |] -> if m = 0 then Seq.empty else seq { 1 .. m }
|> Seq.map (fun _ ->
    let [| i; c |] = stdin.ReadLine().Split(" ")
    (int i, c))
|> Seq.fold (fun (map: Map<int, (int * int)>) (i, c) ->
    match (i, c, map.TryFind i) with
    | (num, "AC", None) -> map.Add(num, (1, 0))
    | (num, _, None) -> map.Add(num, (0, 1))
    | (_, _, Some (1, _)) -> map
    | (num, "AC", Some (_, wa)) -> map.Add(num, (1, wa))
    | (num, _, Some (_, wa)) -> map.Add(num, (0, wa + 1))) Map.empty
|> Map.fold (fun (ac, wa) _ (ac1, wa1) -> if ac1 = 0 then (ac, wa) else (ac + ac1, wa + wa1)) (0, 0)
|> fun (ac, wa) -> printfn "%d %d" ac wa
