let readIntArray _ =
    stdin.ReadLine().Split(" ") |> Array.map int

let rec solve count list =
    match list with
    | (num1, c1, a1) :: (num2, c2, a2) :: xx ->
        if num2 - num1 = 1
        then solve (c1 + a1 + count) ((num2, c2, a2) :: xx)
        else solve (c1 + count) ((num2, c2, a2) :: xx)
    | [ (_, c1, _) ] -> solve (c1 + count) []
    | [] -> count

stdin.ReadLine()
|> readIntArray
|> Array.indexed
|> Array.sortBy snd
|> Array.zip
<| (readIntArray ())
|> Array.map (fun ((i, n), a) -> (i, n, a))
|> Array.zip (Array.append (readIntArray ()) [| 0 |])
|> Array.sortBy (fun (_, (i, _, _)) -> i)
|> Array.map (fun (a, (_, i, c)) -> (i, c, a))
|> Array.toList
|> solve 0
|> printfn "%d"
