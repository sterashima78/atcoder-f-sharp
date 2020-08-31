let readIntArray () =
    stdin.ReadLine().Split(" ") |> Array.map int

let rec solve maxVal ans list =
    match list with
    | x :: xx -> if x >= maxVal then solve x (ans + 1) xx else solve maxVal ans xx
    | [] -> ans

stdin.ReadLine()

()
|> readIntArray
|> Array.toList
|> solve 0 0
|> printfn "%d"
