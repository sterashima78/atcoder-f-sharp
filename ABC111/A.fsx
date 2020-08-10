stdin.ReadLine().ToCharArray()
|> Array.map (fun x ->
    match x with
    | '1' -> '9'
    | '9' -> '1'
    | x -> x)
|> System.String
|> printfn "%s"
