let readCharArray () = stdin.ReadLine().ToCharArray()

let rec solve num chars =
    match chars with
    | 'A' :: 'B' :: 'C' :: xx -> solve (num + 1) xx
    | _ :: xx -> solve num xx
    | [] -> num

stdin.ReadLine()

readCharArray ()
|> Array.toList
|> solve 0
|> printfn "%d"
