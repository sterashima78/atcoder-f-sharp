let b = stdin.ReadLine()

stdin.ReadLine().ToCharArray()
|> Array.toList
|> List.rev
|> (fun (x :: xx) -> xx)
|> List.rev
|> List.toArray
|> System.String
|> (fun x -> if x = b then "Yes" else "No")
|> printfn "%s"
