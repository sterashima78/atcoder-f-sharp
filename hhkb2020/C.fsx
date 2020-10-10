let readInt _ = stdin.ReadLine() |> int

let readIntArray _ =
    stdin.ReadLine().Split(" ") |> Array.map int

let rec nextVal map current =
    if map |> Map.containsKey current then nextVal map (current + 1) else current

()
|> readInt
|> readIntArray
|> Array.mapFold (fun (minNum, map) num ->
    let newMap = map |> Map.add num num

    let current =
        if minNum < num then minNum else nextVal map (num + 1)

    (string current, (current, newMap))) (0, Map.empty)
|> fst
|> String.concat "\n"
|> printfn "%s"
