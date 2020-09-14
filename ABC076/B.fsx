let readInt _ = stdin.ReadLine() |> int

let rec solve num count add =
    match count with
    | 0 -> num
    | c -> if num < add then solve (num + num) (c - 1) add else solve (num + add) (c - 1) add

(readInt (), readInt ())
|> fun (count, add) -> solve 1 count add
|> printfn "%d"
