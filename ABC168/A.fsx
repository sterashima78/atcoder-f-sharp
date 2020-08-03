stdin.ReadLine().ToCharArray()
|> Array.rev
|> Array.head
|> string
|> int
|> (fun i ->
    match i with
    | 2
    | 4
    | 5
    | 7
    | 9 -> "hon"
    | 0
    | 1
    | 6
    | 8 -> "pon"
    | _ -> "bon")
|> printfn "%s"
