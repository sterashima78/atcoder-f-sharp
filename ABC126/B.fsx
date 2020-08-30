let readAsInt () =
    stdin.ReadLine()
    |> fun s -> (int s.[0..1], int s.[2..3])

let isLikeMonth num = 1 <= num && num <= 12

()
|> readAsInt
|> fun (a, b) ->
    if isLikeMonth a && isLikeMonth b then "AMBIGUOUS"
    else if isLikeMonth a && isLikeMonth b |> not then "MMYY"
    else if isLikeMonth a |> not && isLikeMonth b then "YYMM"
    else "NA"
    |> printfn "%s"
