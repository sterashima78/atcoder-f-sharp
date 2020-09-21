let readIntArray _ =
    stdin.ReadLine().Split(" ") |> Array.map int64

let modmul m x y = ((x % m) * (y % m)) % m
let mul = modmul 1000000007L

()
|> readIntArray
|> Array.reduce mul
|> printfn "%d"
