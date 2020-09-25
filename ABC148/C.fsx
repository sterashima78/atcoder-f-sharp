let rec gcd a b = if b = 0L then a else gcd b (a % b)
let lcm a b = a |> (/) <| gcd a b |> (*) b

let readIntArray _ =
    stdin.ReadLine().Split(" ") |> Array.map int64

()
|> readIntArray
|> fun [| a; b |] -> lcm a b
|> printfn "%d"
