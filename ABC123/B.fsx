let readInt () = stdin.ReadLine() |> int

let rec solve addedLast ans list =
    match (addedLast, list) with
    | (true, x :: xx) -> if x % 10 = 0 then solve false (ans + x) xx else solve true (ans + x + (10 - x % 10)) xx
    | (false, x :: xx) -> if x % 10 = 0 then solve false (ans + x) xx else solve true (ans + x) xx
    | (_, []) -> ans

[ 1 .. 5 ]
|> List.map (fun _ -> () |> readInt)
|> List.sortBy (fun x -> x % 10)
|> solve false 0
|> printfn "%d"
