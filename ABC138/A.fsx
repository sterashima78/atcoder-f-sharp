stdin.ReadLine()
|> int
|> (fun x -> if x >= 3200 then stdin.ReadLine() else "red")
|> printfn "%s"
