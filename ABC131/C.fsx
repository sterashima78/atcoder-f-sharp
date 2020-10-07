let readIntArray _ =
    stdin.ReadLine().Split(" ") |> Array.map int64

let rec gcd a b = if b = 0L then a else gcd b (a % b)
let lcm a b = a |> (/) <| gcd a b |> (*) b

let count a c d =
    let cd = lcm c d
    let ac = a / c
    let ad = a / d
    let acd = a / cd
    a - (ac + ad - acd)

()
|> readIntArray
|> fun [| a; b; c; d |] -> (count b c d) - (count (a - 1L) c d)
|> printfn "%d"
