let readCharArray _ = stdin.ReadLine().ToCharArray()

let rec solve count list =
    match list with
    | []
    | [ _ ] -> count
    | x :: [ y ] -> if x = y then count else count + 1
    | x :: y :: xx -> if x = y then solve (count) (y :: xx) else solve (count + 1) (y :: xx)

stdin.ReadLine()
|> readCharArray
|> Array.toList
|> solve 1
|> printfn "%d"
