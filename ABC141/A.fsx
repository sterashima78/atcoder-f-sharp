stdin.ReadLine()
|> (fun x ->
    match x with
    | "Sunny" -> "Cloudy"
    | "Cloudy" -> "Rainy"
    | _ -> "Sunny")
|> printfn "%s"
