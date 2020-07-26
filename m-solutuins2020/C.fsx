let rec solve pairs ans (arr: int []) =
    match pairs with
    | [] -> ans
    | (a, b) :: pairs -> if arr.[a] < arr.[b] then solve pairs ("Yes" :: ans) arr else solve pairs ("No" :: ans) arr

let [| n; k |] =
    stdin.ReadLine().Split(" ") |> Array.map int

let pair =
    [ for x in [ k .. (n - 1) ] do
        (x - k, x) ]


stdin.ReadLine().Split(" ")
|> Array.map int
|> solve pair []
|> List.rev
|> String.concat "\n"
|> printfn "%s"
