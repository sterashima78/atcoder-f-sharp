let readIntArray _ =
    stdin.ReadLine().Split(" ") |> Array.map int64

let rec gcd a b = if b = 0L then a else gcd b (a % b)
let lcm a b = a |> (/) <| gcd a b |> (*) b

stdin.ReadLine()
|> readIntArray
|> Array.sumBy ((-) 1L)
|> (*) (-1L)
|> printfn "%d"
