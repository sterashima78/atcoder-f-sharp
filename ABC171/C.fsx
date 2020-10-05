let readInt _ = stdin.ReadLine() |> int64
let alphabet = [| 'a' .. 'z' |]

let rec solve ans current =
    if current / 26L > 0L then
        let a = alphabet.[(current % 26L) |> int]
        solve (a :: ans) (current / 26L - 1L)
    else
        (alphabet.[(current % 26L) |> int] :: ans)

()
|> readInt
|> (-)
<| 1L
|> solve []
|> List.toArray
|> System.String
|> printfn "%s"
