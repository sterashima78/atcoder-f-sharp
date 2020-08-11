stdin.ReadLine().Split(" ")
|> Array.map int
|> fun [| a; b; x |] -> if a > x || a + b < x then "NO" else "YES"
|> printfn "%s"
