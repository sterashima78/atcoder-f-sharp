let readIntArray _ =
    stdin.ReadLine().Split(" ") |> Array.map int64

let rec solve strong maxStrong a b exp =
    if strong >= maxStrong
    then exp - 1L
    elif maxStrong - b <= strong && maxStrong / a <= strong
    then exp
    elif strong < b / a
    then solve (strong * a) maxStrong a b (exp + 1L)
    else solve (strong + b * ((maxStrong - strong) / b)) maxStrong a b (exp + ((maxStrong - strong) / b))

()
|> readIntArray
|> fun [| x; y; a; b |] -> solve x y a b 0L
|> printfn "%d"
