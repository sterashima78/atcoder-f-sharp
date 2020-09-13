let readIntArray _ =
    stdin.ReadLine().Split(" ") |> Array.map int

let judge a b n =
    n
    |> string
    |> fun x -> x.ToCharArray()
    |> Array.map string
    |> Array.map int
    |> Array.sum
    |> fun x -> a <= x && x <= b

()
|> readIntArray
|> fun [| n; a; b |] ->
    Array.init n (fun i -> i + 1)
    |> Array.filter (judge a b)
    |> Array.sum
|> printfn "%d"
