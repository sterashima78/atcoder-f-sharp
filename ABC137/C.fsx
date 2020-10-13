let readInt _ = stdin.ReadLine() |> int

let readCharArray _ =
    stdin.ReadLine().ToCharArray()
    |> Array.sort
    |> System.String


()
|> readInt
|> fun x -> [| 1 .. x |] |> Array.map readCharArray
|> Array.fold (fun (map: Map<string, int64>) str ->
    map
    |> Map.tryFind str
    |> function
    | Some num -> map |> Map.add str (num + 1L)
    | None -> map |> Map.add str 1L) Map.empty
|> Map.toSeq
|> Seq.filter (fun (_, i) -> i > 1L)
|> Seq.map snd
|> Seq.sumBy (fun x -> x * (x - 1L) / 2L)
|> printfn "%d"
