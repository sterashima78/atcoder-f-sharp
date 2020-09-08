let readCharArray () = stdin.ReadLine().ToCharArray()
let choice ok ng bool = if bool then ok else ng

let rec solve list =
    match list with
    | x :: y :: xx ->
        if x = 'c' && y = 'h' then solve xx
        else if x = 'o' || x = 'k' || x = 'u' then solve (y :: xx)
        else false
    | x :: xx -> if x = 'o' || x = 'k' || x = 'u' then solve xx else false
    | [] -> true

()
|> readCharArray
|> Array.toList
|> solve
|> choice "YES" "NO"
|> printfn "%s"
