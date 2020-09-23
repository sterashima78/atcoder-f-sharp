let d =
    new System.Collections.Generic.Dictionary<int * int, char>()

let readIntArray _ =
    stdin.ReadLine().Split(" ") |> Array.map int

let readCharArray _ = stdin.ReadLine().ToCharArray()

let getMineNum row col (d: System.Collections.Generic.Dictionary<int * int, char>) (r, c) =
    [ (r - 1, c - 1)
      (r - 1, c)
      (r - 1, c + 1)
      (r, c - 1)
      (r, c + 1)
      (r + 1, c - 1)
      (r + 1, c)
      (r + 1, c + 1) ]
    |> List.filter (fun (r, c) -> 0 < r && r <= row && 0 < c && c <= col)
    |> List.map (fun x -> d.Item(x))
    |> List.filter (fun c -> c = '#')
    |> List.length
    |> string
    |> char

()
|> readIntArray
|> fun [| row; col |] ->
    let getMnum = getMineNum row col d
    for x in 1 .. row do
        for (y, ch) in (() |> readCharArray |> Array.indexed) do
            let coord = (x, y + 1)
            d.Add(coord, ch)
    d.Keys
    |> Seq.map (fun (r, c) ->
        if d.Item((r, c)) = '#' then
            (r, c, '#')
        else
            let ch = (r, c) |> getMnum
            (r, c, ch))
    |> Seq.groupBy (fun (r, _, _) -> r)
    |> Seq.map (fun x ->
        x
        |> snd
        |> Seq.sortBy (fun (_, c, _) -> c)
        |> Seq.map (fun (_, _, ch) -> ch)
        |> Seq.toArray
        |> System.String)
    |> Seq.toArray
    |> String.concat "\n"
    |> printfn "%s"
