let readIntArray () =
    stdin.ReadLine().Split(" ") |> Array.map int64

let rec solve sum before list =
    match list with
    | [] -> sum
    | x :: xx -> if x > before then solve sum x xx else solve (sum + (before - x)) before xx

stdin.ReadLine()

readIntArray ()
|> Array.toList
|> solve 0L 0L
|> printfn "%d"
