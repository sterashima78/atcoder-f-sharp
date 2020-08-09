let rec squash tList fList =
    match fList with
    | [] -> tList
    | x :: [ y ] -> if x = y then squash (x :: tList) [] else squash (y :: x :: tList) ([])
    | x :: y :: xx -> if x = y then squash tList (y :: xx) else squash (x :: tList) (y :: xx)

stdin.ReadLine().ToCharArray()
|> Array.toList
|> fun x ->
    let l = x |> squash [] |> List.length
    if l = List.length x then printfn "Good" else printfn "Bad"
