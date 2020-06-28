stdin.ReadLine()
|> int
|> fun a -> a + a * a + a * a * a
|> printfn "%d"
