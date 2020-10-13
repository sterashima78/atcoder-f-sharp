let readIntArray _ =
    stdin.ReadLine().Split(" ") |> Array.map int64

let toDigit n = n |> string |> String.length |> int64

let canBuy a b num x = a * num + b * (num |> toDigit) <= x

let rec solve a b x (s, l) =
    if l - s = 1L then if canBuy a b l x then l else s
    elif canBuy a b ((s + l) / 2L) x then solve a b x ((s + l) / 2L, l)
    else solve a b x (s, (s + l) / 2L)

()
|> readIntArray
|> fun [| a; b; x |] ->
    let start = 1000000000L
    if canBuy a b start x then start else solve a b x (0L, start)
|> printfn "%d"
