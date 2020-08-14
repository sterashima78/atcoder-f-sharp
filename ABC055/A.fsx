stdin.ReadLine()
|> int
|> fun x -> x * 800 - x / 15 * 200
|> printfn "%d"
