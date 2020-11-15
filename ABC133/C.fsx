let readIntArray _ =
    stdin.ReadLine().Split(" ") |> Array.map int64

let modmul m x y = ((x % m) * (y % m)) % m

()
|> readIntArray
|> fun [| l; r |] ->
    match seq { l .. r }
          |> Seq.exists (fun x -> x % 2019L = 0L) with
    | true -> 0L
    | false ->
        seq {
            for i in [ l % 2019L .. r % 2019L ] do
                for j in [ i + 1L .. r % 2019L ] do
                    modmul 2019L i j
        }
        |> Seq.min
|> printfn "%d"
