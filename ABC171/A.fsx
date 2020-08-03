stdin.ReadLine()
|> (fun a -> if System.Char.IsUpper(char a) then "A" else "a")
|> printfn "%s"
