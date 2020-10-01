let readCharArray _ = stdin.ReadLine().ToCharArray()

let p = ((+), "+")

let m = ((-), "-")

()
|> readCharArray
|> Array.map string
|> Array.map int
|> fun [| a; b; c; d |] ->
    [ (p, p, p)
      (p, p, m)
      (p, m, p)
      (p, m, m)
      (m, p, p)
      (m, p, m)
      (m, m, p)
      (m, m, m) ]
    |> List.filter (fun ((x, _), (y, _), (z, _)) -> a |> x <| b |> y <| c |> z <| d |> (=) 7)
    |> List.head
    |> fun ((_, x), (_, y), (_, z)) -> printfn "%d%s%d%s%d%s%d=7" a x b y c z d
