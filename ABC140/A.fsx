stdin.ReadLine()
|> int
|> (fun x -> x * x * x)
|> printfn "%d"
