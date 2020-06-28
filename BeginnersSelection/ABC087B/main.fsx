let c500 = stdin.ReadLine() |> int
let c100 = stdin.ReadLine() |> int
let c50 = stdin.ReadLine() |> int
let ans = stdin.ReadLine() |> int

[| for coin500 in 0 .. c500 do
    for coin100 in 0 .. c100 do
        for coin50 in 0 .. c50 -> (coin500, coin100, coin50) |]
|> Array.filter (fun (a, b, c) -> (500 * a + 100 * b + 50 * c) = ans)
|> Array.length
|> printfn "%d"
