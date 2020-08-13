stdin.ReadLine().Split(" ")
|> Array.map (fun x ->
    match x with
    | "2" -> "X"
    | "4"
    | "6"
    | "9"
    | "11" -> "Y"
    | _ -> "Z")
|> Array.groupBy id
|> Array.length
|> fun x -> if x = 1 then "Yes" else "No"
|> printfn "%s"
