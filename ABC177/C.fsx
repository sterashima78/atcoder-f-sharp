let readIntArray () =
    stdin.ReadLine().Split(" ") |> Array.map int64

readIntArray ()

let rec solve partSum sum list =
    match list with
    | x :: xx ->
        if partSum = -1L
        then solve x 0L xx
        else solve ((partSum + x) % 1000000007L) (sum + x * partSum % 1000000007L) xx
    | [] -> sum % 1000000007L

()
|> readIntArray
|> Array.toList
|> solve -1L 0L
|> printfn "%d"
