stdin.ReadLine()
|> int
|> (fun n -> if n >= 30 then "Yes" else "No")
|> printfn "%s"
