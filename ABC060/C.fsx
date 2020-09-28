let readIntArray _ =
    stdin.ReadLine().Split(" ") |> Array.map int64

let rec solve time sum list =
    match list with
    | [] -> sum
    | [ _ ] -> sum + time
    | x :: y :: xx -> if x + time <= y then solve time (sum + time) (y :: xx) else solve time (sum + y - x) (y :: xx)

()
|> readIntArray
|> fun [| _; t |] ->
    ()
    |> readIntArray
    |> Array.toList
    |> solve t 0L
    |> printfn "%d"
