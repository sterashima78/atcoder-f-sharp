stdin.ReadLine()
|> (fun x -> if x = "ABC" then "ARC" else "ABC")
|> printfn "%s"
