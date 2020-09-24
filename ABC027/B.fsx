let readInt _ = stdin.ReadLine() |> int

let readIntArray _ =
    stdin.ReadLine().Split(" ") |> Array.map int

let rec solve num ans members =
    match members with
    | [] -> ans
    | [ _ ] -> ans
    | a :: [ _ ] -> if a = num then ans else ans + 1
    | a :: b :: xx ->
        if a = num
        then solve num ans (b :: xx)
        elif a > num
        then solve num (ans + 1) ((a - num + b) :: xx)
        else solve num (ans + 1) ((b - num + a) :: xx)

()
|> readInt
|> fun x ->
    let members = () |> readIntArray
    let sum = members |> Array.sum
    if sum % x <> 0
    then -1
    else solve (sum / x) 0 (members |> Array.toList)
|> printfn "%d"
