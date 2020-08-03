stdin.ReadLine()
|> float
|> (fun x -> x * 2.0 * 3.141592)
|> printfn "%f"
