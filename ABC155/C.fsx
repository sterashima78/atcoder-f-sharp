let readInt _ = stdin.ReadLine() |> int
let readCharArray _ = stdin.ReadLine().ToCharArray()

()
|> readInt
|> Seq.init
<| id
|> Seq.map (fun _ -> stdin.ReadLine())
|> Seq.fold (fun (max, map: Map<string, int>) str ->
    match map.TryFind str with
    | None -> if max = 0 then (1, map.Add(str, 1)) else (max, map.Add(str, 1))
    | Some num -> if max < num + 1 then (num + 1, map.Add(str, num + 1)) else (max, map.Add(str, num + 1)))
       (0, Map.empty)
|> fun (max, map) ->
    map
    |> Map.toSeq
    |> Seq.filter (fun (_, n) -> n = max)
|> Seq.map fst
|> Seq.sort
|> String.concat "\n"
|> printfn "%s"
